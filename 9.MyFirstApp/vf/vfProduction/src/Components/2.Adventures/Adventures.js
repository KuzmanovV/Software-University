import { useEffect} from "react";

import useFetch from '../../hooks/useFetch';

import Adventure from "./Adventure";
import MyAdventure from "./MyAdventure";

export default function Adventures() {
  // AutoGoUp
  useEffect(() => {
    window.scrollTo(0, 0);
  }, []);

  const [adventures] = useFetch('http://localhost:3030/jsonstore/todos', [])
  
  const adventures1 = [
    {
      _id: 1,
      href: 'https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn',
      src: 'images/adventures/ropeGarden/all.jpg',
      alt: 'ropeGardenImg',
      title: 'Въжена градина - веселба за малки и големи...',
      description: 'Висящи елементи с различна степен на сложност, ...',
    },
    {
      _id: 2,
      href: 'https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn',
      src: 'images/adventures/wall/wall.jpg',
      alt: 'wallImg',
      title: 'Стена за катерене',
      description: 'Увеличете височината, подгответе се за истинското изпитание на фератата...',
    },
    {
      _id: 3,
      href: 'https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn',
      src: 'images/adventures/kids/kids.jpg',
      alt: 'kidsSpotImg',
      title: 'Детски кът - веселбата за едни е спокойствие за други :)',
      description: 'Батут, горски боулинг, тролей, ...',
    },
    {
      _id: 4,
      href: 'https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn',
      src: 'images/adventures/celebration/stage1.jpg',
      alt: 'sceneImg',
      title: 'Сцена под небето',
      description: 'зелено училище, концерти, чествания, споделени тържества...',
    },
    {
      _id: 5,
      href: 'https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn',
      src: 'images/adventures/cinema/screen.jpg',
      alt: 'cinemaImg',
      title: 'Лятно кино',
      description: 'Eкран под звездите - прохладен спомен от детството...',
    },
    {
      _id: 6,
      href: 'https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn',
      src: 'images/adventures/stones/stones.jpg',
      alt: 'stonesImg',
      title: 'Спомени от камък и кристали',
      description: 'Aвтентични сувенири и уникални кристални образци...',
    },
    {
      _id: 7,
      href: 'https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn',
      src: 'images/adventures/caves/Lea.jpg',
      alt: 'caveImg',
      title: 'Подземни приключения',
      description: 'Хареса ли ви Съева дупка? Знаете ли още колко богатства и чудеса крият недрата на местния карст...',
    },
    {
      _id: 8,
      href: 'https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn',
      src: 'images/adventures/f&f/beetle.jpg',
      alt: 'faunaImg',
      title: 'Нахранете фотоапарата!',
      description: 'Изследвайте местната флора и фауна...',
    },
    {
      _id: 9,
      href: 'https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn',
      src: 'images/adventures/bavaridges/halvi.jpg',
      alt: 'bavaridgeImg',
      title: 'Лакомства и вкуснотии',
      description: 'Подкрепете се и заредете...',
    },
    {
      _id: 10,
      href: 'https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn',
      src: 'images/adventures/ropeGarden/equip.jpg',
      alt: 'vfImg',
      title: 'VIA FERRATA',
      description: 'Най-якото е в гората...!',
    },
  ];
  
  return (
    <section className="blog-page">
      <div className="container">
        <div className="row">
          
          <div className="col-lg-6 col-md-12 left-side">
            <h2>ВАШИТЕ Приключения!</h2>
            {adventures1.map(c => <Adventure key={c._id} {...c} />)}
          </div>

          <MyAdventure />

        </div>
      </div>
    </section>
  );
}
