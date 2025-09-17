function MouseEvent(){

        return (
        <>
            <div
            style ={{
                background:"black",
                color:"red",
                padding:"5px"
            }}
            onMouseEnter={ () => {console.log("Mouse entered")}}
            onMouseOut={() => {console.log("Mouse out bye bye!!")}}
            onMouseOver={() => {console.log("Mouse over!!")}}
            onM

            
            > Hello Hi </div>
            
            <div></div>
        </>
        )

}

export default MouseEvent;