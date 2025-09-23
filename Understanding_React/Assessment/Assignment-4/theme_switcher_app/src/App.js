import React, { createContext, useState } from "react";
import UseContextComponent from "./component/UseContextComponent";

//ThemeContext
export const ThemeContext = createContext();

// 2. Create ThemeProvider
const ThemeProvider = ({ children }) => {
  const [theme, setTheme] = useState("light");

  const toggleTheme = () => {
    setTheme((prev) => (prev === "light" ? "dark" : "light"));
  };

  return (
    <ThemeContext.Provider value={{ theme, toggleTheme }}>
      {children}
    </ThemeContext.Provider>
  );
};

// 3. Main App
export default function App() {
  return (
    <ThemeProvider>
      <UseContextComponent />
    </ThemeProvider>
  );
}

