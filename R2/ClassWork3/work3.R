#data
myData <- read.csv("fl_student_survey.csv")

#5.49
#a
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
size <- length(myData$TV)

result <- mean(myData$TV) + c(-1,1) * (qt(tail, size - 1)* sd(myData$TV))/sqrt(size)

#b
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
size <- length(myData$life_after_death)

LAD <- myData$life_after_death[myData$life_after_death == "y"]
proportion <- length(LAD)/length(myData$life_after_death)

result <- proportion + c(-1, 1) * qnorm(tail) * sqrt(proportion * (1- proportion)/size)


#6.37
#a 
m <- 4
x_ <- mean(myData$political_ideology)
size <- length(myData$political_ideology)
t <- (x_ - 4)/(sd(myData$political_ideology)/sqrt(size))
result <- ifelse(t <= 0, pt(t,size - 1)*2, 2*(1-pt(t, size - 1)))

pt(t, size - 1)
1 - pt(t, size - 1)

#b
size <- length(myData$abortion_legalize)
proportion <- length(myData$abortion_legalize[myData$abortion_legalize == "y"])/size
