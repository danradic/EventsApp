import { Form, Formik } from "formik";
import { observer } from "mobx-react-lite";
import { Button } from "semantic-ui-react";
import MyTextInput from "../../app/common/form/MyTextInput";
import { useStore } from "../../app/stores/storeContext";

export default observer(function LoginForm() {
    const {userStore} = useStore();
    return (
        <Formik
            initialValues={{ email: '', password: '' }}
            onSubmit={values => userStore.login(values)}
        >
            {({handleSubmit, isSubmitting}) => (
                <Form className="ui form" onSubmit={handleSubmit} autoComplete='off'>
                    <MyTextInput placeholder='Email' name='email' />
                    <MyTextInput placeholder='Password' name='password' type='password' />
                    <Button loading={isSubmitting} positive content='Login' type='submit' fluid />
                </Form>
            )}

        </Formik>

    )
})