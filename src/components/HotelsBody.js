import React from "react"
import "../styles/HotelsBody.css"
export default function HotelsBody(){
    return (
        <div className="searchBar">
            <h1 className="search-text">Search</h1>
            <h3>Destination</h3>
            <input className="search-input" />
            <h3>Check-in</h3>
            <input className="search-input" />
            <h3>Check-out</h3>
            <input className="search-input" />
            <button className="search-button">Search</button>
        </div>
    )
}