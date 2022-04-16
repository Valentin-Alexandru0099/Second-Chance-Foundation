import { Card, CardMedia, CardContent, Typography, CardActions, Button, ButtonBase, Link } from "@mui/material";
import { useEffect, useState } from "react";
import LoadingComponent from "../../components/LoadingComponent";
import agent from "../../features/api/agent";
import happy from '../../images/jobs.jpg';
import { Articles } from "../../features/models/article";
import './Article.css';
import AliceCarousel from 'react-alice-carousel';



export default function Article(){
    const [articles, setArticles] = useState<Articles[] | null>(null);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        agent.Article.list()
            .then(articles => setArticles(articles))
            .catch(error => console.log(error))
            .finally(() => setLoading(false));
    }, [])


    if (loading) return <LoadingComponent message='Loading orders' />

    
    return(
        <>
        <div className="articlecards">
        {articles?.map((article) => (
                    <Card sx={{ maxWidth: 600 }}>
                    <CardMedia
                      component="img"
                      alt="green iguana"
                      height="140"
                      image={happy}
                      key={article.id}
                    />
                    <CardContent>
                      <Typography gutterBottom variant="h5" component="div">
                        {article.title}
                      </Typography>
                      <Typography variant="body2" color="text.secondary">
                        {article.content}
                      </Typography>
                    </CardContent>
                  </Card>
            ))}
            </div>
        </>
    )
}

