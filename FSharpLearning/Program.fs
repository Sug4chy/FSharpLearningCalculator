open System
open Helpers
open Operations.Handlers
let mutable canContinue: bool = true

while canContinue do
    let op = chooseOperation ()

    match op with
    | 1 -> sumHandler ()
    | 2 -> subHandler ()
    | 3 -> mulHandler ()
    | 4 -> divHandler ()
    | 5 -> canContinue <- false
    | _ -> tryInputAgain ()
    
    Console.Clear()