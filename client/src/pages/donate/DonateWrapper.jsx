
import { loadStripe } from "@stripe/stripe-js";
import { useEffect, useState } from "react";
import LoadingComponent from "../../components/LoadingComponent";
import agent from "../../features/api/agent";
import { useAppDispatch } from "../../features/store/configureStore";
import Donate from "./Donate";
import {Elements} from 'react-stripe-elements';


const stripePromise = loadStripe("pk_test_51Kp8FMFZPLb2Hf6PKyATbp7RDCtdrf5g66CiiDmjiaATB5Me4RDbBpa429bC8Mw0xWViuFe9z6dHXdTUlzd5fpDk00A938FoB8")

export default function CheckoutWrapper() {
    const dispatch = useAppDispatch();
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        agent.Payments.createPaymentIntent()
            .catch(error => console.log(error))
            .finally(() => setLoading(false));
    }, [dispatch]);


    if (loading) return <LoadingComponent message='Loading checkout...' />

    return (
        <Elements stripe={stripePromise}>
            <Donate />
        </Elements>
    )
}