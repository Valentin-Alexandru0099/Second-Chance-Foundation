
import { AppBar, Badge, IconButton, List, ListItem, Switch, Toolbar, Typography, Box } from "@mui/material";
import { Link, NavLink } from "react-router-dom";
import { useAppSelector } from "../../features/store/configureStore";
import '../Navbar/Navbar.css'
import SignedInMenu from "../SignedInMenu";

const midLinks=[
    {title: 'meetings', path: '/meetings'},
    {title: 'about ', path: '/about'},
    { title: 'contact', path: '/contact' },
    {title: 'jobs', path: '/jobs'},
    {title: 'donate', path: '/donate'},
]

const rightLinks=[
    {title: 'login', path: '/login'},
    {title: 'register ', path: '/register'},
]



export default function Navbar() {
    const { user } = useAppSelector(state => state.account);
    
    return (
        <>
            <AppBar position="static" sx={{mb: 4}}>
            <Toolbar sx={{display: 'flex', justifyContent:'space-between', alignItems: 'center'}}>

            <Box display='flex' alignItems='center'>
                <Typography variant="h6" component={NavLink} to='/' exact
                 sx={{color: 'black', textDecoration:'none',fontFamily: 'Raleway',fontWeight: 700}}>
                   <Typography variant='h5'>Second chance</Typography>
                </Typography>

            </Box>

                <List sx={{display:'flex'}} className="nav">
                    {midLinks.map(({title, path})=> (
                        <ListItem className="links border"
                        component={NavLink}
                        to={path}
                        key={path}
                        >
                            {title.toUpperCase()}
                        </ListItem>
                    ))}
                </List>

                <Box display='flex' alignItems='center'>
            
                {user ? (
                    <SignedInMenu></SignedInMenu>
                ):(
                    <List sx={{display:'flex', fontFamily: 'Raleway',
                    fontWeight: 700}}>
                    {rightLinks.map(({title, path})=> (
                        <ListItem className="linksa border"
                        component={NavLink}
                        to={path}
                        key={path}
                        sx={{fontFamily: 'Raleway',
                        fontWeight: 700}}>
                            {title.toUpperCase()}
                        </ListItem>
                    ))}
                </List>
                )}
                
                </Box>

            </Toolbar>
        </AppBar>
        </>
    )
}