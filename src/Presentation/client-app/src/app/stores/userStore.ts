import { makeAutoObservable, runInAction } from "mobx";
import apiClient from "../api/apiClient";
import { User, UserFormValues } from "../models/user";
import { router } from "../router/Routes";
import { store } from "./storeContext";

export default class UserStore {
    user: User | null = null;

    constructor() { 
        makeAutoObservable(this);
    }

    get isLoggedIn() {
        return !!this.user;
    }

    login = async (creds: UserFormValues) => {
        try {
            const user = await apiClient.Account.login(creds) 
            store.commonStore.setToken(user.token);
            runInAction(()=> this.user = user);
            router.navigate('/activities');
        } catch (error) {
            throw error;
        }
    }

    logout = () => {
        store.commonStore.setToken(null);
        localStorage.removeItem('jwt');
        this.user = null;
        router.navigate('/');
    }
}