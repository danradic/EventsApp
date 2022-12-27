import { Link } from "react-router-dom";
import { Container, Header, Segment, Button } from "semantic-ui-react";

export default function HomePage() {
    return (
        <Segment inverted textAlign='center' vertical className="masthead">
            <Container text>
                <Header as='h2' inverted>
                    Welcome to
                    <i className="react icon logo home"></i>
                    EventsApp
                </Header>
                <Button as={Link} to='/login' inverted size="huge" content='Login' />
            </Container>
        </Segment>
    )
}