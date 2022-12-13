import { useEffect } from "react";
import { Container, Grid } from "semantic-ui-react";
import ActivityList from "./ActivityList";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/storeContext";
import { observer } from "mobx-react-lite";
import ActivityFilters from "./ActivityFilters";

export default observer(function ActivityDashboard() {
    const {activityStore} = useStore();
    const { loadingInitial, activityRegistry, loadActivites } = activityStore;

    useEffect(() => {
        if (activityRegistry.size <= 1) loadActivites();
    }, [activityRegistry.size, loadActivites]);

    if (loadingInitial) return <LoadingComponent content='Loading...' />

    return (
        <Container>
            <Grid>
                <Grid.Column width='10'>
                    <ActivityList />
                </Grid.Column>
                <Grid.Column width='6'>
                <ActivityFilters />
                </Grid.Column>
            </Grid>
        </Container>

    )
})