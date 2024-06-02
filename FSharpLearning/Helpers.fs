module Helpers

open System
open System.Threading

let chooseOperation () : int =
    printfn "Здравствуйте, вас приветствует тестовый калькулятор на F#. Пожалуйста, выберите операцию: "
    printfn "1) Сложение"
    printfn "2) Вычитание"
    printfn "3) Умножение"
    printfn "4) Деление"
    printfn "5) Выход из программы"
    printf "Введите выбранную вами операцию: "
    let input = Console.ReadLine()
    let mutable operation = 0

    if not (Int32.TryParse(input, &operation)) then
        -1
    else
        operation

let tryInputAgain () : unit =
    printfn "Ваш ввод был некорректен. Давайте попробуем заново"
    printf "Через 3... "
    Thread.Sleep 1000
    printf "2... "
    Thread.Sleep 1000
    printf "1... "
    Thread.Sleep 1000

let getOperands () : int * int =
    printf "Введите первое число: "
    let xInput = Console.ReadLine()
    let mutable x: int = 0

    if not (Int32.TryParse(xInput, &x)) then
        (Int32.MinValue, Int32.MinValue)
    else
        printf "Введите второе число: "
        let yInput = Console.ReadLine()
        let mutable y: int = 0

        if not (Int32.TryParse(yInput, &y)) then
            (Int32.MinValue, Int32.MinValue)
        else
            (x, y)