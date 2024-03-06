import React from 'react';
import './App.css';

const LoginButton = ({ onClick }) => {
  return (
    <button className='button1' onClick={onClick}>Login</button>
  );
};

export default LoginButton;