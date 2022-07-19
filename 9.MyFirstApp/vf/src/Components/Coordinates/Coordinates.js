import styles from "./Coordinates.css";

export default function Coordinates() {
  return (
      <div class="support">
        <div class="container">
          <h3>координати</h3>
          <h4 className="yellow">43.04771, 24.18350</h4>
          <div class="row">
            <div class="col-sm-12">
              <figure class="figure">
                <img
                  src="/images/GoogleMap.png"
                  class="figure-img img-fluid"
                  alt="googleMapsPict"
                />
              </figure>
            </div>
            <div class="col-sm-12">
              <h5>Паркинг на пещера "Съева Дупка, 5761 Брестница. Тъй като пътят няма директна връзка с магистралата, ако желаете да ни посетите и необходимо да се отклоните през с. Брестница.</h5>
              <h5>За контакт - Жорж Влайков - 088 744 5830.</h5>
            </div>
          </div>
        </div>
      </div>
  );
}
