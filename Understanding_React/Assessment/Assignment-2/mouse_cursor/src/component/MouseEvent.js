import React, { useEffect, useState } from "react";


function MouseEvent(){
    
    const [position, setPosition] = useState({x :0, y:0});

    useEffect(() => {
        const detectMouseMove = (event) => {
            setPosition({x: event.clientX, y: event.clientY});
            }
        window.addEventListener("mousemove", detectMouseMove);
        //clean up the event listener
        return () => {
        window.removeEventListener("mousemove", detectMouseMove);
        };

        }, []);
    

        return (
        
            <div> X : {position.x}, Y: {position.y} </div>

        )

}

export default MouseEvent;