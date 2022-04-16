
import { Box, Container, Grid, Typography } from "@mui/material";
import { Link } from "react-router-dom";
import './Footer.css';


export default function Footer(){
    return(
        <footer>
            <Box
            className="footerbody"
             px={{ xd:3,sm:10 }}
            py={{xs:5, sm:10 }}
            color="white">
                <Container maxWidth='lg'>
                    <Grid container spacing={7} >
                        <Grid item xs={12} sm={4} spacing={4}>
                            <Box borderBottom={1}><Typography variant='h5' className="footertitle">Informations</Typography></Box>
                            <Box sx={{ p: 1}}>
                                <Link className="footerlinks" to='/' color='inherit'>
                                    Home
                                </Link>
                            </Box>
                            <Box sx={{ p: 1}}>
                                <Link className="footerlinks" to='/contact' color='inherit'>
                                    Contact
                                </Link>
                            </Box>
                            <Box sx={{ p: 1}}>
                                <Link className="footerlinks" to='/about' color='inherit'>
                                    About
                                </Link>
                            </Box>
                        </Grid>
                        <Grid item xs={12} sm={4}>
                            <Box borderBottom={1}><Typography variant='h5' className="footertitle">Help</Typography></Box>
                            <Box sx={{ p: 1}}>
                                <Link className="footerlinks" to='/servicii' color='inherit'>
                                    Meetings
                                </Link>
                            </Box>
                            <Box sx={{ p: 1}}>
                                <Link className="footerlinks" to='/servicii' color='inherit'>
                                Job applications
                                </Link>
                            </Box>
                            <Box sx={{ p: 1}}>
                                <Link className="footerlinks" to='/servicii' color='inherit'>
                                    Register
                                </Link>
                            </Box>
                        </Grid>
                        <Grid item xs={12} sm={4}>
                            <Box borderBottom={1}><Typography variant='h5' className="footertitle">Contact</Typography></Box>
                            <Box sx={{ p: 1}}>
                                <a href="tel:" className="footerlinks">Phone</a>
                            </Box>
                            <Box sx={{ p: 1}}>
                                <a href="https://wa.me/" className="footerlinks" target="_blank">
                                    WhatsApp
                                </a>
                            </Box>
                            <Box sx={{ p: 1}}>
                                <a href="" className="footerlinks" target="_blank">
                                    Facebook
                                </a>
                            </Box>
                            <Box sx={{ p: 1}}>
                                <a href="" className="footerlinks" target="_blank">
                                    Donate
                                </a>
                            </Box>
                        </Grid>

                    </Grid>
                    <Box textAlign="center" pt={{ xs:5, sm:10}} pb={{xs:5 , sm:0}} className="mark">
                        Second Chance &reg; {new Date().getFullYear()}
                    </Box>
                </Container>
            </Box>
        </footer>
    )
}