import { Grid } from "@mui/material";
import { Job, Organization } from "../../features/models/job";
import { useAppSelector } from "../../features/store/configureStore";
import JobCards from "./JobCards";

interface Props {
    jobs: Job[];
    organization: Organization[];
}

export default function ProductList({ jobs, organization }: Props) {
    const { jobsLoaded } = useAppSelector(state => state.job);
    const { organizationsLoaded } = useAppSelector(state => state.organization);
    return (
        <Grid container spacing={4}>
            {jobs.map(job => (
                <Grid item xs={4} key={job.id}>
                <JobCards job={job} organization={organization} />
                </Grid>
            ))}
        </Grid>
    )
}