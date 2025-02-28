// src/about.js
import React, { useState } from 'react';
import Menu from './menu';
import Footer from './footer';

function About() {
  const [count, setCount] = useState(0);

  return (
    <div>
      {/* Include the menu */}
      <Menu />

        <div data-testid="about-content" style={{ padding: '20px' }}>
        <h1>About Us</h1>
        <p>
          At ABC Automobiles, we are committed to providing the best vehicles and services.
          Our legacy and innovation drive us forward.
        </p>

        {/* Counter Section */}
        <div style={{ marginTop: '20px' }}>
          {/* Render only the numeric value so that subtraction works */}
          <h2 data-testid="counter">{count}</h2>
          <button
            data-testid="counterPlus"
            onClick={() => setCount(count + 1)}
            style={{ marginRight: '10px', padding: '5px 10px' }}
          >
            +
          </button>
          <button
            data-testid="counterMinus"
            onClick={() => setCount(count - 1)}
            style={{ padding: '5px 10px' }}
          >
            -
          </button>
        </div>
      </div>

      {/* Include the footer */}
      <Footer />
    </div>
  );
}

export default About;


// src/App.js
import logo from './logo.svg';
import './App.css';
import Menu from './menu';
import Footer from './footer';

function App() {
  return (
    <div className="App">
      {/* Include menu */}
      <Menu />

      <div className="content">
        <h2>Welcome to ABC Automobiles</h2>
      </div>

      {/* Include footer */}
      <Footer />
    </div>
  );
}

export default App;



// src/menu.js
import React from 'react';
import { Link } from 'react-router-dom';
import logo from './logo.svg';

function Menu() {
  return (
    <nav
      className="menu"
      style={{
        background: '#282c34',
        padding: '10px',
        display: 'flex',
        alignItems: 'center'
      }}
    >
      <img
        src={logo}
        alt="ABC Automobiles Logo"
        style={{ width: '40px', height: '40px', marginRight: '10px' }}
      />
      <Link
        to="/"
        style={{ color: '#fff', textDecoration: 'none', marginRight: '15px' }}
      >
        Home
      </Link>
      <Link
        to="/about"
        style={{ color: '#fff', textDecoration: 'none' }}
      >
        About
      </Link>
    </nav>
  );
}

export default Menu;


// src/footer.js
import React from 'react';

function Footer() {
  return (
    <footer
      style={{
        background: '#f1f1f1',
        padding: '10px',
        textAlign: 'center',
        marginTop: '20px'
      }}
    >
      <p>&copy; 2025 ABC Automobiles. All rights reserved.</p>
    </footer>
  );
}

export default Footer;


// src/index.js
import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import About from './about';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Routes, Route } from 'react-router-dom';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<App />} />
        <Route path="/about" element={<About />} />
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);

reportWebVitals();



/* src/App.css */
.App {
  text-align: center;
  font-family: Arial, sans-serif;
}

.content {
  padding: 20px;
}


/* src/index.css */
body {
  margin: 0;
  padding: 0;
  background-color: #ffffff;
}


// src/reportWebVitals.js
const reportWebVitals = onPerfEntry => {
  if (onPerfEntry && onPerfEntry instanceof Function) {
    import('web-vitals').then(({ getCLS, getFID, getFCP, getLCP, getTTFB }) => {
      getCLS(onPerfEntry);
      getFID(onPerfEntry);
      getFCP(onPerfEntry);
      getLCP(onPerfEntry);
      getTTFB(onPerfEntry);
    });
  }
};

export default reportWebVitals;