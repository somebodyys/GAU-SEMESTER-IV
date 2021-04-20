#loading data 


#25 {$3500}
myData <- read.csv("25.csv")

size <- length(myData$Institution)
pair_differences <- myData$Nonresident - myData$Resident
D_mean <- mean(pair_differences)
test_sd <- sd(pair_differences)

confidence <- 90
tail <- (1 - confidence/100)/2 + confidence /100
conf_inter <- D_mean + c(-1, 1) * qt(tail, size - 1) * test_sd / sqrt(size)

#26 
myData <- read.csv("26.csv")


#interval
size <- length(myData$Subject.Number)
pair_differences <- myData$Sexual.Image - myData$No.Sex
D_mean <- mean(pair_differences)
test_sd <- sd(pair_differences)

confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
conf_inter <- D_mean + c(-1, 1) * qt(tail, size - 1) * test_sd / sqrt(size)

#hypothesis
mD <- 0
t <- (D_mean - mD)*sqrt(size)/(test_sd)
1 - pt(t, size - 1)


t.test(myData$Sexual.Image, myData$No.Sex, paired=TRUE, alt="two.sided")
t.test(myData$Sexual.Image, myData$No.Sex, paired=TRUE, alt="less")
t.test(myData$Sexual.Image, myData$No.Sex, paired=TRUE, alt="greater")



#28

myData <- read.csv("28.csv")

#interval
size <- length(myData$Subject.Number)
pair_differences <- myData$Terminal..Weight - myData$Initial..Weight
D_mean <- mean(pair_differences)
test_sd <- sd(pair_differences)

confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
conf_inter <- D_mean + c(-1, 1) * qt(tail, size - 1) * test_sd / sqrt(size)

#hypothesis
mD <- 0
t <- (D_mean - mD)*sqrt(size)/(test_sd)
1 - pt(t, size - 1)


#more

myData <- read_xls("weight.xls")

normal <- myData$TIME[myData$WEIGHT == 1]
overweight <- myData$TIME[myData$WEIGHT == 2]

s1 <- sd(normal)
s2 <- sd(overweight)
n1 <- length(normal)
n2 <- length(overweight)
x1 <- mean(normal)
x2 <- mean(overweight)

#plotting
boxplot(normal, overweight)

#interval
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
v = ((s1^2/n1 + s2^2/n2)^2)/((s1^2/n1)^2/(n1-1) + (s2^2/n2)^2/(n2-1))

conf_inter <- (x2 - x1) + c(-1,1) * qt(tail, v) * sqrt(s1^2 / n1 + s2^2 / n2)

#hypothesis
t <- (x2 - x1)/sqrt(s1^2 / n1 + s2^2 / n2)
pt(t, v)

#built in
t.test(normal, overweight, alt="greater")