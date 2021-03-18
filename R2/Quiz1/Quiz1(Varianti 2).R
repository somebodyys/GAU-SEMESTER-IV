myData <- read.csv("fl_student_survey.csv")


#1
confidence <- 99
tail <- (1 - confidence/100)/2 + confidence /100
size <- length(myData$life_after_death)

LAD <- myData$religiosity[myData$religiosity == 3]
proportion <- length(LAD)/length(myData$religiosity)

result <- proportion + c(-1, 1) * qnorm(tail) * sqrt(proportion * (1- proportion)/size)
result[2] - result[1]

#2
confidence <- 90
tail <- (1 - confidence/100)/2 + confidence /100
size <- length(myData$abortion_legalize)

ABO <- myData$abortion_legalize[myData$abortion_legalize == "y"]
proportion <- length(ABO)/size

result <- proportion + c(-1, 1) * qnorm(tail) * sqrt(proportion * (1- proportion)/size)
result[2] - result[1]



#3
confidence <- 90
tail <- (1 - confidence/100)/2 + confidence /100
size <- length(myData$high_sch_GPA[myData$gender == "f"])

result <- (qt(tail, size - 1)* sd(myData$high_sch_GPA[myData$gender == "f"]))/sqrt(size)

#4
m <- 5
x_ <- mean(myData$sports)
size <- length(myData$sports)
t <- (x_ - m)/(sd(myData$sports)/sqrt(size))
result <- ifelse(t <= 0, pt(t,size - 1), (1-pt(t, size - 1)))


#5
size <- length(myData$political_affiliation)
proportion <- length(myData$political_affiliation[myData$political_affiliation == "d"])/size
pi <- 0.3
z <- (proportion - pi)/sqrt(pi * (1 - pi)/size)
result <- ifelse(z <= 0, 2*pnorm(z), 2*(1-pnorm(z)))