import { Card, CardMedia, CardContent, Typography, CardActions, Button, ButtonBase, Link } from "@mui/material";
import { useEffect, useState } from "react";
import LoadingComponent from "../../components/LoadingComponent";
import agent from "../../features/api/agent";
import { Meeting } from "../../features/models/meeting";
import happy from '../../images/jobs.jpg'
import './Meetings.css'



export default function Meetings(){
    const [meetings, setMeetings] = useState<Meeting[] | null>(null);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        agent.Meetings.list()
            .then(meetings => setMeetings(meetings))
            .catch(error => console.log(error))
            .finally(() => setLoading(false));
    }, [])


    if (loading) return <LoadingComponent message='Loading orders' />

    
    return(
        <>
        <h1>Meetings</h1>
        <div className="meetingcards">
        {meetings?.map((meeting) => (
                    <Card sx={{ maxWidth: 600 }}>
                    <CardMedia
                      component="img"
                      alt="green iguana"
                      height="140"
                      image={happy}
                      key={meeting.id}
                    />
                    <CardContent>
                      <Typography gutterBottom variant="h5" component="div">
                        {meeting.name}
                      </Typography>
                      <Typography variant="body2" color="text.secondary">
                        {meeting.description}
                      </Typography>
                    </CardContent>
                    <CardActions>
                      <a href='https://meet.google.com/phn-zdmo-kox' className="meetlink">Join meet</a>
                    </CardActions>
                  </Card>
            ))}
            </div>
        </>
    )
}

