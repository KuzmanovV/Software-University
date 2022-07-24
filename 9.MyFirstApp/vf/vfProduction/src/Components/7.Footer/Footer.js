import {Link} from "react-router-dom";

import styles from "./Footer.css";

import ThumbImg from './ThumbImg';

export default function Footer() {
    const thumbs = [
        {_id: 1, to: '/carouselItem4', src: 'images/thumbs/sunset.jpg', alt: 'thumbImg1'},
        {_id: 2, to: '/carouselItem1', src: 'images/thumbs/ЛедниДрон.jpg', alt: 'thumbImg2'},
        {_id: 3, to: '/carouselItem2', src: 'images/thumbs/landsc.jpg', alt: 'thumbImg3'},
        {_id: 4, to: '/carouselItem3', src: 'images/thumbs/Tower.png', alt: 'thumbImg4'},
        {_id: 5, to: '/carouselItem4', src: 'images/thumbs/sunset.jpg', alt: 'thumbImg1'},
        {_id: 6, to: '/carouselItem1', src: 'images/thumbs/ЛедниДрон.jpg', alt: 'thumbImg2'},
      ];

    return (
    <>
    <footer>
        <section className="footer-top">
            <div className="container">
                <h3>Скали, Пещери, Висоти, Катерене, Забавления, Приключения ...</h3>
                <div className="row text-center text-lg-left">
                    
                    {thumbs.map(t => <ThumbImg key={t._id} {...t}/>)}

                </div>
            </div>
        </section>

        {/* finalFootCaptions */}
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