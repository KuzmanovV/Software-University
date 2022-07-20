import { Routes, Route, Link } from "react-router-dom";

import Navbar from "./Components/navbar/Navbar";
import Carousel from "./Components/carousel/Carousel";
import Adventures from "./Components/adventures/Adventures";
import Album from "./Components/album/Album";
import Contest from "./Components/contest/Contest";
import Login from "./Components/auth/Login";
import Register from "./Components/auth/Register";
import Coordinates from "./Components/coordinates/Coordinates";
import NotFound from "./Components/NotFound";
import CarouselItem1 from "./Components/carousel/CarouselItem1";
import CarouselItem2 from "./Components/carousel/CarouselItem2";
import CarouselItem3 from "./Components/carousel/CarouselItem3";
import CarouselItem4 from "./Components/carousel/CarouselItem4";
import Footer from "./Components/footer/Footer";


function App() {
    return (
        <div>
            <Navbar />
            
            <Routes>
                <Route>
                    <Route path="/home" element={<Carousel />} />
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
