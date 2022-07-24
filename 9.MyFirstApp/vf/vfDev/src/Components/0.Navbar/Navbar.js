import { Link, NavLink } from "react-router-dom";
import styles from "./Navbar.css";
import { useEffect } from "react";

export default function Navbar() {
  const setNavStyle = ({isActive}) => {
    return isActive
    ? styles['active']
    :undefined;
  }

  // AutoGoUp hack
  useEffect(() => {
    window.scrollTo(0, 0);
  }, []);

  const openMobileBridge = 'false';

  const toCollapsBridge=() => {
    openMobileBridge = 'true';
  }
  
  return (
    <nav className="navbar navbar-expand-lg navbar-dark cyan fixed-top">
      <div className="container">
        <Link className="navbar-brand" to="/">
            <img src="images/logos/scrL.png" alt="nav-logo"/>
          {/* <div className="logo">
            <img src="images/logos/scrL.png" alt="nav-logo"/>
          </div> */}
        </Link>
        
        <button class="navbar-toggler" type="button" 
                data-toggle="collapse" data-target="#navbarSupportedContent-4" 
                aria-controls="navbarSupportedContent-4" 
                aria-expanded={openMobileBridge} 
                aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

        <div className="collapse navbar-collapse" id="navbarSupportedContent-4">
          <ul className="navbar-nav ml-auto">
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/" onClick={toCollapsBridge}>
                Ледницата
                <span className="sr-only">(current)</span>
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/adventures" onClick={toCollapsBridge}>
                Приключения
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/album" onClick={toCollapsBridge}>
                Албум
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/contest" onClick={toCollapsBridge}>
                Конкурс
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/login" onClick={toCollapsBridge}>
                вход
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link setNavStyle" to="/coordinates" onClick={toCollapsBridge}>
                Координати
              </NavLink>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
}
