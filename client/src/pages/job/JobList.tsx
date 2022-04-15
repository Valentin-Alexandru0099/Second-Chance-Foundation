import { Grid } from "@mui/material";
import { Job } from "../../features/models/job";
import { useAppSelector } from "../../features/store/configureStore";

interface Props {
    jobs: Job[];
}

export default function ProductList({ jobs }: Props) {
    const { jobsLoaded } = useAppSelector(state => state.job);
    return (
        <Grid container spacing={4}>
            {jobs.map(job => (
                <Grid item xs={4} key={job.id}>
                    <li>{job.name}</li>
                    <li>{job.description}</li>
                    {/* <li>{job.SubmissionTime}</li>  need to fix !!!!!!!1*/} 
                </Grid>
            ))}
        </Grid>
    )
}