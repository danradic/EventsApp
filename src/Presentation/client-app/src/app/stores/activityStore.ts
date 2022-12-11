import { makeAutoObservable, runInAction } from "mobx";
import activityApiClient from "../api/activityApiClient";
import { Activity } from "../models/activity";
import { v4 as uuidv4 } from 'uuid';

export default class ActivityStore {
    activityRegistry = new Map<string, Activity>();
    selectedActivity: Activity | undefined = undefined;
    editMode = false;
    loading = false;
    loadingInitial = true;

    constructor(){
        makeAutoObservable(this)
    }

    get activitiesByDate() {
        return Array.from(this.activityRegistry.values())
            .sort((a,b ) => Date.parse(a.date.toString()) - Date.parse(b.date.toString()));
    }

    loadActivites = async () => {
        try {
            let activities = await activityApiClient.getActivities();
            activities.forEach(activity => {
                activity.date = activity.date.toString().split('T')[0];
                this.activityRegistry.set(activity.id, activity);
            });
            this.setLoadingInitial(false);
        } catch (error) {
            console.log(error);
            this.setLoadingInitial(false);
        }
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    selectActivity = (id: string) => {
        this.selectedActivity = this.activityRegistry.get(id);
    }

    cancelSelectedActivity = () => {
        this.selectedActivity = undefined;
        this.editMode = false;
    }

    openForm = (id?: string) => {
        id ? this.selectActivity(id) : this.cancelSelectedActivity();
        this.editMode = true;
    }

    closeForm = () => {
        this.editMode = false;
    }

    viewActivityDetails = (id: string) => {
        this.selectActivity(id);
        this.closeForm();
    }

    createActivity = async (activity: Activity) => {
        this.loading = true;
        activity.id = uuidv4();
        try {
            await activityApiClient.addActivity(activity);
            runInAction(() => {
                this.activityRegistry.set(activity.id, activity);
                this.selectedActivity = activity;
                this.editMode = false;
                this.loading = false;
            });
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            });
        }
    }

    updateActivity = async (activity: Activity) => {
        this.loading = true;
        try {
            await activityApiClient.updateActivity(activity);
            runInAction(() => {
                this.activityRegistry.set(activity.id, activity);
                this.selectedActivity = activity;
                this.editMode = false;
                this.loading = false;
            });
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            });
        }
    }

    deleteActivity = async (id: string) => {
        this.loading = true
        try {
            await activityApiClient.deleteActivity(id);
            runInAction(() => {
                this.activityRegistry.delete(id);
                this.loading = false;
                this.cancelSelectedActivity();

            });
        } catch (error) {
            console.log(error);
            this.loading = false;
            this.cancelSelectedActivity();
        }
    }
}