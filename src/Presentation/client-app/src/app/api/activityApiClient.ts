import axios, { AxiosResponse } from "axios";
import { Activity } from "../models/activity";

const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay);
    })
}

const client = axios.create({
    baseURL: 'http://localhost:5000/api'
  });

  client.interceptors.response.use(async response => {
    try {
        await sleep(700);
        return response;
    } catch (error) {
        console.log(error);
        return await Promise.reject(error);
    }
})

const resonseBody = <T> (response: AxiosResponse<T>) => response.data;

const requests = {
    get: <T> (url: string) => client.get<T>(url).then(resonseBody),
    post: <T> (url: string, body: {}) => client.post<T>(url, body).then(resonseBody),
    put: <T> (url: string, body: {}) => client.put<T>(url, body).then(resonseBody),
    delete: <T> (url: string) => client.delete<T>(url).then(resonseBody)
}

const activityApiClient = {
    getActivities: () => requests.get<Activity[]>('/activities'),
    getActivity: (id: string) => requests.get<Activity>(`/activities/${id}`),
    addActivity: (activity: Activity) => requests.post<void>('/activities', activity),
    updateActivity: (activity: Activity) => requests.put<void>('/activities', activity),
    deleteActivity: (id: string) => requests.delete<void>(`/activities/${id}`)
}

export default activityApiClient;