import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import './Profile.css'
import { useAppSelector } from '../../features/store/configureStore';
import PictureUploader from './PictureUploader';
import Fileupload  from './FileUpload';


export default function Profile(){

    const { user } = useAppSelector(state => state.account);
    
    return(
        <>
        <h1>Profile</h1>
        <p>Hello {user?.email}</p>
        <Fileupload/>
        <p>Enter your detail information</p>
        <Box
      component="form"
      sx={{
        '& .MuiTextField-root': { m: 1, width: '25ch' },
      }}
      noValidate
      autoComplete="off"
    />
     <div className='fields'>
        <TextField
          required
          id="outlined-required"
          label="Required"
          defaultValue="First Name"
        />
                <TextField
          required
          id="outlined-required"
          label="Required"
          defaultValue="Last Name"
        />
        <TextField
          required
          id="outlined-required"
          label="Required"
          defaultValue="Phone Number"
        />
        <TextField
          required
          id="outlined-required"
          label="Required"
          defaultValue="Description"
        />
        </div>
        </>
        )
    
}