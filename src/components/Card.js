import React from "react"
import "../styles/Card.css"
export default function Card({
    img,
    btnText
}){
    return(
        <div className="cards">
            <img src={img}/>
            <div>
                <button className="buttons">{btnText}</button>
            </div>
        </div>
    )
}