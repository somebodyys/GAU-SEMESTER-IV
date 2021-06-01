#load
myData <- read_xls("sat.xls")
formula <- lm(myData$univ_GPA~myData$high_GPA)

#1
plot(
  myData$high_GPA,
  myData$univ_GPA,
  xlab = "High School GPA",
  ylab = "University overall GPA"
)
abline(formula)

#2
cor(myData$high_GPA, myData$univ_GPA)

#3
formula <- lm(myData$univ_GPA~myData$high_GPA)
#3.3
coeficients <- data.frame(coef(formula))$coef.formula.
result <- coeficients[2] * 2.2 + coeficients[1] # y = kx+b
#3.4
coeficients <- data.frame(coef(formula))$coef.formula.
result <- coeficients[2] * 4.0 + coeficients[1]

#4
SATmean <- mean(c(myData$math_SAT, myData$verb_SAT))

mathMean <- mean(myData$math_SAT)
verbMean <- mean(myData$verb_SAT)

#5
sdMath <- sd(myData$math_SAT)
sdVerb <- sd(myData$verb_SAT)

#6
cor(myData$math_SAT, myData$verb_SAT)

#7
cor(myData$comp_GPA, myData$univ_GPA)

#8.1
meanOvar <- mean(myData$univ_GPA)
meanComp <- mean(myData$comp_GPA)
#8.2
t.test(myData$univ_GPA, myData$comp_GPA, paired = T, alternative = "less")

#9

totalMeanVector <- (myData$math_SAT + myData$verb_SAT)/2
#9.1
plot(
  myData$univ_GPA~totalMeanVector
)
abline(lm(myData$univ_GPA~totalMeanVector))
lm(myData$univ_GPA~totalMeanVector)

#9.2
summary(lm(myData$univ_GPA~totalMeanVector))

#9.4
prediction <- 0.005475 * mean(c(600, 540)) - 0.171606

#interval 
iter <- 2.949144 + c(-1, 1) * 0.0005743 * qt(0.975, length(myData$univ_GPA - 1))



