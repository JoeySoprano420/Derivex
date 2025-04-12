module core.io

function print(msg:string)
    system.console.out(msg)
end

function read() -> string
    return system.console.in()
end
