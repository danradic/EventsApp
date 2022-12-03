import React, { useState } from "react";
import { Grid, List } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";

interface Props {
    activities: Activity[];
}

export default function ActivityDashboard({activities} : Props) {

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
        console.log('handleFormOpen, id=' + id);
        id ? handleSelectActivity(id) : handleCancelSelectActivity();
        setEditMode(true);
    }

    function handleFormClose() {
        setEditMode(false);
    } 

    return (
        <Grid>
            <Grid.Column width='10'>
                <ActivityList 
                    activities={activities}
                    selectActivity={handleSelectActivity}
                    openForm={handleFormOpen} />
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
                    closeForm={handleFormClose} />}
            </Grid.Column>
        </Grid>
    )
}