import { Button, Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';

function App() {
  return (
    <>
      <NavBar />
      <Container style={{marginTop: "6em"}}>
        <ActivityDashboard />
      </Container>
    </>
  );
}

export default App;
