import React, { useState } from 'react';
import LoginButton from './LoginButton';
import Authentication from './Authentication/Authentication';
import './App.css';

function App() {
  const [openLogin, setOpenLogin] = useState(false);

  const handleLogin = () => {
    setOpenLogin(true);
  };

  return (
    <div className="App">
      <header className="App-header">
        <h1 className='title'>Guardian</h1>
        <div className='App-login-button'><LoginButton onClick={handleLogin} /></div>
      </header>
      <Authentication open={openLogin} onClose={() => setOpenLogin(false)} />
      <div className='grid-container'>
        <p className='item1'> Section 1</p>
        <p className='item2'> Section 2</p>
      </div>
    </div>
  );
}

export default App;
