import { Button, Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';
import { useStore } from '../stores/storeContext';
import { observer } from 'mobx-react-lite';

function App() {
  const {activityStore} = useStore();
  return (
    <>
      <NavBar />
      <Container style={{marginTop: "6em"}}>
        <h2>{activityStore.title}</h2>
        <Button content='Add exclamation' positive onClick={activityStore.setTitle}></Button>
        <ActivityDashboard />
      </Container>
    </>
  );
}

export default observer(App);
