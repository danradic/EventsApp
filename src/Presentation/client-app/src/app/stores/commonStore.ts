import { makeAutoObservable } from "mobx";
import { ProblemDetails } from "../models/problemDetails";

export default class CommonStore {
    problemDetails: ProblemDetails | null = null;
    token: string | null = null;
    appLoaded = false;

    constructor() {
        makeAutoObservable(this);
    }

    setServerError(problemDetails: ProblemDetails) {
        this.problemDetails = problemDetails;
    }
    
    setToken = (token: string | null) => {
        if(token) localStorage.setItem("jwt", token);
        this.token = token;
    }

    setAppLoaded = () => {
        this.appLoaded = true;
    }
}