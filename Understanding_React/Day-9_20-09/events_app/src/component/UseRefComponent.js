import React, {useRef} from 'react'

export default function () {
  const inputElement = useRef(null);
  const focusHandler = () => {
    inputElement.current.focus();
  }
  
    return (
    <div>Welcome to Useref Hook
        <br/>


        <input ref = {inputElement}/>
        <br/>
        <button onClick={focusHandler}> Focus </button>
    </div>

  )
}
