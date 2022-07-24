import { useEffect } from "react";

export default function Contest() {
  // AutoGoUp hack
  useEffect(() => {
    window.scrollTo(0, 0);
  }, []);
  
  return (
      <div class="support">
        <div class="container">
          <h3>конкурс</h3>
          <div class="row">
            <div class="col-sm-12">
              <figure class="figure">
                <img
                  src="images/contest/centralContest.jpg"
                  class="figure-img img-fluid"
                  alt="contestPict"
                />
              </figure>
            </div>
            <div class="col-sm-12">
              <p>
                Катерете, снимайте, участвайте! Лесно е - направете регистрация и публикувайте вашата най-яка снимка. Съберете най-много от лайковете на другите фенове и спечелете безплатен ден в парка. Всеки участник също печели 5% отстъпка от цената на всички забавления за ден в парк Ледницата.
              </p>
              <p>
                Моля въведете Вашите <a href="#">Име</a> и
                <a href="#">Парола</a>, за да получите достъп до пълната
                функционалност на сайта. Ако нямате регистрация, може да
                направите <a href="#">тук...</a>
              </p>
            </div>
          </div>

          <div class="container py-5 main">
            <div class="row">
              <div class="col-md-12">
                <form>
                  <div class="form-group row">
                    <div class="col-sm-6">
                      <input
                        type="text"
                        class="form-control"
                        placeholder="Име"
                        required
                      />
                    </div>
                    <div class="col-sm-6">
                      <input
                        type="password"
                        class="form-control"
                        placeholder="Парола"
                        required
                      />
                    </div>
                  </div>
                  <button type="submit" class="btn btn-primary px-4">
                    вход
                  </button>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
  );
}
