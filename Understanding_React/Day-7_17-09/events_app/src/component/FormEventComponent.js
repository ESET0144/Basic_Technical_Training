import React, { useState } from 'react'


const dummyJson = {
    "firstName":"myFirstName",
    "lastName":"MyLastName",
    "jsonKey":{

    }
}
export default function FormEventComponent() {
    //console.log(dummyJson.firstName)
    //console.log(dummyJson["firstName"])

    const [username, setUsername] = useState("");

    


  const buttonHandler = () => {
    if (username === "Uday" && password === "Uday")
    {
      alert("Good")
    }
    
  };


    const onUsername = (event) => {
        setUsername(event.target.value)
        console.log(username)

    }

    const [password, setPassword] = useState("");

    const onPassword = (event) => {
        setPassword(event.target.value)
        console.log(password)

    }

    
  return (

    <div>
        <input type="text" value={username} placeholder= "enter your username" onChange={onUsername}/>
        <input type="text" value={password} placeholder= "enter your password" onChange={onPassword}/>    
        <button onClick={buttonHandler}>Click me</button>
        
    </div>
  )
}
