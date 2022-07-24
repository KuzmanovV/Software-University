import { Routes, Route} from "react-router-dom";

import Carousel from "../1.Carousel/Carousel";
import Adventures from "../2.Adventures/Adventures";
import Album from "../3.Album/Album";
import Contest from "../4.Contest/Contest";
import Login from "../5.Auth/Login";
import Register from "../5.Auth/Register";
import Coordinates from "../6.Coordinates/Coordinates";
import NotFound from "../NotFound";
import CarouselItem1 from "../7.Footer/carouselItems/CarouselItem1";
import CarouselItem2 from "../7.Footer/carouselItems/CarouselItem2";
import CarouselItem3 from "../7.Footer/carouselItems/CarouselItem3";
import CarouselItem4 from "../7.Footer/carouselItems/CarouselItem4";


export default function RouterComp() {
    return (
        <div>
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
        </div>
    );
}