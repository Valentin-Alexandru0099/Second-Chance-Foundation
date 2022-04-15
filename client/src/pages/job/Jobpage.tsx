import { useEffect } from "react";
import LoadingComponent from "../../components/LoadingComponent";
import { useAppDispatch, useAppSelector } from "../../features/store/configureStore";
import { fetchJobsAsync, jobSelectors } from "./jobSlice";
import JobList from "./JobList";
import { fetchOrganizationsAsync, organizationsSelectors } from "./organizationSlice";

export default function Jobpage() {
    const jobs = useAppSelector(jobSelectors.selectAll);
    const organizations = useAppSelector(organizationsSelectors.selectAll);
    const {jobsLoaded, status} = useAppSelector(state => state.job);    
    // const {organizationsLoaded, status} = useAppSelector(state => state.job);
    const dispatch = useAppDispatch();

    useEffect(() => {
        if (!jobsLoaded) dispatch(fetchJobsAsync());
        dispatch(fetchOrganizationsAsync());
        
    }, [jobsLoaded, dispatch])

    if (status.includes('pending')) return <LoadingComponent message='Loading products...' />

    return (
        <>
            <h1 className="jobstitle">Available Jobs</h1>
            <JobList jobs={jobs} organization={organizations} />
        </>
    )
}