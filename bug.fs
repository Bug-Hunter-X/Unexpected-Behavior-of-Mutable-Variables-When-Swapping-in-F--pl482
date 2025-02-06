let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y // this will print 20 20

//But if we try to swap values in a function with mutable parameters, it will work correctly

let swap2 (x:byref<int>) (y:byref<int>) = 
    let temp = x
    x <- y
    y <- temp

let mutable x2 = 10
let mutable y2 = 20
swap2 &x2 &y2
printf "%d %d" x2 y2 // this will print 20 10