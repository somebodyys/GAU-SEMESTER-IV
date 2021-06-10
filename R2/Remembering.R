

myData <- read.csv("fl_student_survey.csv")

x1 <- mean(myData$age[myData$gender == "m"])
x2 <- mean(myData$age[myData$gender == "f"])

n1 <- length(myData$age[myData$gender == "m"])
n2 <- length(myData$age[myData$gender == "f"])
s1 <- sd(myData$age[myData$gender == "m"])
s2 <- sd(myData$age[myData$gender == "f"])


confidence <- 90
tail <- (1 - confidence/100)/2 + confidence /100
v = ((s1^2/n1 + s2^2/n2)^2)/((s1^2/n1)^2/(n1-1) + (s2^2/n2)^2/(n2-1))

interval <- (x2 - x1) + c(-1,1) * qt(tail, v) * sqrt(s1^2 / n1 + s2^2 / n2)

t.test(myData$age[myData$gender == "f"], myData$age[myData$gender == "m"], conf.level = 0.9)


confidence <- 90
tail <- (1 - confidence/100)/2 + confidence /100
s <- ( (n1 - 1) * s1^2 + (n2 - 1) * s2^2) / ((n1 - 1) + (n2 - 1) )
interval <- (x2 - x1) + c(-1, 1) * qt(tail, n1+n2 - 2) * sqrt(s * (1/n1 + 1/n2))




###

x1 <- mean(myData$age[myData$gender == "m"])
x2 <- mean(myData$age[myData$gender == "f"])
n1 <- length(myData$age[myData$gender == "m"])
n2 <- length(myData$age[myData$gender == "f"])
s1 <- sd(myData$age[myData$gender == "m"])
s2 <- sd(myData$age[myData$gender == "f"])

t <- (x1 - x2)/sqrt(s1^2 / n1 + s2^2 / n2)
v = ((s1^2/n1 + s2^2/n2)^2)/((s1^2/n1)^2/(n1-1) + (s2^2/n2)^2/(n2-1))

1 - pt(t,v)

t.test(myData$age[myData$gender == "m"], myData$age[myData$gender == "f"], alternative = "greater")

t.test(myData$high_sch_GPA[myData$gender == "m"], myData$high_sch_GPA[myData$gender == "f"], alternative = "less")




px <- length(myData$gender[myData$abortion_legalize == "y" & myData$gender == "m"])/length(myData$gender[myData$gender == "m"])
py <- length(myData$gender[myData$abortion_legalize == "y" & myData$gender == "f"])/length(myData$gender[myData$gender == "f"])

prop.test(c(21, 26), c(29, 31), correct = F, alternative = "less")

table(myData$gender, myData$abortion_legalize)

prop.test(c(21, 26), c(29, 31), correct = F, alternative = "less")

prop.test(c(3, 6),c(29, 31), correct = F)