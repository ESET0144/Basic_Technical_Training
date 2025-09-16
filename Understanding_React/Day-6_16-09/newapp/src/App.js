
import { useState } from 'react';
import './App.css';




function App() {
  const ContainerStyle = {
    display: "flex",
    justifyContent: "center",
    alignItems: "center"
  }

  const [counter, setCounter]= useState(0);

  const buttonHandler1 = () => {
    setCounter(counter+1)
  }
 
   const buttonHandler2 = () => {
    setCounter(counter-1)
  }
  return (
    <div className= "Container">
      <p style={{ContainerStyle}}> {counter}</p>

    <button onClick={buttonHandler1}> increment </button>
    <button onClick={buttonHandler2}> decrement </button>
    </div>
  );
    
}

export default App;
