import React, { useContext } from "react";
import { ThemeContext } from "../App";

export default function UseContextComponent() {
  const { theme, toggleTheme } = useContext(ThemeContext);

  const styles = {
    backgroundColor: theme === "light" ? "white" : "black",
    color: theme === "light" ? "black" : "white"
    
  };

  return (
    <div style={styles}>
      <h1>Hello Students!</h1>
      <button onClick={toggleTheme}> Toggle Theme </button>
    </div>
  );
}
