#load
myData <- read.csv("HouseholdData.csv")


#a
stem(myData$age)
hist(myData$age, xlab = "Age")

#b
result <- c()
for (i in 1:1000) {
  result <- append(result, mean(sample(myData$age, 9)))
}
hist(result)
###########################################

#experiment used qt
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
result <- matrix(ncol = 2)
size <- 9
for (i in 1:1000) {
  picked <- sample(myData$age, size)
  result <- rbind(result, mean(picked) + c(-1,1) * (qt(tail, size - 1)* sd(picked))/sqrt(size))
}


#check validity
check <- c()
populationMean <- mean(myData$age)
for (i in 4:length(result)/2) {
  out <- 0
  if(populationMean >= result[i, 1] & populationMean <= result[i, 2]){
    out <- 1
  }
  check <- append(check, out)
}
length(check[check == 1])/length(check)*100