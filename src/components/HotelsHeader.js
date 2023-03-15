import React from "react"
import "../styles/HotelsHeader.css"
import { useNavigate } from "react-router-dom"
export default function HotelsHeader () {

    const navigate = useNavigate();

    const onClickLogin = () => {
        navigate('/login')
    }

    const OnClickRegister = () => {
        navigate('/register')
    }
    return (
        <div>
        <div className="border">
            <button type="button" className="header-login-button" onClick={onClickLogin}>Log in</button>
            <button type="button" className="header-register-button" onClick={OnClickRegister}>Create a new account</button> 
        </div>
        </div>
    )
}