
export interface Error {
    ErrorType: number;
    PropertyName?: any;
    ErrorMessage: string;
    AttemptedValue?: any;
    CustomState?: any;
    Severity: number;
    ErrorCode?: any;
    FormattedMessagePlaceholderValues?: any;
}

export interface ProblemDetails {
    Errors: Error[];
    Type?: any;
    Title: string;
    Status: number;
    Detail: string;
    Instance?: any;
}