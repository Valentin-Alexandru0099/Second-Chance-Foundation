import './Homepage.css';
import second from '../../images/video.mp4';
import AOS from "aos";
import "aos/dist/aos.css";
import happy from '../../images/jobs.jpg';
import 'animate.css';
import { Link, useHistory } from 'react-router-dom';
import Article from '../article/Article';

AOS.init();


export default function Homepage(){
    const history = useHistory();
    return(
        <>
        
        <div >
            <img src={happy} className='homepageimg'></img>
            <button onClick={() => history.push('/about')} className="animate__animated animate__backInDown btn">Learn more!</button>
        </div>

        <div data-aos="fade-right">
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
        </div>
        <Article/>
        
                

        
        </>
    )
}