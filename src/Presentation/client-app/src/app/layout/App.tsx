import NavBar from './NavBar';
import { Outlet, ScrollRestoration, useLocation } from 'react-router-dom';
import { ToastContainer } from 'react-toastify';
import { Container } from 'semantic-ui-react';
import HomePage from '../../features/home/HomePage';
import { useStore } from '../stores/storeContext';
import { useEffect } from 'react';
import LoadingComponent from './LoadingComponent';
import ModalContainer from '../common/modals/ModalContainer';
import { observer } from 'mobx-react-lite';

function App() {
  const { pathname } = useLocation();
  const isHomePage = pathname === '/';
  const { commonStore, userStore } = useStore();

  useEffect(() => {
    if (commonStore.token && !commonStore.isTokenExpired(commonStore.tokenExpireDate)) {
      userStore.getUser().finally(() => {
        commonStore.setAppLoaded()});
    } else {
      commonStore.setAppLoaded();
    }
  }, [commonStore, userStore]);
  if(!commonStore.appLoaded) return <LoadingComponent content='Loading app..' />

  return (
    <>
      <ScrollRestoration />
      <ModalContainer />
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

export default observer(App);
