import "../styles/Body.css"
import "../styles/Card.css"
import mountainImage from "../image/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006 1.png"
import seaImage from "../image/pexels-fabian-wiktor-994605 1.png";
import destinations from "../image/image.jpg";
import cityBreak from "../image/citybreak.jpg";
import Card from '../components/Card';
import SearchBar from "./SearchBar";
import { useNavigate } from 'react-router-dom'
import HotelsApi from "../api/HotelsApi";
import SearchBarApi from "../api/SearchBarApi";
import { useEffect, useState } from "react";
export default function Body(){

    const navigate = useNavigate();
    
    const [listOfCities, setListOfCities] = useState([]);

    const searchInput = async () => {
        const response = await SearchBarApi();
        setListOfCities(response);
    }

    const onClickLogin = async () => {
        navigate('/bookingspage')
    }

    useEffect(() => {
        searchInput()
    }, []);

    const onClickMountain = () => {
        navigate('/hotelspage/mountain');
    }

    const onClickSea= () => {
        navigate('/hotelspage/sea');
    }

    const onClickCityBreak = () => {
        navigate('/hotelspage/citybreak');
    }

    return (
        <div>
             <SearchBar
                placeholder = "Search a town"
                data = {listOfCities}
            />
            <input type="date" className="body-checkin-input" placeholder="Check-in"/>
            <input type="date" className="body-checkout-input" placeholder="Check-out"/>
            <button type="button" className="body-search-button" onClick={onClickLogin}>Search</button>

            <h2 className="destinations">The most popular destinations</h2> 
            <img src={destinations} className="destinations-image"/>
            <h2 className="trip">Choose the perfect trip</h2>
            <div className="card">
            <Card
                img={mountainImage}
                btnText="Mountain"
                onClickFunction={onClickMountain}
            />
            <Card
                img={seaImage}
                btnText="Sea"
                onClickFunction={onClickSea}
            />
            <Card
                img={cityBreak}
                btnText="City break"
                onClickFunction={onClickCityBreak}
                />
            </div>
        </div>
    )
}