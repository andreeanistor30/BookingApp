import './App.css';
import MainPage from './pages/MainPage';

import { Routes, Route } from "react-router-dom";
import { BrowserRouter as Router } from "react-router-dom";
import Login from './pages/LoginPage';
import Register from './pages/NewAccountPage';
import ModifiedMainPage from './pages/ModifiedMainPage';
import BookingsPage from './pages/BookingsPage'
import HotelsPage from './pages/HotelsPage'

function App() {
  return (
    <div>
      <Router>
        <Routes>
          <Route exact path='/' element={< MainPage />}></Route>
          <Route exact path='/login' element={< Login />}></Route>
          <Route exact path='/register' element={< Register />}></Route>
          <Route exact path='/mainpage' element={<ModifiedMainPage />}></Route>
          {/* <Route exact path='/bookingspage' element={<BookingsPage />}></Route> */}
          {/* <Route exact path='/hotelspage' element={<HotelsPage />}></Route> */}
        </Routes>
      </Router>
    </div>
  );
}

export default App;
