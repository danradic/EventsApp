import React from "react";
import { Container, Menu } from "semantic-ui-react";

export default function NavBar(){
    return (
        <Menu inverted fixed="top">
            <Container>
                <Menu.Item header>
                    <i className="react icon logo"></i>
                    EventsApp
                </Menu.Item>
                <Menu.Item name="Activities"/>
            </Container>
        </Menu>
    )
}