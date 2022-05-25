export default function Carousel() {
    return (
        <div id="carousel-thumb" class="carousel slide carousel-fade carousel-thumbnails" data-ride="carousel">
        <div class="carousel-inner" role="listbox">
            <div class="carousel-item active">
                <img class="d-block w-100" src="images/ЛедниДронС.jpg" alt="First slide" />
                    <div class="gradient"></div>
                    <div class="carousel-caption">
                        <h1>Ледницата</h1>
                        <p class="lead">Парк за приключения</p>
                        <a class="btn btn-primary" href="about.html"><span>Learn more</span></a>
                    </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="images/banner-image-3.jpg" alt="Second slide" />
                    <div class="gradient"></div>
                    <div class="carousel-caption">
                        <h1>Remainings of old boat in the beach of bali.</h1>
                        <p class="lead">Remainings of old boat in the beach of bali...</p>
                        <a class="btn btn-primary" href="about.html"><span>Learn more</span></a>
                    </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="images/banner-image-2.jpg" alt="Third slide" />
                    <div class="gradient"></div>
                    <div class="carousel-caption">
                        <h1>Beautiful sunsetting in the mountains.</h1>
                        <p class="lead">Beautiful sunsetting in the mountains...</p>
                        <a class="btn btn-primary" href="about.html"><span>Learn more</span></a>
                    </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="images/banner-image-1.jpg" alt="Third slide" />
                    <div class="gradient"></div>
                    <div class="carousel-caption">
                        <h1>Snow white mountain of east china.</h1>
                        <p class="lead">Snow white mountain of east china...</p>
                        <a class="btn btn-primary" href="about.html"><span>Learn more</span></a>
                    </div>
            </div>
        </div>
        
        {/* <ol class="carousel-indicators">
            <li data-target="#carousel-thumb" data-slide-to="0" class="active"> <img class="d-block w-100" src="images/banner-image-4.jpg" className="img-fluid" />
                <span>Woman walking in the green fields</span>
            </li>
            <li data-target="#carousel-thumb" data-slide-to="1"><img class="d-block w-100" src="images/banner-image-3.jpg" className="img-fluid" />
                <span>Remainings of old boat in the beach of bali.</span>
            </li>
            <li data-target="#carousel-thumb" data-slide-to="2"><img class="d-block w-100" src="images/banner-image-2.jpg" className="img-fluid" />
                <span>Beautiful sunsetting in the mountains.</span>
            </li>
            <li data-target="#carousel-thumb" data-slide-to="3"><img class="d-block w-100" src="images/banner-image-1.jpg" className="img-fluid" />
                <span>Snow white mountain of east china.</span>
            </li>
        </ol> */}
    </div>
    );
}