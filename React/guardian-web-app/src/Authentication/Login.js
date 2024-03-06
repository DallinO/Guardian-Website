import React from 'react';
import './Authentication.css';
import 'C:/Users/Olson/Documents/GitHub/Guardian-Web-App/React/guardian-web-app/src/App.css';

const Login = ({ open, onClose, createAccount }) => {

    if (!open) return null
    return (
        <div className='overlay'>
            <div className='modal'>
                <div className='modal-content'>
                    <div className='modal-header'>
                        <p className='spacer'></p>
                        <h1 className='modal-title'> Login </h1>
                        <div className='close-button-container'>
                            <button onClick={onClose} className='button1 close-button'> Back </button>
                        </div>
                    </div>
                    <div className='modal-body'>
                        <div class="Wrapper">
                            <div class="Input">
                                <input type="text" id="input" class="Input-text" placeholder="Username or Email"></input>
                                <label for="input" class="Input-label">First name</label>
                            </div>
                        </div>
                        <div class="Wrapper">
                            <div class="Input">
                                <input type="text" id="input" class="Input-text" placeholder="Password"></input>
                                <label for="input" class="Input-label">First name</label>
                            </div>
                        </div>
                        <div className='submit-button-container'>
                            <button className='button1'> Submit </button>
                        </div>
                        <div className='submit-button-container'>
                            <button className='button2' onClick={createAccount}> Create Account </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Login