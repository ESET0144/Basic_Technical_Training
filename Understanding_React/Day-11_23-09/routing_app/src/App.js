import Homepage from "./pages/Homepage";
import Navbar from "./components/Navbar";
import Aboutpage from "./pages/Aboutpage";



function App() {
  return (
    <>
    <Navbar/>
    <BrowserRouter>
    <Routes>
      <Route path = "/" element>{<Homepage/>}</Route>
      <Route path = "/about" element>{<Aboutpage/>}</Route>
    </Routes>
    </BrowserRouter>
    </>
  );
}

export default App;
