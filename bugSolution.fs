let swap2 (x:byref<int>) (y:byref<int>) = 
    let temp = x
    x <- y
    y <- temp

let mutable x2 = 10
let mutable y2 = 20
swap2 &x2 &y2
printf "%d %d" x2 y2 // this will print 20 10