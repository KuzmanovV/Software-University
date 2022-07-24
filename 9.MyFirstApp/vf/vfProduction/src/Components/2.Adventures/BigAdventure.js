import { useEffect} from "react";
import Adventure from "./Adventure";
import MyAdventure from "./MyAdventure";

export default function BigAdventure() {
  // AutoGoUp
  useEffect(() => {
    window.scrollTo(0, 0);
  }, []);

    return (
    <section className="blog-page">
      <div className="container">
        <div className="row">
          
          <div className="col-lg-6 col-md-12 left-side">
            <h2>Via Ferrata ЛЕДНИЦАТА</h2>
            {adventures.map(c => <Adventure key={c._id} {...c} />)}
          </div>

          <MyAdventure />

        </div>
      </div>
    </section>
  );
}
