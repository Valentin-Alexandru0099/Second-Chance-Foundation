import { Typography } from "@mui/material";
import LocalPhoneTwoToneIcon from '@mui/icons-material/LocalPhoneTwoTone';
import FacebookRoundedIcon from '@mui/icons-material/FacebookRounded';
import WhatsappRoundedIcon from '@mui/icons-material/WhatsappRounded';
import GoogleMap from './Map/GoogleMap';
import './Contact.css';


export default function Contact() {


    const location = {
        address: 'Second Chance',
        lat: 44.4299641,
        lng: 26.1054737,
      }

    return (
        <> 
            <Typography variant='h3' className="contacttitle">Contact</Typography>
            <div className="mapdiv">
                <GoogleMap location={location} zoomLevel={19}></GoogleMap>
                </div>
                <div className="bigdiv">
                <div className="centerdiv">
                    <LocalPhoneTwoToneIcon/>
                    <p className="phonetext">Phone: +4024414670 </p>
                </div>
                <div className="centerdiv">
                    <FacebookRoundedIcon/>
                    <p className="phonetext">Facebook </p>
                </div>
                <div className="centerdiv">
                    <WhatsappRoundedIcon/>
                    <p className="phonetext">WhatsApp</p>
                </div>
                </div>
        </>
    )
}