import React from "react";
import { NavLink } from "react-router-dom";
import { Container, Menu } from "semantic-ui-react";

export default function NavBar() {
    return (
        <>
            <Menu inverted fixed="top">
                <Container>
                    <Menu.Item as={NavLink} to='/' header>
                        <i className="react icon logo nav"></i>
                        EventsApp
                    </Menu.Item>
                    <Menu.Item as={NavLink} to='/activities' name="Events" />
                </Container>
            </Menu>
        </>
    )
}