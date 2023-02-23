import "../styles/NewHeader.css"
import user from "../image/user.png";

export default function NewHeader(){

    return (
        <div className="header">
            <div className="div_button">
                <img src={user} className="user-photo" />
                <button type="button" className="header-logout-button">Log out</button> 
            </div>
            <h1 className="textOnPhoto">Find the best deals</h1> 
            <h3 className="subTextOnPhoto">for your next trip</h3>
             
        </div>
    )
}