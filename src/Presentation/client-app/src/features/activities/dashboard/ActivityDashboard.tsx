import { useEffect, useState } from "react";
import { Grid } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";
import activityApiClient from "../../../app/api/activityApiClient";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/storeContext";
import { observer } from "mobx-react-lite";

export default observer(function ActivityDashboard() {
    const {activityStore} = useStore();
    const {selectActivity} = activityStore;

    const [activities, setActivities] = useState<Activity[]>([]);
    const [submitting, setSubmitting] = useState(false);

    useEffect(() => {
        activityStore.loadActivites();
    }, [activityStore]);

    function handleDeleteActivity(id: string) {
        setSubmitting(true);
        activityApiClient.deleteActivity(id).then(() => {
            setActivities([...activities.filter(a => a.id !== id)]);
            setSubmitting(false);
        });
    }

    if (activityStore.loadingInitial) return <LoadingComponent content='Loading...' />

    return (
        <Grid>
            <Grid.Column width='10'>
                <ActivityList
                    deleteActivity={handleDeleteActivity}
                    submitting={submitting} />
            </Grid.Column>
            <Grid.Column width='6'>
                {activityStore.selectedActivity && 
                <ActivityDetails />}
                {activityStore.editMode && 
                <ActivityForm />}
            </Grid.Column>
        </Grid>
    )
})