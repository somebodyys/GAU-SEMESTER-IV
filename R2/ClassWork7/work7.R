#load
strengthData <- read.csv("strength.csv")

plot(
  x = strengthData$GRIP,
  y = strengthData$ARM,
  xlab = "Grip",
  ylab = "Arm"
)

#correlation coefficient
cor(strengthData$GRIP, strengthData$ARM)

#hypothesis
sig <- 0.01
corel <- cor(strengthData$GRIP, strengthData$ARM)
size <- nrow(strengthData)
t <- (corel* sqrt(size - 2))/sqrt(1 - corel * corel)
result <- ifelse(t <= 0, pt(t, size - 2) * 2, 2 * (1 - pt(t, size - 2)))
ifelse(sig > result, "Reject", "Can't Reject")

cor.test(strengthData$GRIP, strengthData$ARM)

#9
broken <- c(0,1,1,0,0,2,0,1,1,1,1,3,1,2,3,2,2,3,2,4,5,4,5,6)
hist(broken)

#33
myData <- read_excel("33.xlsx")

#a
plot(
  x = myData$Horsepower, 
  y = myData$`Highway Gas Mileage (mpg)`,
  xlab = "HorsePower",
  ylab = "Highway Gas Mileage (mpg)"
)
#correlation
cor(myData$Horsepower, myData$`Highway Gas Mileage (mpg)`)




#34
myData <- read_excel("34.xlsx")
plot(
  x = myData$Marijuana, 
  y = myData$`Other Drugs`,
  xlab = "HMarijuana",
  ylab = "Other Drugs"
)

cor(myData$Marijuana, myData$`Other Drugs`)


#35
myData <- read_excel("35.xlsx")

plot(
  myData$`Fat (g)`,
  myData$`Sodium (mg)`,
  xlab = "Fat (g)",
  ylab = "Sodium (mg)"
)

cor(myData$`Fat (g)`, myData$`Sodium (mg)`)