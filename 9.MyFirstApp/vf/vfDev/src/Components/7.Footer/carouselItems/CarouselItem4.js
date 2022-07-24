import { useEffect } from "react";
import { Link } from "react-router-dom";

export default function CarouselItem4() {
    useEffect(() => {
        window.scrollTo(0, 0);
      }, []);
    
    return (
        <div className="carousel-inner" role="listbox">
            <div className="carousel-item active">
                <img className="d-block w-100" src="/images/thumbs/sunset.jpg" alt="Fourth slide" />
                    <div className="gradient"></div>
                    <div className="carousel-caption">
                        <h1>от зори до здрач!</h1>
                        <p className="lead">смисъл в днешния ден и надежда за утрешния :)</p>
                        <Link className="btn btn-primary" to="/adventures"><span>вижте още</span></Link>
                    </div>
            </div>
        </div>
    );
}