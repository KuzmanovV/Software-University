function rv(obj) {
    
    if (!['GET', 'POST', 'DELETE', 'CONNECT'].includes(obj.method) || !obj.method) {
        throw new Error("Invalid request header: Invalid Method");
    }
    
    if (!obj.uri || obj.uri == '' || !/(^[\w.*]+$)/gm.test(obj.uri)) {
        throw new Error("Invalid request header: Invalid URI");
    }

    if (!['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'].includes(obj.version) || !obj.version) {
        throw new Error("Invalid request header: Invalid Version");
    }

    if (obj.message == undefined || /([<>\\&'"])/gm.test(obj.message)) {
        throw new Error("Invalid request header: Invalid Message");
    }

    return obj;
}

console.log(rv({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: ''
})
);

console.log(rv({
    method: 'OPTIONS',
    uri: 'git.master',
    version: 'HTTP/1.1',
    message: '-recursive'
})
);