import React from "react";
import HotelsApi from "../api/HotelsApi"
import { useEffect} from "react";
import Hotels from "../components/Hotels"
import Booking from "../components/Booking";
export default function HotelsPage({
    filter
}){

    const HotelsPageApi = async () =>{
        const response = await HotelsApi(
            filter
        )
        console.log(response)
        return response;
    }

    useEffect(() => {
        HotelsPageApi()
    }, []);
    const response =HotelsApi(
        filter);
    return (
        <div>
            <Hotels />
            <Booking
            img={response.imagePath}
            txt={response.category}
            town={response.town} />
        </div>
    )
}