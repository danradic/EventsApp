import { observer } from "mobx-react-lite";
import React from "react";
import { Link, NavLink } from "react-router-dom";
import { Container, Menu, Image, Dropdown } from "semantic-ui-react";
import { useStore } from "../stores/storeContext";

export default observer(function NavBar() {
    const { userStore } = useStore();
    return (
        <>
            <Menu inverted fixed="top">
                <Container>
                    <Menu.Item as={NavLink} to='/' header>
                        <i className="react icon logo nav"></i>
                        EventsApp
                    </Menu.Item>
                    <Menu.Item as={NavLink} to='/activities' name="Events" />
                    {userStore.isLoggedIn ? (
                        <>
                            <Menu.Item position='right'>
                                <Image avatar spaced='right' src={userStore.user?.image || '/assets/user.png'} />
                                <Dropdown pointing='top left' text={userStore.user?.displayName}>
                                    <Dropdown.Menu>
                                        <Dropdown.Item as={Link} to={`/profiles/${userStore.user?.userName}`} text='My Profile' icon='user' />
                                        <Dropdown.Item onClick={userStore.logout} text='Logout' icon='power' />
                                    </Dropdown.Menu>
                                </Dropdown>
                            </Menu.Item>
                        </>
                    ) : (null)}
                </Container>
            </Menu>
        </>
    )
})