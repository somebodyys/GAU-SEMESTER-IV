#7
interval <- c(5.573, 11.427)
result <- (interval[2] - interval[1])/2

#9
x1 <- 29.0
x2 <- 38.4

s1 <- 18.8
s2 <- 16.2

n1 <- 312
n2 <- 265

t <- (x1 - x2)/sqrt(s1^2 / n1 + s2^2 / n2)

v = ((s1^2/n1 + s2^2/n2)^2)/((s1^2/n1)^2/(n1-1) + (s2^2/n2)^2/(n2-1))

1 - pt(t,v)
pt(t,v)

pt(t, v)*2
pnorm(t)*2


#11
x1 <- 40 #a route
s1 <- 3
x2 <- 43 #b route
s2 <- 2

n1 <- 20
n2 <- 20

confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
v = ((s1^2/n1 + s2^2/n2)^2)/((s1^2/n1)^2/(n1-1) + (s2^2/n2)^2/(n2-1))

interval <- (x2 - x1) + c(-1,1) * qt(tail, v) * sqrt(s1^2 / n1 + s2^2 / n2)


#13
children <- c(40.3, 55, 45.7, 43.3, 50.3, 45.9, 53.5,43,
              44.2, 44, 47.4, 44, 33.6, 55.1, 48.8, 50.4, 37.8, 60.3, 46.6)
adult <- c(20, 30.2, 2.2, 7.5, 4.4, 22.2, 16.6, 14.5,
           21.4, 3.3, 6.6, 7.8, 10.6, 16.2, 14.5, 4.1, 15.8, 4.1, 2.4, 3.5,
           8.5, 10, 1, 4.4, 1.3, 8.1, 4.7, 18.4)

confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100

x1 <- mean(children)
x2 <- mean(adult)
s1 <- sd(children)
s2 <- sd(adult)
n1 <- length(children)
n2 <- length(adult)
v = ((s1^2/n1 + s2^2/n2)^2)/((s1^2/n1)^2/(n1-1) + (s2^2/n2)^2/(n2-1))

interval <- (x1 - x2) + c(-1,1) * qt(tail, v) * sqrt(s1^2 / n1 + s2^2 / n2)

#~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
#12
n1 <- 28
n2 <- 24
x1 <- 72.75
x2 <- 72.625
median1 <- 73
median2 <- 73
s1 <- 5.37225
s2 <- 7.69987
range1 <- 20
range2 <- 29


confidence <- 90
tail <- (1 - confidence/100)/2 + confidence /100
v = ((s1^2/n1 + s2^2/n2)^2)/((s1^2/n1)^2/(n1-1) + (s2^2/n2)^2/(n2-1))

interval <- (x2 - x1) + c(-1,1) * qt(tail, v) * sqrt(s1^2 / n1 + s2^2 / n2)


#27
n1 <- 26
n2 <- 22
x1 <- 5.07
x2 <- 6.58
s1 <- 1.84
s2 <- 2.91


t <- (x1 - x2)/sqrt(s1^2 / n1 + s2^2 / n2)

v = ((s1^2/n1 + s2^2/n2)^2)/((s1^2/n1)^2/(n1-1) + (s2^2/n2)^2/(n2-1))

result <- ifelse(t <= 0, pt(t,v)*2, (1 - pt(t,v))*2)


pt(t,v)

1- pt(t,v)


  
