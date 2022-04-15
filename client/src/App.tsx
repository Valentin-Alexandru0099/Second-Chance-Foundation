import './App.css';
import { Route, Switch } from "react-router-dom";
import Homepage from './pages/homepage/Homepage';
import Navbar from './components/Navbar/Navbar';
import Footer from './components/Footer/Footer';
import About from './pages/about/About';
import Contact from './pages/contact/Contact';

export default function App() {
  return (
    <div className="App">
      <Navbar/>
       <Switch>
        <Route exact path='/' component={Homepage}></Route>
        <Route exact path='/contact' component={Contact}></Route>
        <Route exact path='/about' component={About}></Route>
        </Switch>
      <Footer/>
        
    </div>
  );
}

// export default App;