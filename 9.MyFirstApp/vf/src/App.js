import { Routes, Route } from "react-router-dom";

import Album from "./Components/Album/Album";
import Carousel from "./Components/Carousel/Carousel";
import Footer from "./Components/Footer/Footer";
import Adventures from "./Components/Adventures/Adventures";
import Navbar from "./Components/Navbar/Navbar";
import Coordinates from "./Components/Coordinates/Coordinates";
import About from "./Components/About";


function App() {
    return (
        <div>
            <Navbar />
            <Routes>
                <Route>
                    <Route path="/" element={<Carousel />} />
                    <Route path="/album" element={<Album />} />
                    <Route path="/adventures" element={<Adventures />} />
                    <Route path="/about" element={<About />} />
                    <Route path="/coordinates" element={<Coordinates />} />
                </Route>
            </Routes>

            <Footer />

            {/* <a href="javascript:" id="return-to-top"><i class="fa fa-long-arrow-up" aria-hidden="true"></i></a> */}
            
        </div>
    );
}

export default App;
