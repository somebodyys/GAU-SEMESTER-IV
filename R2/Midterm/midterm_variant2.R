confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
size <- length(myData$political_affiliation[myData$political_affiliation != "r"])

LAD <- myData$political_affiliation[myData$political_affiliation != "r" & myData$life_after_death != "y"]
proportion <- length(LAD)/size

result <- proportion + c(-1, 1) * qnorm(tail) * sqrt(proportion * (1- proportion)/size)

result[2] - result[1]



confidence <- 75
tail <- (1 - confidence/100)/2 + confidence /100
size <- length(myData$age[myData$gender == "m"])

result <- mean(myData$age[myData$gender == "m"]) + c(-1,1) * (qt(tail, size - 1)* sd(myData$age[myData$gender == "m"]))/sqrt(size)




x1 <- mean(myData$age[myData$gender == "m"])
x2 <- mean(myData$age[myData$gender == "f"])

s1 <- sd(myData$age[myData$gender == "m"])
s2 <- sd(myData$age[myData$gender == "f"])

n1 <- length(myData$age[myData$gender == "m"])
n2 <- length(myData$age[myData$gender == "f"])

t <- (x1 - x2)/sqrt(s1^2 / n1 + s2^2 / n2)

v = ((s1^2/n1 + s2^2/n2)^2)/((s1^2/n1)^2/(n1-1) + (s2^2/n2)^2/(n2-1))
2*(1 - pt(t, v))








x1 <- mean(myData$high_sch_GPA[myData$gender == "m"])
x2 <- mean(myData$high_sch_GPA[myData$gender == "f"])

s1 <- sd(myData$high_sch_GPA[myData$gender == "m"])
s2 <- sd(myData$high_sch_GPA[myData$gender == "f"])

n1 <- length(myData$high_sch_GPA[myData$gender == "m"])
n2 <- length(myData$high_sch_GPA[myData$gender == "f"])

t <- (x1 - x2)/sqrt(s1^2 / n1 + s2^2 / n2)

v = ((s1^2/n1 + s2^2/n2)^2)/((s1^2/n1)^2/(n1-1) + (s2^2/n2)^2/(n2-1))

pt(t, v)



totalMale <- myData$gender[myData$gender == "m"]
vegeratianMale <- myData$gender[myData$gender == "m" & myData$abortion_legalize == "y"]
prop1 <- length(vegeratianMale)/length(totalMale)
n1 <- length(totalMale)

totalFemale <- myData$gender[myData$gender == "f"]
vegeratianFemale <- myData$gender[myData$gender == "f" & myData$abortion_legalize == "y"]
prop2 <- length(vegeratianFemale)/length(totalFemale)
n2 <- length(totalFemale)


p_bar <- ((prop1*n1) + (prop2*n2)) / (n1 + n2)
z <- (prop1 - prop2)/sqrt(p_bar*(1 - p_bar)*((1/n1)+(1/n2)))
pnorm(z)