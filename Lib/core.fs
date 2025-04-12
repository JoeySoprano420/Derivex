module core.fs

function read(path:string) -> string
    return fs.load(path)
end

function write(path:string, data:string)
    fs.store(path, data)
end

function exists(path:string) -> bool
    return fs.exists(path)
end
