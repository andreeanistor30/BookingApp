import "../styles/Body.css"
import "../styles/Card.css"
import mountainImage from "../image/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006 1.png"
import seaImage from "../image/pexels-fabian-wiktor-994605 1.png";
import destinations from "../image/image.jpg";
import cityBreak from "../image/citybreak.jpg";
import Card from '../components/Card';
export default function Body(){
    return (
        <div>
            <input type="search" className="body-destination-input" placeholder="Where are you going?"/>
            <input type="date" className="body-checkin-input" placeholder="Check-in"/>
            <input type="date" className="body-checkout-input" placeholder="Check-out"/>
            <button type="button" className="body-search-button">Search</button>
            <h2 className="destinations">The most popular destinations</h2> 
            <img src={destinations} className="destinations-image"/>
            <h2 className="trip">Choose the perfect trip</h2>
            <div className="card">
            <Card
                 img={mountainImage}
                 btnText="Mountain"
            />
            <Card
                img={seaImage}
                btnText="Sea"
            />
            <Card
                img={cityBreak}
                btnText="City break"
                />
            </div>
        </div>
    )
}