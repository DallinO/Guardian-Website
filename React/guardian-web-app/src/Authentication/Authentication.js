import React, { useState } from 'react';
import Login from './Login';
import Register from './Registration';
import './Authentication.css';
import 'C:/Users/Olson/Documents/GitHub/Guardian-Web-App/React/guardian-web-app/src/App.css';

const Authentication = ({ open, onClose }) => {
    const [showRegister, setShowRegister] = useState(false);

    const onRegisterClose = () => {
        setShowRegister(false);
        onClose();
    };

    const onCloseButton = () => {
        setShowRegister(false);
        onClose();
    }

    const onCreateAccount = () => {
        setShowRegister(true);
    }

    if (!open) return null;

    if (showRegister) {
        return (
            <Register open={showRegister} onClose={onRegisterClose} />
        );
    }
    else {
        return (
            <Login open={true} onClose={onCloseButton} createAccount={onCreateAccount} />
        );
    }
};

export default Authentication