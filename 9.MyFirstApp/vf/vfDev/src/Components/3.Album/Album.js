import { useEffect, useState } from "react";
import AlbumCard from './AlbumCard.js';

export default function Album () {
    // AutoGoUp hack
  useEffect(() => {
    window.scrollTo(0, 0);
  }, []);
    
    const [pics, setPics] = useState([]);
    
    useEffect(()=>{
        fetch('https://parseapi.back4app.com/classes/PicsBase',{
            method: 'GET',
            headers: {
                'X-Parse-Application-Id': 'XwBHamKqXHfzyCOOR2Ki1mUWSAeRUcURBBHooDGs',
                'X-Parse-REST-API-Key':'kwUKzkv4QNkVX3miI74lUPTw1Qzu1j4UZIi2Qql9'
            }
        })
        .then(res=>res.json())
        .then(result=>{
            setPics(result.results[0].Image.url);
        })
    }, []);
    console.log(pics);

    return (

        <section id="portfolio">
                <div class="container">
                    <h2></h2>
                    <h2></h2>
<a target="blank" href="https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn"><h3><b>Албум в GOOGLE</b></h3></a>

                    <div class="row justify-content-center">
                        <div class="col-md-12 col-12">
                            <div class="row">
                                <a href="https://unsplash.it/1200/768.jpg?image=251" data-toggle="lightbox" data-gallery="example-gallery" class="col-xl-6 col-md-4 box-1">
                                    <img src={pics} class="img-fluid" />
                                    <div class="overlay">
                                        <img src="images/comment.png" alt="plus-icon" />
                                        <div class="text">Man standing on the middle of the road in the morning <span>Landscapes</span></div>
                                        <div class="count">45</div>
                                    </div>
                                </a>
                                <a href="https://unsplash.it/1200/768.jpg?image=252" data-toggle="lightbox" data-gallery="example-gallery" class="col-xl-3 col-md-4 box-2">
                                    <img src={pics} class="img-fluid" />
                                    <div class="overlay">
                                        <img src="images/comment.png" alt="plus-icon" />
                                        <div class="text">Man standing on the middle of the road in the morning <span>Landscapes</span></div>
                                        <div class="count">45</div>
                                    </div>
                                </a>
                                <a href="https://unsplash.it/1200/768.jpg?image=253" data-toggle="lightbox" data-gallery="example-gallery" class="col-xl-3 col-md-4 box-2">
                                    <img src="https://unsplash.it/600.jpg?image=253" class="img-fluid" />
                                    <div class="overlay">
                                        <img src="images/comment.png" alt="plus-icon" />
                                        <div class="text">Man standing on the middle of the road in the morning <span>Landscapes</span></div>
                                        <div class="count">45</div>
                                    </div>
                                </a>
                            </div>
                            <div class="row">
                                
                                {/* {pics.map(x=><AlbumCard pic={x}/>)} */}

                               
                                <a href="https://unsplash.it/1200/768.jpg?image=256" data-toggle="lightbox" data-gallery="example-gallery" class="col-xl-6 col-md-4 box-1">
                                    <img src="https://unsplash.it/600.jpg?image=256" class="img-fluid" />
                                    <div class="overlay">
                                        <img src="images/comment.png" alt="plus-icon" />
                                        <div class="text">Man standing on the middle of the road in the morning <span>Landscapes</span></div>
                                        <div class="count">45</div>
                                    </div>
                                </a>
                            </div>
                            <div class="row">
                            </div>
                        </div>
                    </div>
                </div>
            </section>
    );
}