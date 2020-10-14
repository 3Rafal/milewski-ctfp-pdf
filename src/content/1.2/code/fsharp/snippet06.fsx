module Void = 
    type T = private T of T 

let rec absurd (x : Void.T) = absurd x
