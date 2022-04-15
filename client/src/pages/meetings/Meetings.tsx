import { Card, CardMedia, CardContent, Typography, CardActions, Button } from "@mui/material";
import { useEffect, useState } from "react";
import LoadingComponent from "../../components/LoadingComponent";
import agent from "../../features/api/agent";
import { Meeting } from "../../features/models/meeting";



export default function Meetings(){
    const [meetings, setMeetings] = useState<Meeting[] | null>(null);
    const [loading, setLoading] = useState(true);
    const [selectedOrderNumber, setSelectedOrderNumber] = useState(0);

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
        {meetings?.map((meeting) => (
                    <Card sx={{ maxWidth: 345 }}>
                    <CardMedia
                      component="img"
                      alt="green iguana"
                      height="140"
                      image="/static/images/cards/contemplative-reptile.jpg"
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
                      <Button size="small">Share</Button>
                      <Button size="small">Learn More</Button>
                    </CardActions>
                  </Card>
            ))}
        </>
    )
}

