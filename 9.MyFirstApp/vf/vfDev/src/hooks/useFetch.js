import { useEffect, useState } from "react";

export default function useFetch (url, appId, apiKey, defaultValue) {
    const [data, setData] = useState(defaultValue);
    const [isLoading, setIsLoading] = useState(false);

    useEffect(() => {
        setIsLoading(true);
        fetch(url, {
            method: 'GET',
            headers: {
                'X-Parse-Application-Id': appId,
                'X-Parse-REST-API-Key': apiKey,
            }
        })
        .then(res=>res.json())
        .then(result=>{
            setIsLoading(true);
            setData(Object.values(result.results));
        });
    }, [url]);
console.log(data);
    return [data, setData, isLoading];
}