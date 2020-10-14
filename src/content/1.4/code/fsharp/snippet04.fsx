let ( >=> ) m1 m2 x =
    let (y, s1) = m1 x
    let (z, s2) = m2 y
    (z, s1 + s2)


