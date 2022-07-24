import { Link } from "react-router-dom";
import { useEffect } from "react";

export default function Carousel() {
   
  useEffect(() => {
    window.scrollTo(0, 0);
  }, []);
    
    return (
        <div id="carousel-thumb" className="carousel slide carousel-fade carousel-thumbnails" data-ride="carousel">
        <div className="carousel-inner" role="listbox">
            <div className="carousel-item active">
                <img className="d-block w-100" src="images/thumbs/ЛедниДронС.jpg" alt="First slide" />
                    <div className="gradient"></div>
                    <div className="carousel-caption">
                        <h4 className="lead">Парк за приключения</h4>
                        <h1>Ледницата</h1>
                        <Link className="btn btn-primary" to="/adventures"><span>вижте още</span></Link>
                    </div>
            </div>
            <div className="carousel-item">
                <img className="d-block w-100" src="images/thumbs/landsc.jpg" alt="Second slide" />
                    <div className="gradient"></div>
                    <div className="carousel-caption">
                        <h1>приключения безкрай!</h1>
                        <p className="lead">във всички посоки и измерения</p>
                        <Link className="btn btn-primary" to="/adventures"><span>вижте още</span></Link>
                    </div>
            </div>
            <div className="carousel-item">
                <img className="d-block w-100" src="images/thumbs/Tower.png" alt="Third slide" />
                    <div className="gradient"></div>
                    <div className="carousel-caption">
                        <h1>Висоти и панорами</h1>
                        <p className="lead">...не само за смелите и сръчните!</p>
                        <Link className="btn btn-primary" to="/adventures"><span>вижте още</span></Link>
                    </div>
            </div>
            <div className="carousel-item">
                <img className="d-block w-100" src="/images/thumbs/sunset.jpg" alt="Fourth slide" />
                    <div className="gradient"></div>
                    <div className="carousel-caption">
                        <h1>от зори до здрач!</h1>
                        <p className="lead">смисъл в днешния ден и надежда за утрешния :)</p>
                        <Link className="btn btn-primary" to="/adventures"><span>вижте още</span></Link>
                    </div>
            </div>
        </div>
    </div>
    );
}