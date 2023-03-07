import axios from "axios"
import {GETALL_URL} from "../utils/UrlConstants"

export default async () => {
    try {
        const response = await axios.get(GETALL_URL,{
        })
        
        return response.data
        
    }
    catch(error){
        return{
        isError : true
        }
    }
}