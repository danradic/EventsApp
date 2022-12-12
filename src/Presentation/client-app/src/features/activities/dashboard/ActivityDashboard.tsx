import { useEffect } from "react";
import { Grid } from "semantic-ui-react";
import ActivityList from "./ActivityList";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/storeContext";
import { observer } from "mobx-react-lite";

export default observer(function ActivityDashboard() {
    const {activityStore} = useStore();
    const { loadingInitial } = activityStore;

    useEffect(() => {
        activityStore.loadActivites();
    }, [activityStore]);

    if (loadingInitial) return <LoadingComponent content='Loading...' />

    return (
        <Grid>
            <Grid.Column width='10'>
                <ActivityList />
            </Grid.Column>
            <Grid.Column width='6'>
                <h2>Activity Filters</h2>
            </Grid.Column>
        </Grid>
    )
})