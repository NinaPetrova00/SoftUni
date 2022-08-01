import { useState, useEffect } from "react"

export const useFetch = (url, defaultvalue) => {

    const [data, setData] = useState(defaultvalue);
    const [isLoading, setIsLoading] = useState(false);

    useEffect(() => {
        setIsLoading(true);

        fetch(url)
            .then(res => res.json())
            .then(result => {
                setIsLoading(false);

                setData(Object.values(result));
            });
    }, [url]);
    // to delete the items from the server!

    return [data, setData, isLoading];
}