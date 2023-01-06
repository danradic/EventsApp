import { Link } from "react-router-dom";
import { Container, Header, Segment, Button } from "semantic-ui-react";
import { useStore } from "../../app/stores/storeContext";
import LoginForm from "../users/LoginForm";
import RegisterForm from "../users/RegisterForm";

export default function HomePage() {
    const { userStore, modalStore } = useStore();
    return (
        <Segment inverted textAlign='center' vertical className="masthead">
            <Container text>
                <Header as='h2' inverted>
                    Welcome to
                    <i className="react icon logo home"></i>
                    EventsApp
                </Header>
                {userStore.isLoggedIn ? (
                    <>
                        <Header as='h3' inverted content={`Welcome back ${userStore.user?.displayName}!`} />
                        <Button as={Link} to='/activities' size='huge' inverted>
                            Go to activities
                        </Button>
                    </>
                ) : (
                    <>
                        <Button onClick={() => modalStore.openModal(<LoginForm />)} inverted size="huge" content='Login' />
                        <Button onClick={() => modalStore.openModal(<RegisterForm />)} inverted size="huge" content='Register' />
                    </>
                )}
            </Container>
        </Segment>
    )
}