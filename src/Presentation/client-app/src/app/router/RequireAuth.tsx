import { Navigate, Outlet, useLocation } from "react-router-dom";
import { useStore } from "../stores/storeContext";

export default function RequireAuth() {
    const { userStore: { isLoggedIn } } = useStore();
    const location = useLocation();

    if (!isLoggedIn) {
        return <Navigate to='/' state={{ from: location }} />
    }

    return <Outlet />
}