import React from "react"
import "../styles/HotelsBody.css"
import destinations from "../image/search.png"
import calendar from "../image/calendar.png"
export default function HotelsBody(){
    return (
        <div className="searchBar">
            
            <h1 className="search-text">Search</h1>
            <h3>Destination</h3>
            <div className="destination-div">
            <img src={destinations} className="destination-image"/>
            <input className="search-input" /> 
            </div>
            <h3>Check-in</h3>
            <div className="calendar-div">
            <img src={calendar} className="calendar" />
            <input className="search-input" />
            </div>
            <h3>Check-out</h3>
            <img src={calendar} className="calendar" />
            <input className="search-input" />
            <button className="search-button">Search</button>
        </div>
    )
}