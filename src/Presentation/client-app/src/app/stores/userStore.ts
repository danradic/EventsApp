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
            store.commonStore.setTokenExpires(user.tokenExpires);
            runInAction(()=> this.user = user);
            router.navigate('/activities');
            store.modalStore.closeModal();
        } catch (error) {
            throw error;
        }
    }

    register = async (creds: UserFormValues) => {
        try {
            const user = await apiClient.Account.register(creds) 
            store.commonStore.setToken(user.token);
            runInAction(()=> this.user = user);
            router.navigate('/activities');
            store.modalStore.closeModal();
        } catch (error) {
            throw error;
        }
    }

    logout = () => {
        store.commonStore.setToken(null);
        store.commonStore.setTokenExpires(null);
        this.user = null;
        router.navigate('/');
    }

    getUser = async () => {
        try {
            const user = await apiClient.Account.current();
            runInAction( () => this.user = user );
        } catch (error) {
            console.log(error);
        }
    }

    setImage = (image: string) => {
        if (this.user) this.user.image = image;
    }

    setUserPhoto = (url: string) => {
        if (this.user) this.user.image = url;
    }

    setDisplayName = (name: string) => {
        if (this.user) this.user.displayName = name;
    }
}