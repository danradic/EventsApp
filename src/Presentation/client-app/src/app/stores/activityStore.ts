import { action, makeAutoObservable, runInAction } from "mobx";
import activityApiClient from "../api/activityApiClient";
import { Activity } from "../models/activity";

export default class ActivityStore {
    activities: Activity[] = [];
    selectedActivity: Activity | null = null;
    editMode = false;
    loading = false;
    loadingInitial = false;

    constructor(){
        makeAutoObservable(this)
    }

    loadActivites = async () => {
        this.setLoadingInitial(true);
        try {
            let activities = await activityApiClient.getActivities();
            runInAction(() => {
                activities.forEach(activity => {
                    activity.date = activity.date.toString().split('T')[0];
                    this.activities.push(activity);
                });
                this.setLoadingInitial(false);
            });
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.setLoadingInitial(false);
            });
        }
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }
}