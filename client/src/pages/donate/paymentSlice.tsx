import { createAsyncThunk, createEntityAdapter, createSlice } from "@reduxjs/toolkit";
import agent from "../../features/api/agent";
import { Payment } from "../../features/models/payment";
import { RootState } from "../../features/store/configureStore";

const paymentsAdapter = createEntityAdapter<Payment>();

export const fetchPaymentsAsync = createAsyncThunk<Payment[]>(
    'job/GetAllJobs',
    async (_, thunkAPI) => {
        try {
            return await agent.Payments.createPaymentIntent();
        } catch (error: any) {
            return thunkAPI.rejectWithValue({error: error.data})
        }
    }
)



export const paymentSlice = createSlice({
    name: 'job',
    initialState: paymentsAdapter.getInitialState({
        paymentsLoaded: false,
        status: 'idle'
    }),
    reducers: {},
    extraReducers: (builder => {
        builder.addCase(fetchPaymentsAsync.pending, (state) => {
            state.status = 'pendingFetchJobs';
        });
        builder.addCase(fetchPaymentsAsync.fulfilled, (state, action) => {
            paymentsAdapter.setAll(state, action.payload);
            state.status = 'idle';
            state.paymentsLoaded = true;
        });
        builder.addCase(fetchPaymentsAsync.rejected, (state, action) => {
            console.log(action.payload);
            state.status = 'idle';
        });
    })
})

export const paymentSelectors = paymentsAdapter.getSelectors((state: RootState) => state.payment);