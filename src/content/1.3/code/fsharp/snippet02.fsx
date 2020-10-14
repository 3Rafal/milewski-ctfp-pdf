module StringMonoid =
  type a = string

  let mempty  = ""
  let mappend = (+)
