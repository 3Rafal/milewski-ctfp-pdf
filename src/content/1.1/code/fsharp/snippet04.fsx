type F<'a,'b> = 'a -> 'b
type G<'b,'c> = 'b -> 'c 
type H<'c,'d> = 'c -> 'd

(f >> g) >> h = (f >> g) >> h = f >> g >> h
