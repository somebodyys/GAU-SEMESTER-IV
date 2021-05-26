#load TV Data
tvData <- read_xls("tv.xls")

#1
mean(tvData$TVHOURS)
max(tvData$TVHOURS) - min(tvData$TVHOURS)

#2
boxplot(tvData$TVHOURS)

#3
mean(tvData$TVHOURS[tvData$TVHOURS < 8])

#4
cor(
  tvData$TVHOURS,
  tvData$OBEDIENC
)

cor(
  tvData$TVHOURS,
  tvData$ATTITUDE
)

#5
table(tvData$ATTITUDE)
