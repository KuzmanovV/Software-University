import { useEffect } from "react";
import styles from "./Coordinates.css";

export default function Coordinates() {
  
  // AutoGoUp hack
  useEffect(() => {
    window.scrollTo(0, 0);
  }, []);
  
  return (
    <div class="support">
      <div class="container">
        <h3>координати</h3>
        <a
          target="blank"
          href="https://www.google.com/maps/place/%D0%9B%D0%B5%D0%B4%D0%BD%D0%B8%D1%86%D0%B0%D1%82%D0%B0/@43.047662,24.1814468,17z/data=!3m1!4b1!4m5!3m4!1s0x40abb41d5400054d:0x897d4706163a63!8m2!3d43.0476581!4d24.1836355"
        >
          Зареди на Google Карти
        </a>
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
            <h5>
              Паркинг на пещера "Съева Дупка", 5761 Брестница. Тъй като пътят
              няма директна връзка с магистралата, ако желаете да ни посетите и
              необходимо да се отклоните през с. Брестница.
            </h5>
            <h5>За контакт - Жорж Влайков - 088 744 5830.</h5>
            <section className="wd">
              <h6>Работно време</h6>
              <div>пн - Затворено;</div>
              <div>вт - Затворено;</div>
              <div>ср - Отворено 24 часа;</div>
              <div>чт - Отворено 24 часа;</div>
              <div>пт - Отворено 24 часа;</div>
              <div>сб - Отворено 24 часа;</div>
              <div>нд - 0:00 ч. до 20:00 ч.</div>
            </section>
          </div>
          
        </div>
      </div>
    </div>
  );
}
