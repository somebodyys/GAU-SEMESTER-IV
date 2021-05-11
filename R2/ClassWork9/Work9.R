#remembering 1
a <- read.csv("fl_student_survey.csv")
head(a)

boxplot(a$age~a$gender)
boxplot(a$age~a$life_after_death)
boxplot(a$age~a$abortion_legalize)

male <- a[a$gender == 'm',]
male <- subset(a, a$gender == 'm')
female <- a[a$gender == 'f',]


maleNormalized <- male[male$age < 50,] #removed Outliers

boxplot(maleNormalized$age)
shapiro.test(maleNormalized$age)
hist(maleNormalized$age, probability = T)
curve(dnorm(x, mean= mean(maleNormalized$age), sd= sqrt(var(maleNormalized$age))), add= TRUE)


#remembering 2
t.test(male$age,female$age)
t.test(male$age,female$age,alternative = 'less')
t.test(male$age,female$age,alternative = 'greater')
## t.test(male$age,female$age,paired= TRUE,alternative = 'greater')

mean(male$age) 
mean(female$age)

install.packages("psych")
library(psych) 

describe(male$age)
describe(female$age)

#plotting
hist( male$age
      , breaks= 7, probability= TRUE, 
      ylim= c(0,0.1), xlim= c(18,80), col= "cornflowerblue",
      xlab="male")
curve(dnorm(x, mean= mean(male$age), sd= sqrt(var(male$age))), add= TRUE)

hist(female$age, breaks= 7, probability= TRUE, 
     ylim= c(0,0.1), xlim= c(18,80), col= "cornflowerblue",
     xlab="female")
curve(dnorm(x, mean= mean(female$age), sd= sqrt(var(female$age))), add= TRUE)


ks.test(male$age, "pnorm", mean(male$age), sqrt(var(male$age)))

#check if normal distribution
shapiro.test(male$age)

qqnorm(male$age,main="QQ plot of normal data",pch=19)
qqline(male$age)

ks.test(male$age, "pnorm", mean(male$age), sd(male$age))
ks.test(female$age, "pnorm", mean(female$age), sqrt(var(female$age)))

#test for non-normal distribution
wilcox.test(male$age, female$age)

#part 3
leveneTest(male$age,female$age[1:29], center= mean)

chickwts

boxplot(
  chickwts$weight~chickwts$feed
)
means <- tapply(chickwts$weight, FUN = mean, INDEX = chickwts$feed)
points(1:6,means,pch=4,cex=1.5)
