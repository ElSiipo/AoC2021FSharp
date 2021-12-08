module Day2

open System

let instructions = 
    InputDays.Days().Day2.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries) 
    |> Seq.map (fun (line : string) -> Seq.toArray(line.Split(' ', StringSplitOptions.RemoveEmptyEntries)))
    |> Seq.toArray

let Run() = 
    let mutable horizontalPosition = 0;
    let mutable depth = 0;

    for i in 0 .. instructions.Length-1 do
        let test = instructions[i][0]
        match instructions[i][0] with
        | "forward" -> horizontalPosition <- horizontalPosition + (instructions[i][1] |> int)
        | "down" -> depth <- depth + (instructions[i][1] |> int)
        | "up" -> depth <- depth - (instructions[i][1] |> int)
        | a -> Console.WriteLine("Error!! " + instructions[i][0])

    printfn "part 1"
    printfn "%A" (horizontalPosition * depth)

    
    let mutable aim = 0;
    let mutable horizontalPosition2 = 0;
    let mutable depth2 = 0;

    let forward(x : int, y : int) = 
        depth2 <- depth2 + (x * y)
        horizontalPosition2 + x;


    for i in 0 .. instructions.Length-1 do
        match instructions[i][0] with
        | "forward" -> horizontalPosition2 <- forward((instructions[i][1] |> int), aim)
        | "down" -> aim <- aim + (instructions[i][1] |> int)
        | "up" -> aim <- aim - (instructions[i][1] |> int)
        | a -> Console.WriteLine("Error!! " + instructions[i][0])

    printfn "part 2"
    printfn "%A" (horizontalPosition2 * depth2)