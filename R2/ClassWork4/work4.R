#29
n1 <- 129
x1 <- 80
n2 <- 184
x2 <- 98
p1 <- x1/n1
p2 <- x2/n2

#Intervals
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
result <- (p1 - p2) + c(-1, 1) * qnorm(tail) * sqrt((p1*(1-p1)/n1)+(p2*(1-p2)/n2))

#Calculating P
p_bar <- (x1 + x2) / (n1 + n2)
z <- (p1 - p2)/sqrt(p_bar*(1 - p_bar)*((1/n1)+(1/n2)))
result <- ifelse(z <= 0, pnorm(z)*2, 2*(1-pnorm(z)))

#For Given Alpha
alpha <- 0.05
c(1,-1) * qnorm(alpha/2)
ifelse(abs(z) > -qnorm(alpha/2), "Reject", "Don't Reject")


#27
x1 <- 84
n1 <- 112
x2 <- 66
n2 <- 108
p1 <- x1 / n1
p2 <- x2 / n2

#A
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
proportion <- x1 / n1
result <- proportion + c(-1, 1) * qnorm(tail) * sqrt(proportion * (1- proportion)/n1)

#B
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
proportion <- x2 / n2
result <- proportion + c(-1, 1) * qnorm(tail) * sqrt(proportion * (1- proportion)/n2)

#C
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
result <- (p1 - p2) + c(-1, 1) * qnorm(tail) * sqrt((p1*(1-p1)/n1)+(p2*(1-p2)/n2))


#31
prop1 <- 0.33
n1 <- 868
prop2 <- 0.41
n2 <- 811

p_bar <- ((prop1*n1) + (prop2*n2)) / (n1 + n2)
z <- (prop1 - prop2)/sqrt(p_bar*(1 - p_bar)*((1/n1)+(1/n2)))

result <- (1-pnorm(z))



