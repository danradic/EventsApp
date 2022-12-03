import React from "react";
import { Button, Card, Icon, Image } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";

interface Props {
    activity: Activity | undefined,
    cancelSelectActivity: () => void,
    openEditForm: (id?: string) => void
}

export default function ActivityDetails({activity, cancelSelectActivity, openEditForm}: Props) {
    return (
        <Card fluid>
            <Image src={`/assets/categoryImages/${activity?.category}.jpg`} />
            <Card.Content>
            <Card.Header>{activity?.title}</Card.Header>
            <Card.Meta>
                <span>{activity?.date.toString()}</span>
            </Card.Meta>
            <Card.Description>
                {activity?.description}
            </Card.Description>
            </Card.Content>
            <Card.Content extra>
                <Button.Group widths='2'>
                    <Button onClick={() => openEditForm(activity?.id)} basic color="blue" content='Edit' />
                    <Button onClick={cancelSelectActivity} basic color="grey" content='Cancel' />
                </Button.Group>
            </Card.Content>
        </Card>
    )
}