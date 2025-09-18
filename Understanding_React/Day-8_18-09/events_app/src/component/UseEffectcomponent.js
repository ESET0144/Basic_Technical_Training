import React, { useEffect } from 'react';
import { useState } from 'react';

export default function UseEffectcomponent() {
    // useEffect(() => {}, []);
    const suggestions = [
        "maxhub",
        "laptop",
        "Bottle",
        "car"
    ];

    const [recommendation, setRecommandation] = useState([]);

    const[search, setSearch] = useState("");

    useEffect(() => {
        setRecommandation(suggestions.filter((element) => element.includes(search)));
    }, [search]);

  return (
    <div>
        <input value = {search} onChange = {(e) => setSearch(e.target.value)} ></input>
        {
            recommendation.map((rec, index) => (<div key={index}> {index}.{rec} </div>)) // transformed string into div as html doesnt know string (react knows) it only know div
        }

    </div>
    
  )

}
