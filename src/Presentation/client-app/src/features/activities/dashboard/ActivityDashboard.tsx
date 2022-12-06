import { useEffect, useState } from "react";
import { Grid } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";
import { v4 as uuidv4 } from 'uuid';
import activityApiClient from "../../../app/api/activityApiClient";
import LoadingComponent from "../../../app/layout/LoadingComponent";

export default function ActivityDashboard() {
    const [activities, setActivities] = useState<Activity[]>([]);
    const [selectedActivity, setSelectedActivity] = useState<Activity | undefined>(undefined);
    const [editMode, setEditMode] = useState(false);
    const [loading, setLoading] = useState(true);
    const [submitting, setSubmitting] = useState(false);

    useEffect(() => {
        activityApiClient.getActivities().then(response => {
        let activities: Activity[] = [];
        response.forEach(activity => {
            activity.date = activity.date.toString().split('T')[0];
            activities.push(activity);
        });
        setActivities(activities);
        setLoading(false);
      })
    }, []);

    function handleSelectActivity(id: string) {
        setSelectedActivity(activities.find(a => a.id === id));
        setEditMode(false);
    }

    function handleCancelSelectActivity() {
        setSelectedActivity(undefined);
        setEditMode(false);
    }

    function handleFormOpen(id?: string) {
        id ? handleSelectActivity(id) : handleCancelSelectActivity();
        setEditMode(true);
    }

    function handleFormClose() {
        setEditMode(false);
    } 

    function handleCreateOrEditActivity(activity: Activity) {
        setSubmitting(true);
        if (activity.id) {
            activityApiClient.updateActivity(activity).then(() => {
                setActivities([...activities.filter(a => a.id !== activity.id), activity])
                setSelectedActivity(activity);
                setEditMode(false);
                setSubmitting(false); 
        })
        } else {
            activity.id = uuidv4();
            activityApiClient.addActivity(activity).then(() => {
                setActivities([...activities, activity])
                setSelectedActivity(activity);
                setEditMode(false);
                setSubmitting(false); 
            });
        }
    }

    function handleDeleteActivity(id: string) {
        setSubmitting(true);
        activityApiClient.deleteActivity(id).then(() => {
            setActivities([...activities.filter(a => a.id !== id)]);
            setSubmitting(false);
        });
    }

    if (loading) return <LoadingComponent content='Loading...' />

    return (
        <Grid>
            <Grid.Column width='10'>
                <ActivityList
                    activities={activities}
                    selectActivity={handleSelectActivity}
                    openForm={() => handleFormOpen(undefined)} 
                    deleteActivity={handleDeleteActivity}
                    submitting={submitting} />
            </Grid.Column>
            <Grid.Column width='6'>
                {selectedActivity && 
                <ActivityDetails 
                    activity={selectedActivity}
                    cancelSelectActivity={handleCancelSelectActivity}
                    openEditForm={() => handleFormOpen(selectedActivity.id)}/>}
                {editMode && 
                <ActivityForm 
                    activity={selectedActivity}
                    closeForm={handleFormClose}
                    createOrEdit={handleCreateOrEditActivity}
                    submitting={submitting} />}
            </Grid.Column>
        </Grid>
    )
}