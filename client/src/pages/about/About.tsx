import happy2 from '../../images/video2.mp4';
import AOS from "aos";
import "aos/dist/aos.css";
import './About.css';
import working from '../../images/working.jpg';
import working2 from '../../images/working2.jpg';

AOS.init();

export default function About(){

    return(

        <>
        <div className='textvid'>
        <div className='titleabs'>
            {/*
                // @ts-ignore */}
        <video autoPlay="autoplay" loop="loop"  width="95%" height="40%" className='videop'>
        <source src={happy2} type="video/mp4" />
        </video>
        <div className='animate__animated animate__fadeInLeft title'>
            <p>We are Second Chance!</p>
        </div>
        </div>
        </div>
        <div className='firstphoto'>
            <p className='firsttext'>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla in consectetur augue, non lacinia est. Praesent semper pharetra eleifend. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Mauris sem purus, elementum at semper id, pulvinar quis dolor. Etiam vitae nulla a lorem vulputate dictum sed eu orci. Nullam iaculis nisi ac massa mollis facilisis. Curabitur pellentesque dolor at faucibus sollicitudin. Suspendisse mattis suscipit arcu, at accumsan velit tincidunt eget. Sed finibus consectetur odio, iaculis elementum sem pretium faucibus. Nam pretium dui at libero accumsan eleifend. Ut ac turpis sapien. Ut et mi in enim fringilla tincidunt. Donec at elit tristique, congue ligula mattis, venenatis tortor. Duis egestas maximus tristique. Vestibulum non tempor nunc, eget faucibus lorem. Morbi libero nibh, tincidunt a diam sed, pulvinar interdum enim.

Cras vel lectus id leo vulputate vulputate a eget urna. Quisque nec libero mauris. Etiam ut lacus sit amet leo dignissim pulvinar eget vel ipsum. Nulla iaculis neque at neque eleifend tincidunt. Etiam tempus urna massa, faucibus pretium mi pharetra ut. Vivamus ultrices sed sem consectetur congue. Aenean eu dui vitae mi posuere vulputate. Nunc congue nisi dignissim, feugiat tortor eu, porttitor dui. Phasellus sagittis sodales odio id porta. Proin auctor arcu dolor, sit amet eleifend velit aliquam quis. Duis risus enim, interdum vitae convallis quis, tincidunt nec ipsum. Nam ligula tellus, suscipit at lacus sit amet, rhoncus ultrices sem.
</p>
<div data-aos="zoom-in">
        <img src={working} className='working'></img>
        </div>
        </div>
        <div className='secondphoto'>
            <p className='secondtext'>Phasellus hendrerit, metus a scelerisque iaculis, eros sem venenatis metus, vitae iaculis urna nulla ac nisl. In efficitur nisi odio, quis tincidunt turpis vestibulum eget. Donec nec suscipit justo. Aenean tincidunt bibendum maximus. Suspendisse condimentum ipsum efficitur, vestibulum lacus sed, lobortis urna. Proin varius metus dolor, non maximus augue porta eget. Proin felis quam, volutpat in posuere ac, placerat a massa. Sed aliquet elit sed erat ornare volutpat. In hac habitasse platea dictumst. Sed eget aliquet urna. Cras fringilla semper rutrum.

Vivamus non leo id ante auctor pulvinar. Vivamus sagittis velit vel diam luctus, id elementum neque commodo. Sed dapibus nisl non nunc lobortis bibendum. Proin quis odio dolor. Proin vel orci eget mi auctor luctus vel et justo. Quisque id maximus odio. Vestibulum consequat tellus at sapien elementum, a ultricies justo euismod.

Nunc in nulla lorem. Curabitur aliquam magna et quam convallis sagittis. In elementum et arcu a imperdiet. Proin imperdiet dui id quam feugiat suscipit. Sed venenatis finibus nisi vel facilisis. Sed id tellus semper, rhoncus eros ut, vehicula orci. Nam facilisis diam a venenatis gravida.</p>

<div data-aos="zoom-in">
<img src={working2} className='working2'></img>
</div>
        </div>
        </>
    )
}