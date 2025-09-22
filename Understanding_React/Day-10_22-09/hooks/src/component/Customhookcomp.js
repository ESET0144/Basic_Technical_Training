import React, { useEffect, useState } from 'react'

export default function Customhookcomp() {
    const[data, setData] = useState([])

    //getData - function is to go to internet and collect the data 
    const getData = () => {
        setLoading(true)
        // calling endpoint - fetch
        fetch("https://www.youtube.com/")
        .then((data => data.json())
        .then(setData(data))
        .finally(() => {setLoading(false)})
    }

    useEffect(getData, []);

  return (
    <div>
        {
            loading && <>loading...</>
        }
        {
            data.map((item) => <div key = {item.id}> {item.id}.{item.title})>;
        }
    </div>
  )
}
