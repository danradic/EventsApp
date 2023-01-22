import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";
import { Activity, ActivityFormValues } from "../models/activity";
import { Photo, Profile, UserActivity } from "../models/profile";
import { User, UserFormValues } from "../models/user";
import { router } from "../router/Routes";
import { store } from "../stores/storeContext";

const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay);
    })
}

axios.defaults.baseURL = 'http://localhost:5000/api';

axios.interceptors.request.use(config => {
    const token = store.commonStore.token;
    const tokenExpireDate = store.commonStore.tokenExpireDate;
    const isTokenExpired = store.commonStore.isTokenExpired(tokenExpireDate);

    if (token && config.headers && !isTokenExpired) {
        config.headers =
        {
            "Authorization": `Bearer ${token}`
        }
    }

    return config;
});

axios.interceptors.response.use(async response => {
    await sleep(700);
    return response;
}, (error: AxiosError) => {
    const { data, status } = error.response as AxiosResponse;
    switch (status) {
        case 400:
            if (data.errors) {
                const modalStateErrors = [];
                for (const key in data.errors) {
                    if (data.errors[key]) {
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

const Activities = {
    getActivities: () => requests.get<Activity[]>('/activities'),
    getActivity: (id: string) => requests.get<Activity>(`/activities/${id}`),
    addActivity: (activity: ActivityFormValues) => requests.post<void>('/activities', activity),
    updateActivity: (activity: ActivityFormValues) => requests.put<void>('/activities', activity),
    deleteActivity: (id: string) => requests.delete<void>(`/activities/${id}`),
    attend: (id: string) => requests.post<void>(`/activities/${id}/attend`, {})
}

const Account = {
    current: () => requests.get<User>('/account'),
    login: (user: UserFormValues) => requests.post<User>('/account/login', user),
    register: (user: UserFormValues) => requests.post<User>('account/register', user)
}

const Profiles = {
    get: (userId: string) => requests.get<Profile>(`/userprofiles/${userId}`),
    uploadPhoto: (file: any) => {
        let formData = new FormData();
        formData.append('File', file);
        return axios.post<Photo>('photos', formData, {
            headers: { 'Content-Type': 'multipart/form-data' }
        })
    },
    setMainPhoto: (id: string) => axios.post(`/photos/${id}/setMain`, {}),
    deletePhoto: (id: string) => axios.delete(`/photos/${id}`),
    updateProfile: (profile: Partial<Profile>) => requests.put(`/userprofiles`, profile),
    updateFollowing: (username: string) => requests.post(`/follow/${username}`, {}),
    listFollowings: (username: string, predicate: string) => requests
        .get<Profile[]>(`/follow/${username}?predicate=${predicate}`),
    listActivities: (username: string, predicate: string) =>
        requests.get<UserActivity[]>(`/profiles/${username}/activities?predicate=${predicate}`)
}

const apiClient = {
    Activities,
    Account,
    Profiles
}

export default apiClient;