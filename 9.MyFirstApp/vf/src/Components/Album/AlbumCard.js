export default function AlbumCard({
    pic
}) {
    return(
        <a href="https://unsplash.it/1200/768.jpg?image=257" data-toggle="lightbox" data-gallery="example-gallery" class="col-xl-6 col-md-4 box-1">
                                    <img src="https://unsplash.it/600.jpg?image=257" class="img-fluid" />
                                    <div class="overlay">
                                        <img src="images/comment.png" alt="plus-icon" />
                                        <div class="text">Man standing on the middle of the road in the morning <span>Landscapes</span></div>
                                        <div class="count">45</div>
                                    </div>
                                </a>
    )
}