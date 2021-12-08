module Day1

open System

let someInts = 
    InputDays.Days().Day1.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries) 
    |> Seq.map int
    |> Seq.toArray

let validate(firstVal: int, secondVal:int) = 
    if secondVal > firstVal then 1
    else 0

let Run() = 
    let mutable occurances = 0;

    for i in 1 .. someInts.Length-1 do
        occurances <- occurances + 
            if someInts[i] > someInts[i-1] then 1
            else 0

    printfn "part 1"
    printfn "%A" (occurances)


    let mutable occurrances2 = 0;
    let mutable lastRead = someInts[0] + someInts[1] + someInts[2]

    for i in 3 .. someInts.Length-1 do
        let currentRead = someInts[i] + someInts[i-1] + someInts[i-2];
        occurrances2 <- occurrances2 + 
            if currentRead > lastRead then 1
            else 0

        lastRead <- currentRead

    printfn "part 2"
    printfn "%A" (occurrances2)