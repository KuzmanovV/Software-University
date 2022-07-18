import { Routes, Route, Link } from "react-router-dom";

import Album from "./Components/album/Album";
import Carousel from "./Components/carousel/Carousel";
import Footer from "./Components/footer/Footer";
import Adventures from "./Components/adventures/Adventures";
import Navbar from "./Components/navbar/Navbar";
import Contest from "./Components/contest/Contest";
import Login from "./Components/auth/Login";
import Coordinates from "./Components/coordinates/Coordinates";
import NotFound from "./Components/NotFound";
import CarouselItem1 from "./Components/carousel/CarouselItem1";
import CarouselItem2 from "./Components/carousel/CarouselItem2";
import CarouselItem3 from "./Components/carousel/CarouselItem3";
import CarouselItem4 from "./Components/carousel/CarouselItem4";


function App() {
    return (
        <div>
            <Navbar />
            
            <Routes>
                <Route>
                    <Route path="/" element={<Carousel />} />
                    <Route path="/album" element={<Album />} />
                    <Route path="/adventures" element={<Adventures />} />
                    <Route path="/contest" element={<Contest />} />
                    <Route path="/login" element={<Login />} />
                    <Route path="/coordinates" element={<Coordinates />} />
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
