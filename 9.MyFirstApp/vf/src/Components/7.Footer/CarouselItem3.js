import { Link } from "react-router-dom";

export default function CarouselItem3() {
    return (
        <div className="carousel-inner" role="listbox">
            <div className="carousel-item active">
                <img className="d-block w-100" src="images/Tower.png" alt="Third slide" />
                    <div className="gradient"></div>
                    <div className="carousel-caption">
                        <h1>Висоти и панорами</h1>
                        <p className="lead">...не само за смелите и сръчните!</p>
                        <Link className="btn btn-primary" to="/adventures"><span>вижте още</span></Link>
                    </div>
            </div>
        </div>
    );
}