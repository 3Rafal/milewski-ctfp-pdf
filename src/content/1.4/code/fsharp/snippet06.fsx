let upCase (s: string) : string Writer = 
    String.map (System.Char.ToUpper) s, "up_case"

let toWords (s: string) : string list Writer =
    s.Split ' ' |> List.ofArray, "to_words"