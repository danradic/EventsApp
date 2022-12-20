import NavBar from './NavBar';
import { Outlet } from 'react-router-dom';
import { ToastContainer } from 'react-toastify';

function App() {
  return (
    <>
      <ToastContainer position='bottom-right' hideProgressBar theme='colored' />
      <NavBar />
      <Outlet />
    </>
  )
}

export default App;
