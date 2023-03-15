import React from 'react'
import "../styles/Booking.css"

export default function Booking ({
    img,
    txt,
    town

}){
    return (
        <div>
            <img src={img}/>
            <h2>{txt}</h2>
            <h3>{town}</h3>
        </div>
    )
}