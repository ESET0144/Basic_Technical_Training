import React, { useEffect, useState } from 'react'

const useFetch = (url) => {
    

    //getData - function is to go to internet and collect the data 
    
        const [data, setData] = useState([])
        const [loading, setLoading]= useState(false)
        const [error, setError] = useState(null)
        const getData = () => {
            setLoading(true)
            // calling endpoint - fetch
            fetch(url)
            .then((data) => data.json())
            .then((data) => setData(data))
            .catch()
            .finally(() => {setLoading(false)})
            
    }
    useEffect(getData, []);

    return {loading, data, error};
}

const useFetchjson = (url) => {
    const[data, setData] = useState([])

    //getData - function is to go to internet and collect the data 
    const getData = () => {
        setLoading(true)
        // calling endpoint - fetch
        fetch("https://www.youtube.com/")
        .then((data) => data.json())
        .then(setData(data))
        .finally(() => {setLoading(false)})
    }

    useEffect(getData, []);
    return {loading, data, error};

}
export default function Customhookcomponent() {
    const [loading, data, error] = useFetch("https://www.youtube.com/")
    //const {data} = useFetchjson("https://www.youtube.com/")

  return (
    <div>
        {
            loading && <>loading...</> // ternary operator
        }
        {
            error && <>{error}</>
        }
        {
            data.map((item) => <div key = {item.id}> {item.id}.{item.title}</div>)
        }
    </div>
  )
}
