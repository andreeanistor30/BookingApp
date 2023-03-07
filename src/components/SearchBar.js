import React from "react"
import '../styles/Body.css'
export default function SearchBar({placeholder,data}){
    console.log(data);
    return (
        <div className="search-bar-div" >
            <input type="search" placeholder = {placeholder} className="searchInputs"/>

        {/* {data.map((value, key) => {
            return (
                <a className="dataItem" key={key} >
                <p>{value.Town}</p>
                </a>
            );
        })} */}
        </div>
    );
    }