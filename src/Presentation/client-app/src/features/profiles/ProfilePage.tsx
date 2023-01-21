import { observer } from "mobx-react-lite";
import { useEffect } from "react";
import { useParams } from "react-router-dom";
import { Grid } from "semantic-ui-react";
import LoadingComponent from "../../app/layout/LoadingComponent";
import { useStore } from "../../app/stores/storeContext";
import ProfileContent from "./ProfileContent";
import ProfileHeader from "./ProfileHeader";

export default observer(function ProfilePage() {
    const {userid} = useParams();
    const {profileStore} = useStore();
    const {loadingProfile, loadProfile, profile, setActiveTab} = profileStore;

    useEffect(() => {
        if (userid) loadProfile(userid);
        return () => {
            setActiveTab(0);
        }
    }, [loadProfile, userid, setActiveTab])

    if (loadingProfile) return <LoadingComponent inverted content='Loading profile...' />

    if (!profile) return <h2>Problem loading profile</h2>
    
    return (
        <Grid>
            <Grid.Column width='16'>
                <ProfileHeader profile={profile}/>
                <ProfileContent profile={profile} />
            </Grid.Column>
        </Grid>
    )
})