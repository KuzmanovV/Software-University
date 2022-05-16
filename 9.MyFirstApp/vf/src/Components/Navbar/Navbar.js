export default function Navbar() {
    return (
        <nav class="navbar navbar-expand-lg navbar-dark cyan fixed-top">
        <div class="container">
            <a class="navbar-brand" href="index.html">
                <img src="images/nav-logo.png" alt="nav-logo" />
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent-4" aria-controls="navbarSupportedContent-4" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent-4">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="index.html">Home <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="about.html">About</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="gallery.html">gallery </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="blog.html">Read my blog </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="contact.html">contact </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    )
}