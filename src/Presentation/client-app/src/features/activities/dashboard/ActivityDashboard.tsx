import axios from "axios";
import React, { useEffect, useState } from "react";
import { Grid } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";
import { v4 as uuidv4 } from 'uuid';

export default function ActivityDashboard() {
    const [activities, setActivities] = useState<Activity[]>([]);

    useEffect(() => {
      axios.get<Activity[]>("http://localhost:5000/api/activities").then(response => {
        setActivities(response.data);
      })
    }, []);

    const [selectedActivity, setSelectedActivity] = useState<Activity | undefined>(undefined);
    const [editMode, setEditMode] = useState(false);

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
        activity.id ? setActivities([...activities.filter(a => a.id !== activity.id), activity]) 
        : setActivities([...activities, {...activity, id: uuidv4()}]);
        setEditMode(false);
        setSelectedActivity(activity);
    }

    function handleDeleteActivity(id: string) {
        setActivities([...activities.filter(a => a.id !== id)]);
    }

    return (
        <Grid>
            <Grid.Column width='10'>
                <ActivityList
                    activities={activities}
                    selectActivity={handleSelectActivity}
                    openForm={() => handleFormOpen(undefined)} 
                    deleteActivity={handleDeleteActivity} />
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
                    createOrEdit={handleCreateOrEditActivity} />}
            </Grid.Column>
        </Grid>
    )
}