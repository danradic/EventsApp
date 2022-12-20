import { makeAutoObservable } from "mobx";
import { ProblemDetails } from "../models/problemDetails";

export default class CommonStore {
    problemDetails: ProblemDetails | null = null;

    constructor() {
        makeAutoObservable(this);
    }

    setServerError(problemDetails: ProblemDetails) {
        this.problemDetails = problemDetails;
    }
}