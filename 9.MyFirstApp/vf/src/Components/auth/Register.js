export default function Login() {
    return(
<div>
{/* Blog-Section */}
<div class="support">
  <div class="container">
   <h3>Вход</h3>
    <div class="row">
        <div class="col-sm-12">
           <figure class="figure">
             <img src="images/support-bg.jpg" class="figure-img img-fluid" alt="A generic square placeholder image with rounded corners in a figure." />
           </figure>
        </div>
        <div class="col-sm-12">
             <p> Моля въведете Вашите <a href="#">Име</a> и <a href="#">Парола</a>, за да получите достъп до пълната функционалност на сайта. Ако нямате регистрация, може да направите <a href="#">тук...</a></p>
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
                  <button type="submit" class="btn btn-primary px-4">вход</button>
              </form>
          </div>
      </div>
     </div>
  </div>
</div>

    {/* Return to Top */}
    <a href="javascript:" id="return-to-top"><i class="fa fa-long-arrow-up" aria-hidden="true"></i></a>

    </div>
    )
}

