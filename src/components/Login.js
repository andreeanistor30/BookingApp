import "../styles/Login.css"
import image from "../image/user.png" 
import account_icon from "../image/account.png"
import password_icon from "../image/padlock.png"
import LoginApi from "../api/LoginApi"
import {useState} from "react"
import React from "react"
import { useNavigate } from "react-router-dom"
const Login = () => {
    const [formData, setFormData] = useState({
        username: "",
        password: ""
    })
    const [emptyUsernameError, setEmptyUsernameError] = useState(false);
    const [emptyPasswordError, setEmptyPasswordError] = useState(false);
    const [errorMessage, setErrorMessage] = useState("");

    const handleFormData = (event) => {
        const { name, value } = event.target
        setFormData(prevFormData => {
            return {
                ...prevFormData,
                [name]: value
            }
        })
    }

    const validateFormData = () => {
        setEmptyUsernameError(false);
        setEmptyPasswordError(false);
        setErrorMessage("");
        if(!formData.username && !formData.password){
            setEmptyPasswordError(true);
            setEmptyUsernameError(true);
            setErrorMessage("Username and password are mandatory!");
            return false;
        }
        else if(!formData.username){
            setEmptyPasswordError(true);
            setErrorMessage("Username is mandatory");
            return false;
        }
        return true;
    }

    const loginFunction = async () => {
        if(validateFormData()){
        const response = await LoginApi(
            formData.username,
            formData.password
        )
        
        if (response.isError){
             console.log('No');
             setEmptyPasswordError(true);
             setEmptyUsernameError(true);
             setErrorMessage("Invalid credentials!");
        }
           
        else{
            console.log("Yes");
        }
            
    }
}
    return (
        <div className="login">
            <img src={image} className="icon"/>

            <div className="login-username">
                <img src={account_icon} className="account-icon" />
                <input name='username' type="text" className="login-username-input" placeholder="Username" onChange={handleFormData} emptyFieldError={emptyUsernameError}/>
            </div>

            <div className="login-password">
                <img src={password_icon} className="password-icon" />
                <input name='password' type="password" className="login-password-input" placeholder="Password" onChange={handleFormData} emptyFieldError={emptyUsernameError}/>
            </div>

            <button className="login-button" onClick={loginFunction}>LOGIN</button>
            {errorMessage ? <p className='error-message'>{errorMessage}</p> : <div className='no-error-message'> </div>}
        </div>
    )
}
export default Login