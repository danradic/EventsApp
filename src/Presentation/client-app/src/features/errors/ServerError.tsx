import { observer } from "mobx-react-lite";
import { Container, Header, Segment } from "semantic-ui-react";
import { useStore } from "../../app/stores/storeContext";

export default observer(function ServerError() {
    const {commonStore} = useStore();

    return (
        <Container>
            <Header as='h1' content='Server Error' />
            <Header sub as='h5' color='red' content={commonStore.problemDetails?.Detail} />
            {commonStore.problemDetails?.Errors && commonStore.problemDetails?.Errors.length ? 
                <Segment>
                    <Header as='h4' content='Stack trace' color='teal' />
                    <code style={{marginTop: '10px'}}>{commonStore.problemDetails.Errors[0].ErrorMessage}</code>
                </Segment>
            : null }
        </Container>
    )
})