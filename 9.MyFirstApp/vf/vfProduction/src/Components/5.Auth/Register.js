export default function Register() {
    return(
<div>
{/* Blog-Section */}
<div class="support">
  <div class="container">
   <h3>регистрация</h3>
    <div class="row">
        <div class="col-sm-12">
           {/* <figure class="figure">
             <img src="images/support-bg.jpg" class="figure-img img-fluid" alt="A generic square placeholder image with rounded corners in a figure." />
           </figure> */}
        </div>
        <div class="col-sm-12">
             <p> Моля попълнете формата за регистрация, за да получите достъп до пълната функционалност на сайта. След успешно завършване на регистрацията ще бъдете включени автоматично с вашия нов акаунт.</p>
        </div>
    </div>

     <div class="container py-5 main">
      <div class="row">
          <div class="col-md-12">
              <form>
                  <div class="form-group row">
                      <div class="col-sm-12">
                          <input type="text" class="form-control" placeholder="Име / Прякор" required />
                      </div>
                      <div class="col-sm-6">
                          <input type="password" class="form-control" placeholder="Парола" required />
                      </div>
                          <div class="col-sm-6">
                          <input type="password" class="form-control" placeholder="Същата парола" required />
                      </div>
                      <div class="col-sm-6">
                          <input type="text" class="form-control" placeholder="Населено място" required />
                      </div>
                          <div class="col-sm-6">
                          <input type="number" class="form-control" placeholder="Години" required />
                      </div>
                  </div>
                  {/* <div class="form-group row">
                      <div class="col-sm-12">
                          <textarea type="text" class="form-control" placeholder="your Message" rows="8" required></textarea>
                      </div>
                  </div> */}
                  <button type="submit" class="btn btn-primary px-4">вход</button>
              </form>
          </div>
      </div>
     </div>
  </div>
</div>

    {/* Return to Top */}
    {/* <a href="javascript:" id="return-to-top"><i class="fa fa-long-arrow-up" aria-hidden="true"></i></a> */}

    </div>
    )
}

