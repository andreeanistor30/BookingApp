import axios from "axios"
import {REGISTER_URL} from "../utils/UrlConstants"
export default async (firstname, lastname, country, adress, email, username, password) => {
    try{
        console.log(email)
        const response = await axios.post(REGISTER_URL,{
            firstname: firstname,
            lastname: lastname,
            country: country,
            adress: adress,
            email: email,
            username: username,
            password: password
        })
        return response.data
    }catch(error){
        return {
            isError: true
        }
    }
}