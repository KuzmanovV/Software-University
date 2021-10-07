function rv(obj) {
    let methodOpt = ['GET', 'POST', 'DELETE' , 'CONNECT'];
    let versionOpt = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1' , 'HTTP/2.0'];

    if (!methodOpt.includes(obj.method)) {
        throw console.error("Invalid request header: Invalid Method");
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