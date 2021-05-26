#load animals
animalData <- read_xls('animals.xls')
#1 plotting Animal Research is Wrong
boxplot(
  animalData$WRONG[animalData$GENDER == 1],
  animalData$WRONG[animalData$GENDER == 2],
  names = c("Female", "Male"),
  horizontal = T,
  main="Animal Research is wrong by gender",
  xlab="Believe strength coeficient"
)
#3
100*length(animalData$WRONG[animalData$WRONG == 7 & animalData$GENDER == 1])/length(animalData$WRONG[animalData$GENDER == 1])

#4 mean(Female) - mean(Male)
mean(animalData$WRONG[animalData$GENDER == 1]) - mean(animalData$WRONG[animalData$GENDER == 2])

#5
t.test(
  animalData$WRONG[animalData$GENDER == 1],
  animalData$WRONG[animalData$GENDER == 2]
)

#6 plotting Animal research is necessary
boxplot(
  animalData$NECESSAR[animalData$GENDER == 1],
  animalData$NECESSAR[animalData$GENDER == 2],
  names = c("Female", "Male"),
  horizontal = T,
  main="Animal Research is necessary by gender",
  xlab="Believe strength coeficient"
)

#7
100*length(animalData$NECESSAR[animalData$NECESSAR %in% c(1,2,3) & animalData$GENDER == 2])/length(animalData$NECESSAR[animalData$GENDER == 2])

#8
t.test(
  animalData$NECESSAR[animalData$GENDER == 1],
  animalData$NECESSAR[animalData$GENDER == 2]
)

#11
cor(
  animalData$WRONG,
  animalData$NECESSAR
)

plot(
  animalData$WRONG,
  animalData$NECESSAR,
  xlab = "Wrong",
  ylab = "Necessary",
  col = ifelse(animalData$GENDER == 1, "green", "blue"),
  pch = 19,
  main="Correlation Between Wrong & Necessary"
)
abline(lm(animalData$NECESSAR~animalData$WRONG))
