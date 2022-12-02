import React from "react";
import { Button, Container, Menu } from "semantic-ui-react";

export default function NavBar(){
    return (
        <Menu inverted fixed="top">
            <Container>
                <Menu.Item header>
                    <i className="react icon logo"></i>
                    EventsApp
                </Menu.Item>
                <Menu.Item name="Activities"/>
                <Menu.Item>
                    <Button className="ui inverted blue button" content="Create Activity" />
                </Menu.Item>
            </Container>
        </Menu>
    )
}