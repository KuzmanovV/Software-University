import { Link, NavLink } from "react-router-dom";
import styles from "./Navbar.module.css";

export default function Navbar() {
  const setNavStyle = ({isActive}) => {
    return isActive
    ? styles['active']
    :undefined;
  }
  
  return (
    <nav className="navbar navbar-expand-lg navbar-dark cyan fixed-top">
      <div className="container">
        <Link className="navbar-brand" to="/">
          <img src="images/logos/logo5.png" alt="nav-logo"/>
        </Link>
        {/* <button
          class="navbar-toggler"
          type="button"
          data-toggle="collapse"
          data-target="#navbarSupportedContent-4"
          aria-controls="navbarSupportedContent-4"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span class="navbar-toggler-icon"></span>
        </button> */}
        <div className="collapse navbar-collapse" id="navbarSupportedContent-4">
          <ul className="navbar-nav ml-auto">
            <li className="nav-item">
              <NavLink className="nav-link {setNavStyle}" to="/">
                Ледницата
                <span className="sr-only">(current)</span>
              </NavLink>
            </li>
            <li class="nav-item">
              <Link className="nav-link" to="/adventures">
                Приключения
              </Link>
            </li>
            <li class="nav-item">
              <Link className="nav-link" to="/album">
                Албум
              </Link>
            </li>
            <li class="nav-item">
              <Link className="nav-link" to="/contest">
                Конкурс
              </Link>
            </li>
            <li class="nav-item">
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
