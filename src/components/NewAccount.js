import "../styles/NewAccount.css"
import image from "../image/user.png" 
import account_icon from "../image/account.png"
import new_user from "../image/new-user.png"
import {useState} from "react"
import RegisterApi from "../api/RegisterApi"
const NewAccount = () => {
    const [formData, setFormData] = useState({
        firstname: "",
        lastname: "",
        country: "",
        adress: "",
        email: "",
        username: "",
        password: ""
})

const handleFormData = (event) => {
    const { name, value } = event.target
    setFormData(prevFormData => {
        return {
            ...prevFormData,
            [name]: value
        }
    })
}

const registerFunction = async () => {
    const response = await RegisterApi(
        formData.firstname,
        formData.lastname,
        formData.country,
        formData.adress,
        formData.email,
        formData.username,
        formData.password
    )
    if (response.isError)
        console.log('No')
    else
        console.log("Yes")
}

    return (
        <div className="newAccount">
            <img src={new_user} className="newUser"/>
            <input name ="firstname" type="search" className="firstname" placeholder="Firstname" onChange={handleFormData}/>
            <input name ="lastname" type="search" className="lastname" placeholder="Lastname" onChange={handleFormData}/>
            <input name ="country" type="search" className="country" placeholder="Country" onChange={handleFormData}/>
            <input name ="adress" type="search" className="adress" placeholder="Adress" onChange={handleFormData}/>
            <input name ="email" type="email" className="email" placeholder="Email" onChange={handleFormData}/>
            <input name ="username" type="search" className="username" placeholder="Username" onChange={handleFormData}/>
            <input name ="password" type="password" className="password" placeholder="Password" onChange={handleFormData}/>
            <button className="confirm-button" onClick={registerFunction}>Confirm</button>
        </div>
    )
}
export default NewAccount