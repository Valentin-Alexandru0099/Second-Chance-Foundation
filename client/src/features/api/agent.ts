import { store } from "../store/configureStore";
import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";
import { history } from "../..";


const sleep = () => new Promise(resolve => setTimeout(resolve , 500));

axios.defaults.baseURL = 'https://localhost:5001/api/';
axios.defaults.withCredentials = true;

const responseBody = (response : AxiosResponse) => response.data;

axios.interceptors.response.use(async response => {
    await sleep();
    return response;
}, (error: AxiosError) =>{
    const {data, status} = error.response!;
    switch (status) {
        case 400:
            if(data.errors) {
                const modelStateErrors : string[] = [];
                for(const key in data.errors){
                    if(data.errors[key]){
                        modelStateErrors.push(data.errors[key])
                    }
                }
                throw modelStateErrors.flat();
            }
            toast.error(data.title);
            break;
        case 401:
            toast.error(data.title || "Unauthorised");
            break;
        case 500:
            history.push({
                pathname: '/server-error',
                state: {error: data}
            })
            break;

        default:
            break;
    }
    return Promise.reject(error.response);
})

const requests = {
    get: (url: string, params?: URLSearchParams) => axios.get(url, {params}).then(responseBody),
    post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
    put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
    delete: (url: string) => axios.delete(url).then(responseBody),

}

const Account ={
    login: (values:any) =>requests.post('account/login', values),
    register: (values:any) =>requests.post('account/register', values),
    currentUser: () =>requests.get('account/currentUser'),
    fetchAddress: () => requests.get('account/savedAddress')
}

const agent = {
    Account,
}


export default agent;