import React from "react";
import HotelsApi from "../api/HotelsApi"
import { useEffect} from "react";
import Hotels from "../components/Hotels"
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
    return (
        <div>
            <Hotels />
        </div>
    )
}