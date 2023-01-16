import { observer } from "mobx-react-lite";
import { Fragment } from "react";
import { NavLink } from "react-router-dom";
import { Button, Container, Header, Item, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/storeContext";
import ActivityListItem from "./ActivityListItem";

export default observer(function ActivityList() { 
    const {activityStore} = useStore();
    const {groupedActivities} = activityStore;

    return (
        <>
        <Container style={{overflow: 'hidden'}}>
            <Header floated='left' as='h1'>Activities</Header>
            <Button as={NavLink} to='/createActivity' floated='right' className="ui green button" content="Create Activity" />
        </Container>
        {groupedActivities.map(([group, activities]) => (
            <Fragment key={group}>
                <Header sub color='teal'>
                    {group}
                </Header>
                <Segment style={{marginTop: '0'}}>
                    <Item.Group divided>
                        {activities.map(activity => (
                            <ActivityListItem key={activity.id} activity={activity} />
                        ))}
                    </Item.Group>
                </Segment> 
            </Fragment>
        ))}
        </>
    )
})