import { createAsyncThunk, createEntityAdapter, createSlice } from "@reduxjs/toolkit";
import agent from "../../features/api/agent";
import { Job } from "../../features/models/job";
import { RootState } from "../../features/store/configureStore";

const jobsAdapter = createEntityAdapter<Job>();

export const fetchJobsAsync = createAsyncThunk<Job[]>(
    'job/GetAllJobs',
    async (_, thunkAPI) => {
        try {
            return await agent.Job.getAllJobs();
        } catch (error: any) {
            return thunkAPI.rejectWithValue({error: error.data})
        }
    }
)

export const fetchJobAsync = createAsyncThunk<Job, number>(
    'job/fetchJobAsync',
    async (jobId, thunkAPI) => {
        try {
            return await agent.Job.details(jobId);
        } catch (error: any) {
            return thunkAPI.rejectWithValue({error: error.data})
        }
    }
)

export const jobSlice = createSlice({
    name: 'job',
    initialState: jobsAdapter.getInitialState({
        jobsLoaded: false,
        status: 'idle'
    }),
    reducers: {},
    extraReducers: (builder => {
        builder.addCase(fetchJobsAsync.pending, (state) => {
            state.status = 'pendingFetchProducts';
        });
        builder.addCase(fetchJobsAsync.fulfilled, (state, action) => {
            jobsAdapter.setAll(state, action.payload);
            state.status = 'idle';
            state.jobsLoaded = true;
        });
        builder.addCase(fetchJobsAsync.rejected, (state, action) => {
            console.log(action.payload);
            state.status = 'idle';
        });
        builder.addCase(fetchJobAsync.pending, (state) => {
            state.status = 'pendingFetchProduct';
        });
        builder.addCase(fetchJobAsync.fulfilled, (state, action) => {
            jobsAdapter.upsertOne(state, action.payload);
            state.status = 'idle';
        });
        builder.addCase(fetchJobAsync.rejected, (state, action) => {
            console.log(action);
            state.status = 'idle';
        })
    })
})

export const productSelectors = jobsAdapter.getSelectors((state: RootState) => state.job);