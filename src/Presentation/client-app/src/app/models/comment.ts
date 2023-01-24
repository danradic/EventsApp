export interface ChatComment {
    id: number;
    createdAt: Date;
    body: string;
    userName: string;
    applicationUserId: string;
    displayName: string;
    image: string;
}