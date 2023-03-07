import axios from "axios"
import { HOTELS_URL } from "../utils/UrlConstants"
export default async (filter) => {
    try{
        const response = await axios.get(HOTELS_URL,{
            filter: filter
        })
        return response.data
    }catch(error){
        return {
            isError: true
        }
    }
}
