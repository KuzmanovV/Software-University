import {Link} from "react-router-dom";

export default function Footer() {
    return (
        <>
        <footer>
        <section className="footer-top">
            <div className="container">
                <h3>Скали, Пещери, Висоти, Катерене, Забавления, Приключения ...</h3>
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
                        <a target="blank" href="https://www.facebook.com/groups/85669606098">
                        <i className="fa fa-facebook-square" aria-hidden="true"></i>
                    </a>
                    {/* <a href="https://viber.me/Жорж Влайков/">
                    Viber
                    </a> */}
                            <li className="hidden">/</li>
                            <li><Link to="/">Home</Link></li>
                            <li className="hidden">/</li>
                            <li><Link to="/coordinates">Contact</Link></li>
                            <li className="hidden">/</li>
                            <li><Link to="/adventures">Adventures</Link></li>
                            <li className="hidden">/</li>
                            <li><Link to="/album">Pictures</Link></li>
                            <li className="hidden">/</li>
                            {/* <li><Link to="/contest">Contest</Link></li>
                            <li className="hidden">/</li>
                            <li><Link to="/login">Login</Link></li>
                            <li className="hidden">/</li>
                            <li><Link to="/register">Register</Link></li> */}
                        </ul>
                    </div>
                    <div className="col-md-12">
                        <p>(C) All Rights Reserved 
                            <a href="https://themewagon.com/themes/free-bootstrap-4-html5-personal-travel-blog-website-template-clickaholic/" target="_blank">ClickaHolic</a>
                            <span>/</span> 
                            Designed and Developed by <a href="https://www.template.net" target="_blank">Template.net</a>
                            <span>/</span> 
                            Developed for Lednicata by V. Kuzmanov{/* <a href="https://www.template.net/editable/websites/html5" target="_blank">  </a> */}
                        </p>
                    </div>


                </div>
            </div>
            </section>
        </footer>
                    {/* Return to Top */}
                    <a href="#top" id="return-to-top"><i class="fa fa-long-arrow-up" aria-hidden="true"></i></a>
                    </>
    )
}