import Album from "./Components/Album/Album";
import Carousel from "./Components/Carousel/Carousel";
import Footer from "./Components/Footer/Footer";
import Adventures from "./Components/Adventures/Adventures";
import Navbar from "./Components/Navbar/Navbar";

function App() {
    return (
        <div>
            <Navbar />

            <Carousel />

            <Album />

            <Adventures />

            <Footer />

            <a href="javascript:" id="return-to-top"><i class="fa fa-long-arrow-up" aria-hidden="true"></i></a>

        </div>
    );
}

export default App;
