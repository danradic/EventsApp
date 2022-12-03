import { Console } from "console";
import React, { ChangeEvent, useState } from "react";
import { Button, Form, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";

interface Props {
    activity: Activity | undefined,
    closeForm: () => void
}

export default function ActivityForm({activity: selectedActivity, closeForm}: Props) {

    const initialState = selectedActivity ?? {
        id: '',
        title: '',
        category: '',
        description: '',
        date: '',
        city: '',
        venue: ''
    }

    const [activity1, setActivity] = useState(initialState);

    function handleSubmit() {
        console.log(activity1);
    }

    function handleInputChange(event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) {
        const {name, value} = event.target;
        setActivity({...activity1, [name]: value})
    }

    return (
        <Segment clearing>
            <Form onSubmit={handleSubmit} autoComplete='off'>
                <Form.Input placeholder='Title' value={activity1?.title} name='title' onChange={handleInputChange} />
                <Form.TextArea placeholder='Description' value={activity1?.description} name='title' onChange={handleInputChange} />
                <Form.Input placeholder='Category' value={activity1?.category} name='title' onChange={handleInputChange} />
                <Form.Input placeholder='Date' value={activity1?.date.toString()} name='title' onChange={handleInputChange} />
                <Form.Input placeholder='City' value={activity1?.city} name='title' onChange={handleInputChange} />
                <Form.Input placeholder='Venue' value={activity1?.venue} name='title' onChange={handleInputChange} />
                <Button floated='right' positive type="submit" content='Submit' name='title' onChange={handleInputChange} />
                <Button onClick={closeForm} floated='right' type='button' content='Cancel' name='title' onChange={handleInputChange} />
            </Form>
        </Segment>
    )
}