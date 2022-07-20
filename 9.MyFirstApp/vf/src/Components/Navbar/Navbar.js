import { Link, NavLink } from "react-router-dom";
import styles from "./Navbar.css";

export default function Navbar() {
  const setNavStyle = ({isActive}) => {
    return isActive
    ? styles['active']
    :undefined;
  }
  
  return (
    <nav className="navbar navbar-expand-lg navbar-dark cyan fixed-top">
      <div className="container">
        <Link className="navbar-brand" to="/home">
          <img src="images/logos/logo6.png" alt="nav-logo"/>
        </Link>
        
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent-4" aria-controls="navbarSupportedContent-4" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

        <div className="collapse navbar-collapse" id="navbarSupportedContent-4">
          <ul className="navbar-nav ml-auto">
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/home">
                Ледницата
                <span className="sr-only">(current)</span>
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/adventures">
                Приключения
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/album">
                Албум
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/contest">
                Конкурс
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/login">
                вход
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/coordinates">
                Координати
              </NavLink>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
}
