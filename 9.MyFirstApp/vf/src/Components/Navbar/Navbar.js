import { Link } from "react-router-dom";

export default function Navbar() {
  return (
    <nav class="navbar navbar-expand-lg navbar-dark cyan fixed-top">
      <div class="container">
        <a class="navbar-brand" href="index.html">
          <img src="images/logos/logo5.png" alt="nav-logo" />
        </a>
        <button
          class="navbar-toggler"
          type="button"
          data-toggle="collapse"
          data-target="#navbarSupportedContent-4"
          aria-controls="navbarSupportedContent-4"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent-4">
          <ul class="navbar-nav ml-auto">
            <li class="nav-item active">
              <Link className="nav-link" to="/">
                Ледницата
                <span className="sr-only">(current)</span>
              </Link>
            </li>
            <li class="nav-item">
              <Link className="nav-link" to="/adventures">
                Приключения
              </Link>
            </li>
            <li class="nav-item">
              <Link className="nav-link" to="/album">
                Албум{" "}
              </Link>
            </li>
            <li class="nav-item">
              <Link className="nav-link" to="/contest">
                Конкурс{" "}
              </Link>
            </li>
            <li class="nav-item">
              {/* <a class="nav-link" href="contact.html">Ледничари</a> */}
              <Link className="nav-link" to="/login">
                вход
              </Link>
            </li>
            <li class="nav-item">
              <Link className="nav-link" to="/coordinates">
                Координати
              </Link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
}
