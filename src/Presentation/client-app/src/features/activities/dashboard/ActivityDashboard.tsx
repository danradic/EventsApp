import { useEffect, useState } from "react";
import { Grid } from "semantic-ui-react";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/storeContext";
import { observer } from "mobx-react-lite";

export default observer(function ActivityDashboard() {
    const {activityStore} = useStore();
    const {loadActivites, loadingInitial, selectedActivity, editMode} = activityStore;

    useEffect(() => {
        loadActivites();
    }, [activityStore]);

    if (loadingInitial) return <LoadingComponent content='Loading...' />

    return (
        <Grid>
            <Grid.Column width='10'>
                <ActivityList />
            </Grid.Column>
            <Grid.Column width='6'>
                {selectedActivity && 
                <ActivityDetails />}
                {editMode && 
                <ActivityForm />}
            </Grid.Column>
        </Grid>
    )
})