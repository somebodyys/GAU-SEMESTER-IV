#11.54

#a
x <- c(2,5,3,1,8)
y <- c(5,8,7,2,15)

plot(
  x,
  y
)
cor(x, y)
cor.test(x, y)
#11.55
#a
corel <- 0.75
size <- 49

t <- (corel* sqrt(size - 2))/sqrt(1 - corel * corel)

ifelse(t <= 0, pt(t, size - 2) * 2, 2 * (1 - pt(t, size - 2)))

#11.60
myData <- read_xls("Dow Jones.xls")

#a
plot(myData$X, myData$Y, xlab = "X", ylab = "Y")
plot(myData$Y ~ myData$X)
abline(lm(myData$Y ~ myData$X))
cor(myData$X, myData$Y)

#b
sig <- 0.01
corel <- cor(myData$X, myData$Y)
size <- nrow(myData)
t <- (corel* sqrt(size - 2))/sqrt(1 - corel * corel)
result <- ifelse(t <= 0, pt(t, size - 2) * 2, 2 * (1 - pt(t, size - 2)))
ifelse(sig > result, "Reject", "Can't Reject")

cor.test(myData$X, myData$Y)

#11.61
myData <- read_xls("Student Evaluation.xls")
plot(
  myData$`Expected Grade` ~ myData$`Instructor Rating`,
  xlab = "Instructor Rating",
  ylab = "Expected Grade"
)
abline(lm(myData$`Expected Grade` ~ myData$`Instructor Rating`))

#hypo
sig <- 0.1
corel <- cor(myData$`Instructor Rating`, myData$`Expected Grade`)
size <- nrow(myData)
t <- (corel* sqrt(size - 2))/sqrt(1 - corel * corel)
result <- ifelse(t <= 0, pt(t, size - 2) * 2, 2 * (1 - pt(t, size - 2)))
ifelse(sig > result, "Reject", "Can't Reject")

cor.test(myData$`Instructor Rating`, myData$`Expected Grade`)


#11.62
myData <- read_xls("Advertising Revenue.xls")
plot(
 myData$Y ~ myData$X 
)
abline(lm(myData$Y ~ myData$X))

corel <- cor(myData$X, myData$Y)
size <- nrow(myData)
t <- (corel* sqrt(size - 2))/sqrt(1 - corel * corel)
result <- ifelse(t <= 0, pt(t, size - 2) * 2, 2 * (1 - pt(t, size - 2)))

#11.24
myData <- read_xls("New York Stock Exchange Gains and Losses.xls")

plot(myData$`Percent Gain X` ~ myData$`Percent Loss Y`, xlab = "Loss", ylab = "Gain")
abline(lm(myData$`Percent Gain X` ~ myData$`Percent Loss Y`))