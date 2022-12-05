import axios, { AxiosResponse } from "axios";
import { Activity } from "../models/activity";

axios.defaults.baseURL = 'http://localhost:5000/api';

const resonseBody = <T> (response: AxiosResponse<T>) => response.data;

const requests = {
    get: <T> (url: string) => axios.get<T>(url).then(resonseBody),
    post: <T> (url: string, body: {}) => axios.post<T>(url, body).then(resonseBody),
    put: <T> (url: string, body: {}) => axios.put<T>(url, body).then(resonseBody),
    delete: <T> (url: string) => axios.delete<T>(url).then(resonseBody)
}

const ActivityRequests = {
    getActivities: () => requests.get<Activity[]>('/activities')
}

export default ActivityRequests;