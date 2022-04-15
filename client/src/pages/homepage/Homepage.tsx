import happy from '../../images/jobs.jpg';
import './Homepage.css';
import second from '../../images/video.mp4';

export default function Homepage(){
    return(
        <>
        <h1>We are Second Chance</h1>
        <img src={happy} className='homepageimg'></img>

        
        <div className='homepagetxt'>
            
            <p>
            <h2>We are Second Chance!</h2>
            We are here to help people from all kinds of backgrounds
            find a job and get a second chance
            at the same time helping companies
            to get workforce. </p>
            {/*
            // @ts-ignore */}
        <video autoPlay="autoplay" loop="loop"  width="600" height="600" className='videop'>
    <source src={second} type="video/mp4" />
        </video>
        </div>
        
                

        
        </>
    )
}