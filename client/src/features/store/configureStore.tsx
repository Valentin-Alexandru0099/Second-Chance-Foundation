import { configureStore } from "@reduxjs/toolkit";
import { TypedUseSelectorHook, useDispatch, useSelector } from "react-redux";
import { accountSlice } from "../../pages/account/accountSlice";
import { jobSlice } from "../../pages/job/jobSlice";
import { organizationSlice } from "../../pages/job/organizationSlice";



export const store = configureStore({
    reducer: {
        account: accountSlice.reducer,
        job: jobSlice.reducer,
        organization: organizationSlice.reducer,
        }
    })
    
    export type RootState = ReturnType<typeof store.getState>;
    export type AppDispatch = typeof store.dispatch;
    
    export const useAppDispatch = () => useDispatch<AppDispatch>();
    export const useAppSelector: TypedUseSelectorHook<RootState> = useSelector;