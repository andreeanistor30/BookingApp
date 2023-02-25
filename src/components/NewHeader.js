import "../styles/NewHeader.css"
import user from "../image/user.png";
import { useNavigate } from "react-router-dom"





export default function NewHeader(){
const navigate = useNavigate();

const logout = () => {
    localStorage.clear();
    navigate("/");
}

    return (
        <div className="header">
            <div className="div_button">
                <img src={user} className="user-photo" />
                <div className="div-firstname">{(JSON.parse(localStorage.getItem("user"))).firstName}</div>
                <button type="button" className="header-logout-button" onClick={logout}>Log out</button> 
            </div>
            <h1 className="textOnPhoto">Find the best deals</h1> 
            <h3 className="subTextOnPhoto">for your next trip</h3>
             
        </div>
    )
}