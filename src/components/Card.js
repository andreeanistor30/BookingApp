import React from "react"
import "../styles/Card.css"


export default function Card({
    img,
    btnText,
    onClickFunction
}){
    return(
        <div className="cards">
            <img src={img}/>
            <div>
                <button className="buttons" onClick={onClickFunction}>{btnText}</button>
            </div>
        </div>
    )
}