import { Link } from "react-router-dom";
import { Container, Header, Segment, Image, Button } from "semantic-ui-react";

export default function HomePage() {
    return (
        <Segment inverted textAlign='center' vertical className="masthead">
            <Container text>
                <Header as='h2' inverted content='Welcome to EventsApp'>
                    Welcome to
                    <i className="react icon logo home"></i>
                    EventsApp
                </Header>
                <Button as={Link} to='/activities' inverted size="huge" content='Go to Events' />
            </Container>
        </Segment>
    )
}