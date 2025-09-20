import React, { useState } from 'react'

export default function ParentComponent() {

    const [count, setCount] = useState(0);
  return (
    <div>
        <Sibling1 count = {count}/>
        <Sibling2 setCount = {setCount}/>

    </div>
  )
}

function Sibling1(props){

        return (
            <div>
                {props.count}
            </div>
        )

}

function Sibling2({setCount}){       /* Both the ways we can pass the props */
        const incrementHandler = () => {
            setCount(prev => prev+1)
        }

        const decrementHandler = () => {
            setCount(prev => prev-1)
        }
        
        return (
            <div>
            <button onClick={incrementHandler}> Increment </button>
            <button onClick={decrementHandler}> Decrement </button>
            </div>
        )

}

