import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  //const [count, setCount] = useState(0)
  
// var add = (a,b) => a+b;

// console.log(add(6,7))

 // add = (a,b) => a*b;

// console.log(add(6,6))

// var user = {name:"Uday", age:12, c:23}
// var {name:username, d=34} = user;

//var a=1; 
//var b=2;

// [a,b] = [b,a]
var prev = {name:"A", age:21};
var next = {...prev, age:20};

prev.age = next.age
next.age = 34
//console.log(prev.age)
//console.log(next.age)
//console.log(username)
//console.log(d)
const name = `Aditya
Hello`;

//console.log(name)

//const names = 'Adi';
//const ages = 25;

//const person = {names, ages};
//console.log(person.names, person.ages)

// Filter
const evens = [1,2,3,4].filter(n => n % 3 == 0).map(n => n**2);
console.log(evens)

// Map
const double = [1,2,3,4].map(num => num**3);
console.log(double)

// Reduce
const sum = [10, 20, 50, 30].reduce((acc, v) => v > acc ? v: acc, 0); // last value of acc will only return in reduce function, if v> acc, assign acc =v
console.log(sum)


  return(
    <div> 
      <h2 id="a"> 0 </h2>
      <button onClick={() =>{
        const element = document.getElementById("a");
        var curr = parseInt(element.textContent)
        element.textContent = curr+1;

      }
      }
      >Increment</button>

      <button onClick={() =>{
        const element = document.getElementById("a");
        var curr = parseInt(element.textContent)
        element.textContent = curr-1;

      }
      }
      >Decrement</button>
    </div>
  )

//   return (
//     <>
//       <div>
//         <a href="https://www.youtube.com/" target="_blank">
//           <img src={viteLogo} className="logo" alt="Vite logo" />
//         </a>
//         <a href="https://www.youtube.com/" target="_blank">
//           <img src={reactLogo} className="logo react" alt="React logo" />
//         </a>
//       </div>
//       <h1>Vite + React</h1>
//       <div className="card">
//         <button onClick={() => setCount((count) => count + 1)}>
//           count is {count}
//         </button>
//         <p>
//           Edit <code>src/App.jsx</code> and save to test HMR
//         </p>
//       </div>
//       <p className="read-the-docs">
//         Click on the Vite and React logos to learn more
//       </p>
//     </>
//   )
}

// export default App
export default App
