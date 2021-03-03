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

#experiment 1 using qt
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
result <- matrix(ncol = 2)
size <- 9
iterations <- 30
for (i in 1:iterations) {
  picked <- sample(myData$age, size)
  result <- rbind(result, mean(picked) + c(-1,1) * (qt(tail, size - 1)* sd(picked))/sqrt(size))
}
result <- result[-1,]

#plotting
plot(1, type="n", xlab="", ylab="", xlim=c(20, 80), ylim=c(1, iterations))
segments(x0=result[,1], 
         x1=result[,2], 
         y0=1:iterations, 
         y1=1:iterations,
         col = ifelse(mean(myData$age) >= result[,1] & mean(myData$age) <= result[,2], "green", "red"))
abline(v=mean(myData$age), col="blue", lty=5,lwd=2)
points(x=(result[,1]+result[,2])/2, 
       y=1:iterations,
       cex=0.6,
       col="purple")
lines(x=(result[,1]+result[,2])/2, 
      y=1:iterations,
      col="purple")
legend("bottomright",
       legend=c("Failed", "Population Mean", "Caught","Sample Mean"),
       col=c("red", "blue", "green", "purple"), lty=c(1,2,1,1), cex = 0.4)

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


