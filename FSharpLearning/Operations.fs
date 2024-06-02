module Operations

open System
open Helpers;

let sum (x: int, y: int) : unit =
    printfn $"Сумма чисел %d{x} и %d{y} равняется %d{x + y}"

let sub (x: int, y: int) : unit =
    printfn $"Разница чисел %d{x} и %d{y} равняется %d{x - y}"

let mul (x: int, y: int) =
    printfn $"Произведение чисел %d{x} и %d{y} равняется %d{x * y}"

let div (x: int, y: int) =
    printfn $"Частное чисел %d{x} и %d{y} равняется %f{float x / float y}"

module Handlers =
    let sumHandler (): unit =
        let x, y = getOperands ()

        if x = Int32.MinValue && y = Int32.MinValue then
            tryInputAgain ()
        else
            sum (x, y)
            Console.ReadKey() |> ignore

    let subHandler (): unit =
        let x, y = getOperands ()

        if x = Int32.MinValue && y = Int32.MinValue then
            tryInputAgain ()
        else
            sub (x, y)
            Console.ReadKey() |> ignore

    let mulHandler (): unit =
        let x, y = getOperands ()

        if x = Int32.MinValue && y = Int32.MinValue then
            tryInputAgain ()
        else
            mul (x, y)
            Console.ReadKey() |> ignore

    let divHandler (): unit =
        let x, y = getOperands ()

        if x = Int32.MinValue && y = Int32.MinValue then
            tryInputAgain ()
        else if y = 0 then
            printfn $"На %d{y} делить нельзя!"
            tryInputAgain ()
        else
            div (x, y)
            Console.ReadKey() |> ignore