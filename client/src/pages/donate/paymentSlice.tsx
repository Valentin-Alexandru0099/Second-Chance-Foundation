import { createAsyncThunk, createEntityAdapter, createSlice } from "@reduxjs/toolkit";
import agent from "../../features/api/agent";
import { Payment } from "../../features/models/payment";
import { RootState } from "../../features/store/configureStore";

const paymentsAdapter = createEntityAdapter<Payment>();

export const fetchPaymentsAsync = createAsyncThunk<Payment[]>(
    'payments/GetClientSecret',
    async (_, thunkAPI) => {
        try {
            return await agent.Payments.getClientSecret();
        } catch (error: any) {
            return thunkAPI.rejectWithValue({error: error.data})
        }
    }
)



export const paymentSlice = createSlice({
    name: 'payments',
    initialState: paymentsAdapter.getInitialState({
        paymentsLoaded: null,
        status: 'idle'
    }),
    reducers: {
        setPayments: (state, action) => {
            state.paymentsLoaded = action.payload
        },
    },
    extraReducers: (builder => {
        builder.addCase(fetchPaymentsAsync.pending, (state) => {
            state.status = 'pendingFetchJobs';
        });
        builder.addCase(fetchPaymentsAsync.fulfilled, (state, action) => {
            paymentsAdapter.setAll(state, action.payload);
            state.status = 'idle';
        });
        builder.addCase(fetchPaymentsAsync.rejected, (state, action) => {
            console.log(action.payload);
            state.status = 'idle';
        });
    })
})

export const {setPayments} = paymentSlice.actions;