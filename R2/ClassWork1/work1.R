#load
survey <- read.csv("fl_student_survey.csv")
attach(survey)
size <- length(age)
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100

mean(age) + c(-1, 1) * (qt(tail, size -1) * sd(age))/sqrt(size)


###############################################
confidence <- 95
size <- length(gender)
tail <- (1 - confidence/100)/2 + confidence /100

total <- length(gender)
women <- length(gender[gender == "f"])
women_part <- women/total

women_part + c(-1, 1) * qnorm(tail) * sqrt(women_part * (1- women_part)/size)

