module Void = 
    type T = private T of T 

val absurd: Void.T -> 'a