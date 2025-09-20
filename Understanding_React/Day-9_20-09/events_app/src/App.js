import logo from './logo.svg';
import './App.css';
import FormEventComponent from './component/LoginFormComponent';
import UseRefComponent from './component/UseRefComponent';
import ParentComponent from './component/ParentComponent';
import { createContext, useState } from 'react';
import UseContextSample from './component/UseContextSample';


const Context = createContext();

export {Context};

function App() {

//create all global variables, usestate here
const [count, setCount] = useState(0);
const [username, setUsername] = useState("use");
  return (
    <Context.Provider value = {{count, setCount, username, setUsername}}> 
  
    <UseContextSample/>

    </Context.Provider>
  );
}

export default App;
