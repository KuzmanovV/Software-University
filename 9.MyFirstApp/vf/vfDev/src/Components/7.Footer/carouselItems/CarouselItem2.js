import { useEffect } from "react";
import { Link } from "react-router-dom";

export default function CarouselItem2() {
    useEffect(() => {
        window.scrollTo(0, 0);
      }, []);
    
    return (
        <div className="carousel-inner" role="listbox">
            <div className="carousel-item active">
                <img className="d-block w-100" src="images/thumbs/landsc.jpg" alt="Second slide" />
                    <div className="gradient"></div>
                    <div className="carousel-caption">
                        <h1>приключения безкрай!</h1>
                        <p className="lead">във всички посоки и измерения</p>
                        <Link className="btn btn-primary" to="/adventures"><span>вижте още</span></Link>
                    </div>
            </div>
        </div>
    );
}