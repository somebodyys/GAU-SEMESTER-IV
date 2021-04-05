



FastPower <- function(base, expont){
  if(expont == 0) return(1)
  if(expont %% 2 == 1) return(base * FastPower(base*base, (expont - 1)/2))
  return(FastPower(base*base, expont/2))
}