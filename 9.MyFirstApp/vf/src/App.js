import { Routes, Route } from "react-router-dom";

import Album from "./Components/album/Album";
import Carousel from "./Components/carousel/Carousel";
import Footer from "./Components/footer/Footer";
import Adventures from "./Components/adventures/Adventures";
import Navbar from "./Components/navbar/Navbar";
import Coordinates from "./Components/coordinates/Coordinates";
import Login from "./Components/auth/Login";


function App() {
    return (
        <div>
            <Navbar />
            <Routes>
                <Route>
                    <Route path="/" element={<Carousel />} />
                    <Route path="/album" element={<Album />} />
                    <Route path="/adventures" element={<Adventures />} />
                    <Route path="/login" element={<Login />} />
                    <Route path="/coordinates" element={<Coordinates />} />
                </Route>
            </Routes>

            <Footer />

            <a href="javascript:" id="return-to-top"><i class="fa fa-long-arrow-up" aria-hidden="true"></i></a>
            
        </div>
    );
}

export default App;
