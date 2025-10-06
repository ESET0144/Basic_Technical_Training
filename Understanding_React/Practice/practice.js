// functional compoenent
function Welcome(){
    return <h1> Hello, React! </h1>
}

export default Welcome;

//variable scoping
var name = "react"; //function scoped
let version = 18; //block scoped
const framework = "ReactJS"; // Cannot reassign - for component and props as they don't change

//Arrow function
const greet = () => console.log("Hello React");

// used in functional component and event handlers

const Button = () => <button onClick= {
    () => alert("Clicked")}> Button </button>


//.......Dummy React project//
import React from "react";
import ReactDOM from "react-dom/client";

const Greeting = ({ name }) => <h1>{`Hello, ${name}!`}</h1>;

function App() {
  return (
    <div>
      <Greeting name="uday" />
    </div>
  );
}

const root = ReactDOM.createRoot(document.getElementById("root")); // foundational line
root.render(<App />); // render root
//.......Dummy React project//


//Destruct
const user = {name: "uday", age: 24}
const { name:n, age:a } = user;
//spread
const arr1 = [1, 2];
const arr2 = [...arr1, 3, 4];
//rest operator
function sum(...numbers) {
  return numbers.reduce((a, b) => a + b, 0);
}

const Button1 = (props) => <button {...props}>Click</button>;


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

  const Button3 = ({childern, ...props}) => {
    return (
      <button style = {{padding: "10px 20px"}} {...props}>{childern || "Click"}</button>
    );
  };

  <Button3 onClick = {() => setCount(count+1)}>Increment</Button3>

  function greet(name){
    console.log(`Hello ${name}`);
  }

  greet("Uday");

//Promises:
  fetch('https://api.example.com')
  .then(response => response.json())
  .then(data => console.log(data));

//Async/await
async function fetchData() {
  const response = await fetch('https://api.example.com');
  const data = await response.json();
  console.log(data);
}
fetchData();

const num = [1,2,3];
const dou= num.map(n => n*2);

const items = ["a", "b", "c"]
<div>
  {items.map(item => <li key={item}>{item}</li>)}
</div>

function Mycomponent(){
  const [count, setCount] = useState(0);
  return(
    <button onClick = {()=> setCount(prev=>(prev+1))}>Count {count}</button>;
  );
};

//......useEffect

useEffect(()=>{

  return ()=> {

  };
},[])

import React, { useEffect, useState } from 'react';

function Users() {
  const [users, setUsers] = useState([]);
  useEffect(() => {
    fetch('https://jsonplaceholder.typicode.com/users')
      .then(res => res.json())
      .then(data => setUsers(data));
  }, []);
  
  return <ul>{users.map(u => <li key={u.id}>{u.name}</li>)}</ul>;
}

//.......useRef
const inputRef = useRef(null);
  return (
    <div>
      <input ref={inputRef} />
      <button onClick={() => inputRef.current.focus()}>Focus</button>
    </div>
  )

//......useContext
const ThemeContext = React.createContext();

function App() {
  const [theme] = useState('dark');
  return (
    <ThemeContext.Provider value={theme}>
      <Child />
    </ThemeContext.Provider>
  );
}

function Child() {
  const theme = useContext(ThemeContext);
  return <div>Theme: {theme}</div>;
}

//.....useReducer

const reducer = (state, action) => {

  switch (action.type) {
    case 'inc': return { count: state.count + 1 };
    case 'dec': return { count: state.count - 1 };
    default: return state;
  }
};

function Counter() {
  const [state, dispatch] = useReducer(reducer, { count: 0 });
  return (
    <div>
      <p>{state.count}</p>
      <button onClick={() => dispatch({ type: 'inc' })}>+</button>
      <button onClick={() => dispatch({ type: 'dec' })}>-</button>
    </div>
  );
}

//....useMemo
const expensiveValue = useMemo(() => calculate(num), [num]);

//....useFetch
function useFetch(url) {

  const [data, setData] = useState(null);
  useEffect(() => {
    fetch(url)
      .then(res => res.json())
      .then(setData);
  }, [url]);
  return data;
}

//...input
function InputExample() {

  const handleChange = (e) => {
    console.log("Value:", e.target.value);
  };

  return <input type="text" onChange={handleChange} />;
}
    
}

export default App;






