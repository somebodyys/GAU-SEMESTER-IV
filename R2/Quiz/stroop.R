#load stroop
stroopData <- read_xls("stroop.xls")

#1
mean(stroopData$words)
#2
mean(stroopData$colors)
sd(stroopData$colors)

#3 Box Plot Male vs Female (colors)
boxplot(
  stroopData$colors[stroopData$gender == 1],
  stroopData$colors[stroopData$gender == 2],
  names = c("Female", "Male"),
  horizontal = T,
  main="Color test by gender",
  xlab="Time Needed to read"
)

#4 library(aplpack)
stem.leaf.backback(
  stroopData$colors[stroopData$gender == 1],
  stroopData$colors[stroopData$gender == 2]
)

#5
stem.leaf(stroopData$interfer)

#6
plot(
  stroopData$words,
  stroopData$colors,
  xlab = "Words",
  ylab = "Colors"
)
abline(lm(stroopData$colors~stroopData$words))

#7
cor(stroopData$words, stroopData$colors)

#8 order by colors
stroopOrdered <- stroopData[order(stroopData$colors),]
cor(stroopOrdered$words[1:23], stroopOrdered$colors[1:23])

#9
t.test(
  stroopData$colors[stroopData$gender == 1],
  stroopData$colors[stroopData$gender == 2],
)


#10 confidence interval 95%
#version 1
confidence <- 95
tail <- (1 - confidence/100)/2 + confidence /100
size <- length(stroopData$interfer)
mean(stroopData$interfer) + c(-1,1) * (qt(tail, size - 1)* sd(stroopData$interfer))/sqrt(size)

#version 2
t.test(stroopData$interfer)

#11
t.test(
  stroopData$colors,
  stroopData$interfer
)