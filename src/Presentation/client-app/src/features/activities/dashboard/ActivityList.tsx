import { observer } from "mobx-react-lite";
import { SyntheticEvent, useState } from "react";
import { Button, Container, Header, Item, Label, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/storeContext";

interface Props {
    deleteActivity: (id: string) => void, 
    submitting: (boolean)
}

export default observer(function ActivityList({deleteActivity, submitting} : Props) { 
    const {activityStore} = useStore();
    const {openForm, selectActivity, activities} = activityStore;

    const [target, setTarget] = useState('');

    function handleActivityDelete(e:SyntheticEvent<HTMLButtonElement>, id: string) {
        setTarget(e.currentTarget.id);
        deleteActivity(id);
    }

    return (
        <>
        <Container style={{overflow: 'hidden'}}>
            <Header floated='left' as='h1'>Activities</Header>
            <Button onClick={() => openForm()} floated='right' className="ui green button" content="Create Activity" />
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
                                <Button 
                                    id={activity.id}
                                    loading={submitting && target === activity.id} 
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