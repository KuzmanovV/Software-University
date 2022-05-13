import { Routes, Route } from 'react-router-dom';
import { useState, useEffect } from 'react-router-dom';

import * as authService from './services/authService'
import Dashbord from './components/Dashbord/Dashbord';
import Header from "./components/Header/Header";
import Login from './components/Login/Login';
import Register from './components/Register/Register';
import MyPets from './components/MyPets/MyPets';
import Create from './components/Create/Create';
import { isAuthenticated } from './services/authService';

function App() {
  const [userInfo, setUserInfo] = useState({isAuthenticated: false, username: ''});
  
  useEffect(() => {
    let user = authService.getUser();

    setUserInfo({
      isAuthenticated: Boolean(user), 
      user,
    })
  }, []);
  
  return (
    <div id="container">
      <Header {...userInfo}/>
      <main id="site-content">
        <Routes>
          <Route path="/" element={<Dashbord /> } />
          <Route path="/login" element={<Login /> } />
          <Route path="/register" element={<Register /> } />
          <Route path="/my-pets" element={<MyPets /> } />
          <Route path="/create" element={<Create /> } />
        </Routes>
      </main>

      <footer id="site-footer">
        <p>@PetMyPet</p>
      </footer>

    </div>
  );
}

export default App;
