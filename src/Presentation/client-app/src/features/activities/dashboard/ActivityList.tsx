import { Button, Container, Header, Item, Label, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";

interface Props {
    activities: Activity[],
    selectActivity: (id: string) => void,
    openForm: () => void, 
    deleteActivity: (id: string) => void
}

export default function ActivityList({activities, selectActivity, openForm, deleteActivity} : Props) { 
    return (
        <>
        <Container style={{overflow: 'hidden'}}>
            <Header floated='left' as='h1'>Activities</Header>
            <Button onClick={openForm} floated='right' className="ui green button" content="Create Activity" />
        </Container>
        {activities ? 
        <Segment style={{marginTop: '0'}}>
            <Item.Group divided>
                {activities.map(activity => (
                    <Item key={activity.id}>
                        <Item.Content>
                            <Item.Header as='a'> {activity.title}</Item.Header>
                            <Item.Meta>{activity.date.toString()}</Item.Meta>
                            <Item.Description>
                                <div>{activity.description}</div>
                                <div>{activity.city}, {activity.venue}</div>
                            </Item.Description>
                            <Item.Extra>
                                <Button onClick={() => selectActivity(activity.id)} floated='right' content='View' color='blue' />
                                <Button onClick={() => deleteActivity(activity.id)} floated='right' content='DELETE' color='red' />
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
}