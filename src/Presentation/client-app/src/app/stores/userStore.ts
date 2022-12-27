import { makeAutoObservable } from "mobx";
import apiClient from "../api/apiClient";
import { User, UserFormValues } from "../models/user";

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
            console.log(user);
        } catch (error) {
            throw error;
        }
    }
}