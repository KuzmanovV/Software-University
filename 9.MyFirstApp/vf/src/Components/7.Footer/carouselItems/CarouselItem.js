import { useEffect } from "react";
import { Link } from "react-router-dom";

export default function CarouselItem() {
    useEffect(() => {
        window.scrollTo(0, 0);
      }, []);
    
    return (
        <div className="carousel-inner" role="listbox">
            <div className="carousel-item active">
                <img className="d-block w-100" src="images/ЛедниДронС.jpg" alt="First slide" />
                    <div className="gradient"></div>
                    <div className="carousel-caption">
                        <h4 className="lead">Парк за приключения</h4>
                        <h1>Ледницата</h1>
                        <Link className="btn btn-primary" to="/adventures"><span>вижте още</span></Link>
                    </div>
            </div>
    </div>
    );
}