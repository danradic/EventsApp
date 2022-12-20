import NavBar from './NavBar';
import { Outlet, useLocation } from 'react-router-dom';
import { ToastContainer } from 'react-toastify';
import { Container } from 'semantic-ui-react';
import HomePage from '../../features/home/HomePage';

function App() {
  const { pathname } = useLocation();
  const isHomePage = pathname === '/';

  return (
    <>
      <ToastContainer position='bottom-right' newestOnTop hideProgressBar theme='colored' />
      {isHomePage ? <HomePage /> : (
        <>
          <NavBar />
          <Container className="page-container">
            <Outlet />
          </Container>
        </>
      )}
    </>
  )
}

export default App;
