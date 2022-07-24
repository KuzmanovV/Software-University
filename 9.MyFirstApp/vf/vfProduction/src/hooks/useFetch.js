import { useEffect, useState } from "react";

export default function useFetch (url, defaultValue) {
    const [data, setData] = useState(defaultValue);
    const [isLoading, setIsLoading] = useState(false);

    useEffect(() => {
        setIsLoading(true);
        fetch(url)
        .then(res=>res.json())
        .then(result=>{
            setIsLoading(true);
            setData(Object.values(result));
        });
    }, [url]);

    return [data, setData, isLoading];
}