export interface User {
    username: string;
    displayName: string;
    token: string;
    tokenExpires: string;
    image?: string;
}

export interface UserFormValues {
    email: string;
    password: string;
    displayName?: string;
    userName?: string;
}