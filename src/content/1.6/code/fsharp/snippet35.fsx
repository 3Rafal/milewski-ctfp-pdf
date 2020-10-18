let SumToProd = function
  | Left (x, y) -> x, Left y
  | Right (x, z) -> x, Right z
