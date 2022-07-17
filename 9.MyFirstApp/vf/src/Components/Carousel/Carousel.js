import { Link } from "react-router-dom";

export default function Carousel() {
    return (
        <div id="carousel-thumb" class="carousel slide carousel-fade carousel-thumbnails" data-ride="carousel">
        <div class="carousel-inner" role="listbox">
            <div class="carousel-item active">
                <img class="d-block w-100" src="images/ЛедниДронС.jpg" alt="First slide" />
                    <div class="gradient"></div>
                    <div class="carousel-caption">
                        <h4 class="lead">Парк за приключения</h4>
                        <h1>Ледницата</h1>
                        <Link class="btn btn-primary" to="/adventures"><span>вижте още</span></Link>
                    </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="images/landsc.jpg" alt="Second slide" />
                    <div class="gradient"></div>
                    <div class="carousel-caption">
                        <h1>приключения безкрай!</h1>
                        <p class="lead">във всички посоки и измерения</p>
                        <a class="btn btn-primary" href="about.html"><span>Learn more</span></a>
                    </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="images/Tower.png" alt="Third slide" />
                    <div class="gradient"></div>
                    <div class="carousel-caption">
                        <h1>Висоти и панорами</h1>
                        <p class="lead">...не само за смелите и сръчните!</p>
                        <a class="btn btn-primary" href="about.html"><span>Learn more</span></a>
                    </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="/images/sunset.jpg" alt="Third slide" />
                    <div class="gradient"></div>
                    <div class="carousel-caption">
                        <h1>от зори до здрач!</h1>
                        <p class="lead">смисъл в днешния ден и надежда в утрешния :)</p>
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