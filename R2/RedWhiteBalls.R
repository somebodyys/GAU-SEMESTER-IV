#Ball Problems 37, 38 simulation
iterations <- 1000

counter_red <- 0
counter_white <- 0
for (i in 1:iterations) {
  urn1 <- c(rep("red", 7), rep("white", 3))
  urn2 <- c(rep("red", 4), rep("white", 5))
  from_one <- sample(urn1, 1)
  urn2 <- append(urn2, from_one)
  from_two <- sample(urn2, 1)
 
  if(from_two == "red" & from_one == from_two){ counter_red = counter_red + 1 }
  if(from_two == "white" & from_one == from_two) { counter_white = counter_white + 1 }
  
}
counter_red / iterations
counter_white / iterations