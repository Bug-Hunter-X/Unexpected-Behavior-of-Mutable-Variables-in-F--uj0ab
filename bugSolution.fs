let mutable x = 10
let mutable y = 20

let add x y =  x + y

let mutable z = add x y

printf "%d\n" z

x <- 30
y <- 40

z <- add x y // Recalculate z after updating x and y

printf "%d\n" z