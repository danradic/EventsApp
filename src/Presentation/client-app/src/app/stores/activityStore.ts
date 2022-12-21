import { makeAutoObservable, runInAction } from "mobx";
import activityApiClient from "../api/activityApiClient";
import { Activity } from "../models/activity";
import { v4 as uuidv4 } from 'uuid';
import { format } from "date-fns";

export default class ActivityStore {
    activityRegistry = new Map<string, Activity>();
    selectedActivity: Activity | undefined = undefined;
    editMode = false;
    loading = false;
    loadingInitial = false;

    constructor(){
        makeAutoObservable(this)
    }

    get activitiesByDate() {
        return Array.from(this.activityRegistry.values())
            .sort((a,b ) => a.date!.getTime() - b.date!.getTime());
    }

    get groupedActivities() {
        return Object.entries(
            this.activitiesByDate.reduce((activities, activity) => {
                const date = format(activity.date!, 'dd MMM yyyy');
                activities[date] = activities[date] ? [...activities[date], activity] : [activity];
                return activities
            }, {} as {[key: string]: Activity[]})
        )
    }

    loadActivites = async () => {
        this.setLoadingInitial(true);
        try {
            let activities = await activityApiClient.getActivities();
            activities.forEach(activity => {
                this.setActivity(activity);
            });
            this.setLoadingInitial(false);
        } catch (error) {
            console.log(error);
            this.setLoadingInitial(false);
        }
    }

    loadActivity = async (id: string) => {
        let activity = this.getActivity(id)
        if (!activity) {
            this.setLoadingInitial(true);
            try {
                activity = await activityApiClient.getActivity(id);
                this.setActivity(activity);
                this.setLoadingInitial(false);
                runInAction(() => this.selectedActivity = activity);
                return activity;
            } catch (error) {
                console.log(error);
                this.setLoadingInitial(false);
            }
        } else {
            runInAction(() => this.selectedActivity = activity);
            return activity;
        }
    }

    private getActivity = (id: string) => {
        return this.activityRegistry.get(id);
    }

    private setActivity = (activity: Activity) => {
        activity.date = new Date(activity.date!);
        this.activityRegistry.set(activity.id, activity);
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
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

            });
        } catch (error) {
            console.log(error);
            this.loading = false;
        }
    }
}