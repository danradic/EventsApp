import { makeAutoObservable, reaction } from "mobx";
import { ProblemDetails } from "../models/problemDetails";

export default class CommonStore {
    problemDetails: ProblemDetails | null = null;
    token: string | null = localStorage.getItem('jwt');
    tokenExpireDate: string | null = localStorage.getItem('jwtExpireDate');
    appLoaded = false;

    constructor() {
        makeAutoObservable(this);

        reaction(
            () => this.token,
            token => {
                if (token) {
                    localStorage.setItem('jwt', token)
                } else {
                    localStorage.removeItem('jwt')
                }
            }
        )
        reaction(
            () => this.tokenExpireDate,
            tokenExpireDate => {
                if (tokenExpireDate) {
                    localStorage.setItem('jwtExpireDate', tokenExpireDate)
                } else {
                    localStorage.removeItem('jwtExpireDate')
                }
            }
        )
    }

    setServerError(problemDetails: ProblemDetails) {
        this.problemDetails = problemDetails;
    }

    setToken = (token: string | null) => {
        this.token = token;
    }

    setTokenExpires = (tokenExpireDate: string | null) => {
        this.tokenExpireDate = tokenExpireDate;
    }

    isTokenExpired = (tokenExpires: string | null) => {
        const jwtExpireDate = new Date(tokenExpires!);
        const nowDate = new Date();
        if(jwtExpireDate < nowDate) return true;
        return false;
    }

    setAppLoaded = () => {
        this.appLoaded = true;
    }
}