import { createAsyncThunk, createEntityAdapter, createSlice } from "@reduxjs/toolkit";
import agent from "../../features/api/agent";
import { Organization } from "../../features/models/job";
import { RootState } from "../../features/store/configureStore";

const organizationsAdapter = createEntityAdapter<Organization>();

export const fetchOrganizationsAsync = createAsyncThunk<Organization[]>(
    'organization/GetAllOrganizations',
    async (_, thunkAPI) => {
        try {
            return await agent.Organization.getAllOrganizations();
        } catch (error: any) {
            return thunkAPI.rejectWithValue({error: error.data})
        }
    }
)

export const fetchOrganizationAsync = createAsyncThunk<Organization, number>(
    'organization/fetchOrganizationAsync',
    async (organizationId, thunkAPI) => {
        try {
            return await agent.Organization.details(organizationId);
        } catch (error: any) {
            return thunkAPI.rejectWithValue({error: error.data})
        }
    }
)

export const organizationSlice = createSlice({
    name: 'organization',
    initialState: organizationsAdapter.getInitialState({
        organizationsLoaded: false,
        status: 'idle'
    }),
    reducers: {},
    extraReducers: (builder => {
        builder.addCase(fetchOrganizationsAsync.pending, (state) => {
            state.status = 'pendingFetchOrganizations';
        });
        builder.addCase(fetchOrganizationsAsync.fulfilled, (state, action) => {
            organizationsAdapter.setAll(state, action.payload);
            state.status = 'idle';
            state.organizationsLoaded = true;
        });
        builder.addCase(fetchOrganizationsAsync.rejected, (state, action) => {
            console.log(action.payload);
            state.status = 'idle';
        });
        builder.addCase(fetchOrganizationAsync.pending, (state) => {
            state.status = 'pendingFetchOrganization';
        });
        builder.addCase(fetchOrganizationAsync.fulfilled, (state, action) => {
            organizationsAdapter.upsertOne(state, action.payload);
            state.status = 'idle';
        });
        builder.addCase(fetchOrganizationAsync.rejected, (state, action) => {
            console.log(action);
            state.status = 'idle';
        })
    })
})

export const organizationsSelectors = organizationsAdapter.getSelectors((state: RootState) => state.organization);