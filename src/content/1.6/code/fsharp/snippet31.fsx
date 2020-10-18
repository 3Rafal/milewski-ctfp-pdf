type Maybe<'a> =
  | Nothing
  | Just of 'a

let MaybeTail = function
  | Nil -> Nothing
  | Cons (_, xs) -> Just xs
