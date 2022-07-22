import { Routes, Route, Link } from "react-router-dom";

import Navbar from "./Components/0.Navbar/Navbar";
import Carousel from "./Components/1.Carousel/Carousel";
import Adventures from "./Components/2.Adventures/Adventures";
import Album from "./Components/3.Album/Album";
import Contest from "./Components/4.Contest/Contest";
import Login from "./Components/5.Auth/Login";
import Register from "./Components/5.Auth/Register";
import Coordinates from "./Components/6.Coordinates/Coordinates";
import NotFound from "./Components/NotFound";
import CarouselItem1 from "./Components/7.Footer/CarouselItem1";
import CarouselItem2 from "./Components/7.Footer/CarouselItem2";
import CarouselItem3 from "./Components/7.Footer/CarouselItem3";
import CarouselItem4 from "./Components/7.Footer/CarouselItem4";
import Footer from "./Components/7.Footer/Footer";


function App() {
    return (
        <div>
            <Navbar />
            
            <Routes>
                <Route>
                    <Route path="/" element={<Carousel />} />
                    <Route path="/adventures" element={<Adventures />} />
                    <Route path="/album" element={<Album />} />
                    <Route path="/contest" element={<Contest />} />
                    <Route path="/login" element={<Login />} />
                    <Route path="/coordinates" element={<Coordinates />} />
                    <Route path="/register" element={<Register />} />
                    <Route path="/carouselItem1" element={<CarouselItem1 />} />
                    <Route path="/carouselItem2" element={<CarouselItem2 />} />
                    <Route path="/carouselItem3" element={<CarouselItem3 />} />
                    <Route path="/carouselItem4" element={<CarouselItem4 />} />
                    <Route path="*" element={<NotFound />} />
                </Route>
            </Routes>

            <Footer />

            {/* <Link to="javascript:" id="return-to-top"><i class="fa fa-long-arrow-up" aria-hidden="true"></i></Link> */}
            
        </div>
    );
}

export default App;
