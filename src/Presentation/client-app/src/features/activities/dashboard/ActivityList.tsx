import { observer } from "mobx-react-lite";
import { Fragment } from "react";
import { NavLink } from "react-router-dom";
import { Button, Container, Header, Item, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/storeContext";
import ActivityListItem from "./ActivityListItem";

export default observer(function ActivityList() {
    const { activityStore } = useStore();
    const { groupedActivities } = activityStore;

    return (
        <>
            <Container className='activities-header-ctn' style={{ overflow: 'hidden' }}>
                <Header floated='left' as='h1'>Activities</Header>
                <Button as={NavLink} to='/createActivity' floated='right' className="ui green button" content="Create Activity" />
            </Container>
            {groupedActivities.map(([group, activities]) => (
                <Container key={group} className='activity-item-ctn'>
                    <Header sub color='teal'>
                        {group}
                    </Header>
                    {activities.map(activity => (
                        <ActivityListItem key={activity.id} activity={activity} />
                    ))}
                </Container>
            ))}
        </>
    )
})