import { Routes, Route } from "react-router-dom";

import Album from "./Components/Album/Album";
import Carousel from "./Components/Carousel/Carousel";
import Footer from "./Components/Footer/Footer";
import Adventures from "./Components/Adventures/Adventures";
import Navbar from "./Components/Navbar/Navbar";
import Coordinates from "./Components/Coordinates/Coordinates";

function App() {
    return (
        <div>
            <Navbar />
            <Routes>
                <Route>
                    <Route path="/" element={<Carousel />} />
                    <Route path="/album" element={<Album />} />
                    <Route path="/adventures" element={<Adventures />} />
                    <Route path="/coordinates" element={<Coordinates />} />
                </Route>
            </Routes>

            <Footer />

            <a href="javascript:" id="return-to-top"><i class="fa fa-long-arrow-up" aria-hidden="true"></i></a>
            
            <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
            <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
            <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
            <script src="https://cdnjs.cloudflare.com/ajax/libs/ekko-lightbox/5.3.0/ekko-lightbox.js"></script>
            <script src="js/animate.js"></script>
            <script src="js/custom.js"></script>
    {/* <script>
        $(document).on('click', '[data-toggle="lightbox"]', function(event) {
            event.preventDefault()
            $(this).ekkoLightbox()
        });
    </script> */}
        </div>
    );
}

export default App;
