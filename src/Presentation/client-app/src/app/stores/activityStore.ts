import { makeAutoObservable, runInAction } from "mobx";
import apiClient from "../api/apiClient";
import { Activity, ActivityFormValues } from "../models/activity";
import { v4 as uuidv4 } from 'uuid';
import { format } from "date-fns";
import { Profile } from "../models/profile";
import { store } from "./storeContext";

export default class ActivityStore {
    activityRegistry = new Map<string, Activity>();
    selectedActivity: Activity | undefined = undefined;
    editMode = false;
    loading = false;
    loadingInitial = false;

    constructor() {
        makeAutoObservable(this)
    }

    get activitiesByDate() {
        return Array.from(this.activityRegistry.values())
            .sort((a, b) => a.date!.getTime() - b.date!.getTime());
    }

    get groupedActivities() {
        return Object.entries(
            this.activitiesByDate.reduce((activities, activity) => {
                const date = activity.date!.toISOString().split('T')[0];
                activities[date] = activities[date] ? [...activities[date], activity] : [activity];
                // debugger;
                return activities;
            }, {} as { [key: string]: Activity[] })
        )
    }

    loadActivites = async () => {
        this.setLoadingInitial(true);
        try {
            let activities = await apiClient.Activities.getActivities();
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
                activity = await apiClient.Activities.getActivity(id);
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
        const user = store.userStore.user;
        if (user) {
            activity.isGoing = activity.attendees!.some(
                a => a.userName === user.userName
            );
            activity.isHost = activity.hostUsername === user.userName;
            activity.host = activity.attendees?.find(x => x.userName === activity.hostUsername);
        }
        activity.date = new Date(activity.date!);
        this.activityRegistry.set(activity.id, activity);
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    createActivity = async (activity: ActivityFormValues) => {
        const user = store.userStore!.user;
        const profile = new Profile(user!);
        try {
            await apiClient.Activities.addActivity(activity);
            const newActivity = new Activity(activity);
            newActivity.hostUsername = user!.userName;
            newActivity.attendees = [profile];
            this.setActivity(newActivity);
            runInAction(() => this.selectedActivity = newActivity);
        } catch (error) {
            console.log(error);
        }
    }

    updateActivity = async (activity: ActivityFormValues) => {
        try {
            await apiClient.Activities.updateActivity(activity);
            runInAction(() => {
                if (activity.id) {
                    let updatedActivity = { ...this.getActivity(activity.id), ...activity };
                    this.activityRegistry.set(activity.id, updatedActivity as Activity);
                    this.selectedActivity = updatedActivity as Activity;
                }
            })
        } catch (error) {
            console.log(error);
        }
    }

    deleteActivity = async (id: string) => {
        this.loading = true
        try {
            await apiClient.Activities.deleteActivity(id);
            runInAction(() => {
                this.activityRegistry.delete(id);
                this.loading = false;

            });
        } catch (error) {
            console.log(error);
            this.loading = false;
        }
    }

    updateAttendeance = async () => {
        const user = store.userStore.user;
        store.userStore.setImageFromProfile();
        this.loading = true;
        try {
            await apiClient.Activities.attend(this.selectedActivity!.id);
            runInAction(() => {
                if (this.selectedActivity?.isGoing) {
                    this.selectedActivity.attendees = this.selectedActivity.attendees?.filter(a => a.userName !== user?.userName);
                    this.selectedActivity.isGoing = false;
                } else {
                    const attendee = new Profile(user!);
                    this.selectedActivity?.attendees?.push(attendee);
                    this.selectedActivity!.isGoing = true;
                }
                this.activityRegistry.set(this.selectedActivity!.id, this.selectedActivity!);
            })
        } catch (error) {
            console.log(error);
        } finally {
            runInAction(() => this.loading = false);
        }
    }

    cancelActivityToggle = async () => {
        this.loading = true;
        try {
            await apiClient.Activities.attend(this.selectedActivity!.id);
            runInAction(() => {
                this.selectedActivity!.isCancelled = !this.selectedActivity!.isCancelled;
                this.activityRegistry.set(this.selectedActivity!.id, this.selectedActivity!);
            })
        } catch (error) {
            console.log(error);
        } finally {
            runInAction(() => this.loading = false);
        }
    }

    clearSelectedActivity = () => {
        this.selectedActivity = undefined;
    }

    updateAttendeeFollowing = (userName: string) => {
        this.activityRegistry.forEach(activity => {
            activity.attendees.forEach((attendee: Profile) => {
                if (attendee.userName === userName) {
                    attendee.following ? attendee.followersCount-- : attendee.followersCount++;
                    attendee.following = !attendee.following;
                }
            })
        })
    }
}