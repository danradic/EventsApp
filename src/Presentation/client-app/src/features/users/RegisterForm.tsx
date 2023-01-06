import { ErrorMessage, Form, Formik } from "formik";
import { observer } from "mobx-react-lite";
import { Button, Header, Label } from "semantic-ui-react";
import MyTextInput from "../../app/common/form/MyTextInput";
import { useStore } from "../../app/stores/storeContext";
import * as Yup from 'yup';

export default observer(function RegisterForm() {
    const { userStore, commonStore } = useStore();

    return (
        <Formik
            initialValues={{ displayName: '', userName: '', email: '', password: '', error: null }}
            onSubmit={
                (values, { setErrors }) => userStore.register(values).catch(error =>
                    setErrors({ error: 'Invalid email or password' }))}
            validationSchema={Yup.object({
                displayName: Yup.string().required(),
                userName: Yup.string().required(),
                email: Yup.string().required(),
                password: Yup.string().required()
            })}
        >
            {({ handleSubmit, isSubmitting, errors, isValid, dirty }) => (
                <Form className="ui form" onSubmit={handleSubmit} autoComplete='off'>
                    <Header as='h2' content='Sign Up' color='teal' textAlign='center' />
                    <MyTextInput placeholder='Email' name='email' />
                    <MyTextInput placeholder='Display Name' name='displayName' />
                    <MyTextInput placeholder='Username' name='userName' />
                    <MyTextInput placeholder='Password' name='password' type='password' />
                    <ErrorMessage name='error' render={() =>
                        <Label style={{ marginBottom: 10 }} basic color="red" content={errors.error} />} />
                    <Button
                        disabled={!isValid || !dirty || isSubmitting}
                        loading={isSubmitting}
                        positive content='Register'
                        type='submit' fluid />
                </Form>
            )}

        </Formik>

    )
})