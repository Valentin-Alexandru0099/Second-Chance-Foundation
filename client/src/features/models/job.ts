export interface Organization{
    id: number;
    name: string;
    description: string;
    website: string;
}

export interface Job {
    id: number;
    name: string;
    description: string;
    SubmissionTime: string;
    available: boolean;
    organizationId: number;
    organization: Organization
}

