import { useState } from 'react';

import Header from "./components/Header";
import WelcomeWorld from "./components/WelcomeWorld";
import GameCatalog from "./components/GameCatalog/GameCatalog";
import CreateGame from "./components/CreateGame";
import Login from "./components/Login";
import Register from "./components/Register";
import ErrorPage from './components/ErrorPage';

function App() {
  const [page, setPage] = useState('/home');
  
  const navigationChangeHandler = (path) => {
    setPage(path);
  }

  const routes = {
    '/home': <WelcomeWorld />,
    '/games': <GameCatalog navigationChangeHandler={navigationChangeHandler} />,
    '/create-game': <CreateGame />,
    '/login': <Login />,
    '/register': <Register />,
    '/details'
  }

  return (
    <div id="box">

      <Header 
        navigationChangeHandler={navigationChangeHandler}
      />

      <main id="main-content">
        { routes[page] || <ErrorPage>Some additional info...</ErrorPage> }
      </main>

    </div>
  );
}

export default App;
