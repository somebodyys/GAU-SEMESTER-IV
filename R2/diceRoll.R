for (i in 2:15) {
  counter <- 0
  for (j in 1:1000) {
    items <- sample(1:6, i, replace = T)
    if(length(as.set(items)) < i){
      counter <- counter + 1
    }
  }
  print(paste0("Percent (", i,") : ", counter/10,"%"))
  if(counter/10 == 100) {
    print(paste0("Sucess on Roll : ",i))
    break
  }
}