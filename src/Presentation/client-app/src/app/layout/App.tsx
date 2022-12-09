import { Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';
import { useStore } from '../stores/storeContext';

function App() {
  const {activityStore} = useStore();
  return (
    <>
      <NavBar />
      <Container style={{marginTop: "6em"}}>
        <h2>{activityStore.title}</h2>
        <ActivityDashboard />
      </Container>
    </>
  );
}

export default App;
