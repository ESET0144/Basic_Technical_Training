import React from 'react'
import { useState } from 'react';
 
function LoginFormComponent() {
 
    const [loginState, setloginState] = useState({
        username:"",
        password:""
    });  // hook taking complex datatype (json)
 
    const onUsernameChangeHandler = (e) => {
        setloginState({
            ...loginState,
            username: e.target.value
        })
    }
 
    const onPasswordChangeHandler = (e) => {
        setloginState({
            ...loginState,
            password: e.target.value
        })
    }
 
    const onSubmitHandler = (e) => {
        //e.preventDefault(); // prevents default behaviour of Refreshing - means going to backend
        if(loginState.username !== "Uday"){
            alert("Invalid Username")
        }
        if(loginState.password !== "Uday"){
            alert("Invalid Password")
        }
    }
 
  return (
    <>
        Welcome to the Login Page
        <br />
        <form onSubmit={onSubmitHandler} >
            <input name="Username"type="text" value={loginState.username} onChange={onUsernameChangeHandler} />
            <br />
            <input name="Password" type="password" value={loginState.password} onChange={onPasswordChangeHandler} />
            <br />
            <button type="submit" >Login</button>
            <button type="reset" >reset</button>
        </form>
    </>
  )
}
 
export default LoginFormComponent