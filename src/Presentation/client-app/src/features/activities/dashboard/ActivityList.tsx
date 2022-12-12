import { observer } from "mobx-react-lite";
import { SyntheticEvent, useState } from "react";
import { Link, NavLink } from "react-router-dom";
import { Button, Container, Header, Item, Label, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/storeContext";

export default observer(function ActivityList() { 
    const {activityStore} = useStore();
    const {activitiesByDate, deleteActivity, loading} = activityStore;

    const [target, setTarget] = useState('');

    function handleActivityDelete(e:SyntheticEvent<HTMLButtonElement>, id: string) {
        setTarget(e.currentTarget.id);
        deleteActivity(id);
    }

    return (
        <>
        <Container style={{overflow: 'hidden'}}>
            <Header floated='left' as='h1'>Activities</Header>
            <Button as={NavLink} to='/createActivity' floated='right' className="ui green button" content="Create Activity" />
        </Container>
        {activitiesByDate ? 
        <Segment style={{marginTop: '0'}}>
            <Item.Group divided>
                {activitiesByDate.map(activity => (
                    <Item key={activity.id}>
                        <Item.Content>
                            <Item.Header as='a'> {activity.title}</Item.Header>
                            <Item.Meta>{activity.date.toString()}</Item.Meta>
                            <Item.Description>
                                <div>{activity.description}</div>
                                <div>{activity.city}, {activity.venue}</div>
                            </Item.Description>
                            <Item.Extra>
                                <Button as={Link} to={`/activities/${activity.id}`} floated='right' content='View' color='blue' />
                                <Button 
                                    id={activity.id}
                                    loading={loading && target === activity.id} 
                                    onClick={(e) => handleActivityDelete(e, activity.id)} 
                                    floated='right' 
                                    content='DELETE' 
                                    color='red' />
                                <Label basic content={activity.category} />
                            </Item.Extra>
                        </Item.Content>
                    </Item>
                ))}
            </Item.Group>
        </Segment> 
        : null }
        </>
    )
})