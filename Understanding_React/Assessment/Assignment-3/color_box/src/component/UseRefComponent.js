import React, { useRef, useState } from 'react'

export default function UseRefComponent() {
  const boxesRef = useRef([]);
  const [current, setCurrent] = useState(-1);
  const colors = ["red", "green", "blue"];

  const highlightNext = () => {
    const boxes = boxesRef.current;
    //if (current >= 0) boxes[current].style.border = "";
    const next = (current + 1) % colors.length;
    console.log(next);
    boxes[next].style.border = "2px solid black";
    setCurrent(next);
    console.log(boxesRef.current[next]);
  }; 

  const highlightAll = () => {
    const boxes = boxesRef.current; // array of refs
  boxes.forEach(box => {
    if (box) { // make sure box exists
      box.style.border = "5px solid black";
    }});
  }; 

  const Box = ({color, index}) => (
    <div ref= {(element) => (boxesRef.current[index]= element)}
    style={{ width: 100, height: 100, background: color, display: "inline-block", margin: 5 }}
    />
  ); 


  return (
    <div>
      <Box color = "red" index = {0}/>
      <Box color = "green" index = {1}/>
      <Box color = "blue" index = {2}/>
      <div>
        <button onClick={highlightNext}> Highlight next box</button>
      </div>
    </div>
  )
}

