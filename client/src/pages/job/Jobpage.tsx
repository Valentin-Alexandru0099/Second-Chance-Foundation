import { useEffect } from "react";
import LoadingComponent from "../../components/LoadingComponent";
import { useAppDispatch, useAppSelector } from "../../features/store/configureStore";
import { fetchJobsAsync, jobSelectors } from "./jobSlice";
import ProductList from "./JobList";

export default function Jobpage() {
    const jobs = useAppSelector(jobSelectors.selectAll);
    const {jobsLoaded, status} = useAppSelector(state => state.job);
    const dispatch = useAppDispatch();

    useEffect(() => {
        if (!jobsLoaded) dispatch(fetchJobsAsync());
    }, [jobsLoaded, dispatch])

    if (status.includes('pending')) return <LoadingComponent message='Loading products...' />

    return (
        <>
            <h1>Jobs</h1>
            <ProductList jobs={jobs} />
        </>
    )
}