import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";
import { Activity } from "../models/activity";
import { User, UserFormValues } from "../models/user";
import { router } from "../router/Routes";
import { store } from "../stores/storeContext";

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
    const { data, status } = error.response as AxiosResponse;
    switch (status) {
        case 400:
            if(data.errors) {
                const modalStateErrors = [];
                for (const key in data.errors) {
                    if(data.errors[key]) {
                        modalStateErrors.push(data.errors[key]);
                    }
                }
                throw modalStateErrors.flat();
            } else {
                toast.error(data);
            }
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
            store.commonStore.setServerError(data);
            router.navigate('/server-error');
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

const ActivityApiClient = {
    getActivities: () => requests.get<Activity[]>('/activities'),
    getActivity: (id: string) => requests.get<Activity>(`/activities/${id}`),
    addActivity: (activity: Activity) => requests.post<void>('/activities', activity),
    updateActivity: (activity: Activity) => requests.put<void>('/activities', activity),
    deleteActivity: (id: string) => requests.delete<void>(`/activities/${id}`)
}

const AccountApiClient = {
    current: () => requests.get<User>('/account'),
    login: (user: UserFormValues) => requests.post<User>('/account/login', user),
    register: (user: UserFormValues) => requests.post<User>('account/register', user)
}

const apiClient = {
    ActivityApiClient,
    AccountApiClient
}

export default apiClient;