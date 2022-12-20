import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";
import { Activity } from "../models/activity";
import { router } from "../router/Routes";

const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay);
    })
}

axios.defaults.baseURL = 'http://localhost:5000/api';

axios.interceptors.response.use(async response => {
    await sleep(700);
    return response;
}, (error: AxiosError) => {
    const { data, status } = error.response!;
    switch (status) {
        case 400:
            toast.error('bad request');
            break;
        case 401:
            toast.error('unauthorized');
            break;
        case 403:
            toast.error('forbidden');
            break;
        case 404:
            router.navigate('/not-found');
            break;
        case 500:
            toast.error('internal server error');
            break;
        default:
            break;
    }
    return Promise.reject(error);
})

const resonseBody = <T>(response: AxiosResponse<T>) => response.data;

const requests = {
    get: <T>(url: string) => axios.get<T>(url).then(resonseBody),
    post: <T>(url: string, body: {}) => axios.post<T>(url, body).then(resonseBody),
    put: <T>(url: string, body: {}) => axios.put<T>(url, body).then(resonseBody),
    delete: <T>(url: string) => axios.delete<T>(url).then(resonseBody)
}

const activityApiClient = {
    getActivities: () => requests.get<Activity[]>('/activities'),
    getActivity: (id: string) => requests.get<Activity>(`/activities/${id}`),
    addActivity: (activity: Activity) => requests.post<void>('/activities', activity),
    updateActivity: (activity: Activity) => requests.put<void>('/activities', activity),
    deleteActivity: (id: string) => requests.delete<void>(`/activities/${id}`)
}

export default activityApiClient;