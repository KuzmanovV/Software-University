import { useEffect, useState} from "react";
import Adventure from "./Adventure";
import MyAdventure from "./MyAdventure";

export default function Adventures() {
  // AutoGoUp
  useEffect(() => {
    window.scrollTo(0, 0);
  }, []);

  const[adventures, setAdventures] = useState([
    {
      _id: 1,
      src: 'images/adventures/ropeGarden/all.jpg',
      alt: 'ropeGardenImg',
      title: 'Въжена градина - веселба за малки и големи...',
      description: 'Висящи елементи с различна степен на сложност, ...',
    },
    {
      _id: 1,
      src: 'images/adventures/wall/wall.jpg',
      alt: 'wallImg',
      title: 'Стена за катерене',
      description: 'Увеличете височината, подгответе се за истинското изпитание на фератата...',
    },
    {
      _id: 1,
      src: 'images/adventures/kids/kids.jpg',
      alt: 'kidsSpotImg',
      title: 'Детски кът - веселбата за едни е спокойствие за други :)',
      description: 'Батут, горски боулинг, тролей, ...',
    },
    {
      _id: 1,
      src: 'images/adventures/celebration/stage1.jpg',
      alt: 'sceneImg',
      title: 'Сцена под небето',
      description: 'зелено училище, концерти, чествания, споделени тържества...',
    },
    {
      _id: 1,
      src: 'images/adventures/cinema/screen.jpg',
      alt: 'cinemaImg',
      title: 'Лятно кино',
      description: 'Eкран под звездите - прохладен спомен от детството...',
    },
    {
      _id: 1,
      src: 'images/adventures/stones/stones.jpg',
      alt: 'stonesImg',
      title: 'Спомени от камък и кристали',
      description: 'Aвтентични сувенири и уникални кристални образци...',
    },
    {
      _id: 1,
      src: 'images/adventures/caves/Lea.jpg',
      alt: 'caveImg',
      title: 'Подземни приключения',
      description: 'Хареса ли ви Съева дупка? Знаете ли още колко богатства и чудеса крият недрата на местния карст...',
    },
    {
      _id: 1,
      src: 'images/adventures/f&f/beetle.jpg',
      alt: 'faunaImg',
      title: 'Нахранете фотоапарата!',
      description: 'Изследвайте местната флора и фауна...',
    },
    {
      _id: 1,
      src: 'images/adventures/bavaridges/halvi.jpg',
      alt: 'bavaridgeImg',
      title: 'Лакомства и вкуснотии',
      description: 'Подкрепете се и заредете...',
    },
    {
      _id: 1,
      src: 'images/adventures/ropeGarden/equip.jpg',
      alt: 'vfImg',
      title: 'VIA FERRATA',
      description: 'Най-якото е в гората...!',
    },
  ]);
  
  return (
    <section className="blog-page">
      <div className="container">
        <div className="row">
          
          <div className="col-lg-6 col-md-12 left-side">
            <h2>ВАШИТЕ Приключения!</h2>
            {adventures.map(c => <Adventure key={c._id} {...c} />)}
          </div>

          <MyAdventure />

        </div>
      </div>
    </section>
  );
}
