export default function About() {
    return(
<div>
    {/* <!--Navbar --> */}
    <nav class="navbar navbar-expand-lg navbar-dark cyan fixed-top">
        <div class="container">
            <a class="navbar-brand" href="index.html">
            <img src="images/nav-logo.png" alt="nav-logo" />
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent-4" aria-controls="navbarSupportedContent-4" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent-4">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="index.html">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="about.html">About</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="gallery.html">gallery </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="blog.html">Read my blog </a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="contact.html">contact <span class="sr-only">(current)</span></a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    {/* <!--/.Navbar -->
    <!-- Blog-Section --> */}
<div class="support">
  <div class="container">
   <h3>Contact Us</h3>
    <div class="row">
        <div class="col-sm-12">
           <figure class="figure">
             <img src="images/support-bg.jpg" class="figure-img img-fluid" alt="A generic square placeholder image with rounded corners in a figure." />
           </figure>
        </div>
        <div class="col-sm-12">
             <p>Welcome to my <a href="#">personal travel</a> blog, i love to travel the globe, i have been to so many beautiful places and met interesting people  the world, this website is my mirror of life. 
Welcome to my personal travel blog, i love to travel the globe, i have been to so many beautiful Welcome to my personal travel blog, i love to travel the globe, i have been to so many beautiful places and met interes Welcome to my personal travel blog, i love to travel the globe, i have been to so many beautiful places and met interesting people around the world, this website is my mirror of life. </p>
        </div>
    </div>

     <div class="container py-5 main">
      <div class="row">
          <div class="col-md-12">
              <form>
                  <div class="form-group row">
                      <div class="col-sm-6">
                          <input type="text" class="form-control" placeholder="Your Name" required />
                      </div>
                          <div class="col-sm-6">
                          <input type="text" class="form-control" placeholder="Your Email id" required />
                      </div>
                      <div class="col-sm-12">
                          <input type="number" class="form-control" placeholder="Your Phone Number" required />
                      </div>
                  </div>
                  <div class="form-group row">
                      <div class="col-sm-12">
                          <textarea type="text" class="form-control" placeholder="your Message" rows="8" required></textarea>
                      </div>
                  </div>
                  <button type="submit" class="btn btn-primary px-4">Alright Submit it</button>
              </form>
          </div>
      </div>
     </div>
  </div>
</div>
{/* <!-- Support section Ended -->
    <!--/.Portfolio-Section -->
    <!-- Footer --> */}
    <footer>
        <section class="footer-top">
            {/* <!--Container--> */}
            <div class="container">
                <h2>My Flickr Feed</h2>
                <div class="row text-center text-lg-left">
                    <div class="col-lg-2 col-md-4 col-xs-6">
                        <a href="#" class="d-block h-100"><img class="img-fluid img-thumbnail" src="images/banner-image-1.jpg" alt="" /></a>
                    </div>
                    <div class="col-lg-2 col-md-4 col-xs-6">
                        <a href="#" class="d-block h-100"><img class="img-fluid img-thumbnail" src="images/banner-image-2.jpg" alt="" /></a>
                    </div>
                    <div class="col-lg-2 col-md-4 col-xs-6">
                        <a href="#" class="d-block h-100"><img class="img-fluid img-thumbnail" src="images/banner-image-3.jpg" alt="" /></a>
                    </div>
                    <div class="col-lg-2 col-md-4 col-xs-6">
                        <a href="#" class="d-block h-100"><img class="img-fluid img-thumbnail" src="images/banner-image-4.jpg" alt="" /></a>
                    </div>
                    <div class="col-lg-2 col-md-4 col-xs-6">
                        <a href="#" class="d-block h-100"><img class="img-fluid img-thumbnail" src="images/banner-image-2.jpg" alt="" /></a>
                    </div>
                    <div class="col-lg-2 col-md-4 col-xs-6">
                        <a href="#" class="d-block h-100"><img class="img-fluid img-thumbnail" src="images/banner-image-1.jpg" alt="" /></a>
                    </div>
                </div>

            </div>
            {/* <!-- /.container --> */}
        </section>
        <section class="footer-bottom">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <ul>
                            <li><a href="index.html">Home</a></li>
                            <li class="hidden">/</li>
                            <li><a href="about.html">About-us</a></li>
                            <li class="hidden">/</li>
                            <li><a href="mystories.html">My stories</a></li>
                            <li class="hidden">/</li>
                            <li><a href="destinations.html">Destinations</a></li>
                            <li class="hidden">/</li>
                            <li><a href="gallery.html">Gallery</a></li>
                            <li class="hidden">/</li>
                            <li><a href="contact.html">Contact</a></li>
                        </ul>
                    </div>
                    <div class="col-md-12">
                        <p>(C) All Rights Reserved <a href="https://www.template.net/editable/websites/html5" target="_blank">ClickaHolic</a> <span>/</span> Designed and Developed by <a href="https://www.template.net/editable/websites/html5" target="_blank">Template.net</a></p>
                    </div>
                </div>
            </div>
            {/* <!-- /.container --> */}
        </section>
    </footer>
    {/* <!-- /.Footer -->
    <!-- Return to Top --> */}
    <a href="javascript:" id="return-to-top"><i class="fa fa-long-arrow-up" aria-hidden="true"></i></a>

    </div>
    )
}

