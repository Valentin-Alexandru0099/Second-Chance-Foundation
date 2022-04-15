export interface Job {
    id: number;
    name: string;
    description: string;
    SubmissionTime: Date;
    available: boolean;
    organization: Organization;
}

export interface Organization{
    id: number;
    name: string;
    description: string;
    website: string;
}