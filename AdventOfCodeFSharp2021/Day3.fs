module Day3

open System

let instructions = 
    InputDays.Days().Day3.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)

let Run() = 
    let mutable gammaRate = "";
    let mutable epsilonRate = "";

    let getMostCommon(x:int) = 
        let mutable zeros = 0;
        let mutable ones = 0;
        for i in 0 .. instructions.Length-1 do
            let test = instructions[i].ToCharArray()[x]
            match test with
            | '0' -> zeros <- zeros + 1
            | '1' -> ones <- ones + 1
            | _ -> Console.WriteLine("Error!!")
        zeros >= ones;

    for i in 0 .. instructions[0].Length-1 do
        let mostCommon = getMostCommon(i)
        gammaRate <- gammaRate + System.Convert.ToInt32(mostCommon).ToString()
        epsilonRate <- epsilonRate + System.Convert.ToInt32(not mostCommon).ToString()
       
    let mutable gammaRateInt = 0;
    let mutable epsilonRateInt = 0;
    let gammaRateReversed = gammaRate |> Array.ofSeq |> Array.rev

    for i in 0 .. gammaRateReversed.Length-1 do
        match gammaRateReversed[i] with 
        | '0' -> epsilonRateInt <- epsilonRateInt + pown 2 i
        | '1' -> gammaRateInt <- gammaRateInt + pown 2 i
        | _ -> Console.WriteLine("Error!!")

    let multiplied = gammaRateInt * epsilonRateInt
    printfn "part 1"
    printfn "%A" multiplied

    

    printfn "part 2"
    //printfn "%A" (horizontalPosition2 * depth2)