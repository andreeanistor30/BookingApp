import react from "react"
import image from "../image/mykonianplatinumvilla02 1.png"
import { useNavigate } from 'react-router-dom'
import "../styles/Header.css"

export default function Header(){

    const navigate = useNavigate();

    const onClickLogin = () => {
        navigate('/login')
    }

    const OnClickRegister = () => {
        navigate('/register')
    }

    return (
        <div className="header">
            <div className="div_button">
                <button type="button" className="header-login-button" onClick={onClickLogin}>Log in</button>
                <button type="button" className="header-register-button" onClick={OnClickRegister}>Create a new account</button> 
            </div>
            <h1 className="textOnPhoto">Find the best deals</h1> 
            <h3 className="subTextOnPhoto">for your next trip</h3>
             
        </div>
    )
}