import { Routes, Route, Link } from "react-router-dom";

import Album from "./Components/album/Album";
import Carousel from "./Components/carousel/Carousel";
import Footer from "./Components/footer/Footer";
import Adventures from "./Components/adventures/Adventures";
import Navbar from "./Components/navbar/Navbar";
import Coordinates from "./Components/coordinates/Coordinates";
import Login from "./Components/auth/Login";
import NotFound from "./Components/NotFound";


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
                    <Route path="*" element={<NotFound />} />
                </Route>
            </Routes>

            <Footer />

            {/* <Link to="javascript:" id="return-to-top"><i class="fa fa-long-arrow-up" aria-hidden="true"></i></Link> */}
            
        </div>
    );
}

export default App;
