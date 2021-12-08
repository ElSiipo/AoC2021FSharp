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
        if (zeros < ones) then
            true
        else 
            false;

    for i in 0 .. instructions[0].Length-1 do
        let mostCommon = getMostCommon(i)
        gammaRate <- gammaRate + System.Convert.ToInt32(mostCommon).ToString()
        epsilonRate <- epsilonRate + System.Convert.ToInt32(not mostCommon).ToString()
       
    let gammaRateInt = 
        gammaRate 
        |> Seq.map int
        |> Seq.toArray;

    for i in 0 .. gammaRate.Length-1
        
    
    printfn "part 1"
    printfn "%A" gammaRate

    

    printfn "part 2"
    //printfn "%A" (horizontalPosition2 * depth2)