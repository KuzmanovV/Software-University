import {Link} from "react-router-dom";

export default function Footer() {
    return (
        <footer>
        <section className="footer-top">
            <div className="container">
                <h2>Скали, Пещери, Катерене, Висоти, Забавления, Приключения ...</h2>
                <div className="row text-center text-lg-left">
                    <div className="col-lg-2 col-md-4 col-xs-6">
                        <Link to="/carouselItem4" className="d-block h-100">
                            <img className="img-fluid img-thumbnail" src="images/sunset.jpg" alt="" />
                        </Link>
                    </div>
                    <div className="col-lg-2 col-md-4 col-xs-6">
                        <Link to="/carouselItem1" className="d-block h-100">
                            <img className="img-fluid img-thumbnail" src="images/ЛедниДрон.jpg" alt="" />
                        </Link>
                    </div>
                    <div className="col-lg-2 col-md-4 col-xs-6">
                        <Link to="/carouselItem2" className="d-block h-100">
                            <img className="img-fluid img-thumbnail" src="images/landsc.jpg" alt="" />
                        </Link>
                    </div>
                    <div className="col-lg-2 col-md-4 col-xs-6">
                        <Link to="/carouselItem3" className="d-block h-100">
                            <img className="img-fluid img-thumbnail" src="images/Tower.png" alt="" />
                        </Link>
                    </div>
                    <div className="col-lg-2 col-md-4 col-xs-6">
                        <Link to="/carouselItem4" className="d-block h-100">
                            <img className="img-fluid img-thumbnail" src="images/sunset.jpg" alt="" />
                        </Link>
                    </div>
                    <div className="col-lg-2 col-md-4 col-xs-6">
                        <Link to="/carouselItem1" className="d-block h-100">
                            <img className="img-fluid img-thumbnail" src="images/ЛедниДрон.jpg" alt="" />
                        </Link>
                    </div>
                </div>

            </div>
        </section>
        <section className="footer-bottom">
            <div className="container">
                <div className="row">
                    <div className="col-md-12">
                        <ul>
                            <li><a href="index.html">Home</a></li>
                            <li className="hidden">/</li>
                            <li><a href="about.html">About-us</a></li>
                            <li className="hidden">/</li>
                            <li><a href="mystories.html">My stories</a></li>
                            <li className="hidden">/</li>
                            <li><a href="destinations.html">Destinations</a></li>
                            <li className="hidden">/</li>
                            <li><a href="gallery.html">Gallery</a></li>
                            <li className="hidden">/</li>
                            <li><a href="contact.html">Contact</a></li>
                        </ul>
                    </div>
                    <div className="col-md-12">
                        <p>(C) All Rights Reserved <a href="https://www.template.net/editable/websites/html5" target="_blank">ClickaHolic</a> <span>/</span> Designed and Developed by <a href="https://www.template.net/editable/websites/html5" target="_blank">Template.net</a></p>
                    </div>
                </div>
            </div>
        </section>
    </footer>
    )
}