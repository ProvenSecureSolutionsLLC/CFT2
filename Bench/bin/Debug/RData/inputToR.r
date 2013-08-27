clear <- function() {rm(list=ls())}
clear()

library("mnormt")

calc.bf <- function(mean, std, score, prior, evid, postf) {
  # Calculates a new posterior distribution
  # arguments
  #   g     - genuine
  #   i     - impostor
  #   mean  - associative list with indices g,i , contains parameters for genuine/imposter dist
  #   std   - associative list with indices g,i , contains parameters for genuine/imposter dist
  #   prior - associative list with indices g,i , we currently assume a constant/uniform prior
  #   evid  - associative list with indices g,i
  #   postf - function that calculates the posterior given the mean, std, score, evid, and prior
  # returns an associative list with indices bf and post
  #   bf - calculated bayes factor
  #   post - associative list containing new posteriors for genuine and impostors
  
  post <- (list(
    g=postf(mean$g,std$g,score,evid$g,prior$g),
    i=postf(mean$i,std$i,score,evid$i,prior$i)))
  bf <- (post$g/post$i)
  
  res <- list(bf=bf,post=post)
  return(res)
}

decide.bf <- function(bf) {
  if (bf > 10) { return("PASS") } 
  else if (bf < 0.10) { return("FAIL") } 
  else { return("UNSURE") }
}

check <- function(user, score, mean, std, prior, evid, a, postf) {
  # auth_decider is a function that returns the next authenticator to try
  # postf is the function we'll be using to calculate the posterior
  #a <- 1
  decision <- "UNSURE"
  #removed While Loop
    ans <- calc.bf(mean[[a]],std[[a]],score[[a]],prior,evid,postf)
    decision <- decide.bf(ans$bf)
    print(paste(user, ", auth#", a, ":", decision,",","BF =",ans$bf,sep=" "))
    #if (decision == "UNSURE") { 
     # a     <- auth.decider(a) # choose a new authenticator somehow
     # prior <- ans$post        # and set the posterior as the new prior
    #} 
  }


check2 <- function(user, score, mean, std, evid, auth.decider, postf) {
  fn <- "899uliytre5w4e6r78t9cnzscxhvvfd.txt"
  if (file.exists(fn)) {
    history <- as.list(read.table(fn))
    print(history[1])
    file.remove(fn)
    prior <- list(g=as.numeric(history[2]),
                  i=as.numeric(history[3]))
    a <- (as.numeric(history[1]) + 1)
  } else {
    prior <- list(g=1,i=1)
    a <- 1
  }
  print(a)
  ans <- calc.bf(mean[[a]],std[[a]],score,prior,evid,postf)
  decision <- decide.bf(ans$bf)
  print(paste(user, ", auth#", a, ":", decision,",","BF =",ans$bf,sep=" "))
  if (decision == "UNSURE") {
    write(c(a,ans$post$g,ans$post$i),file=fn)
    print("file written!")
  }
}

calc.mvn.bf <- function(score,mu,sigma) {
  cov <- list(
    g=sigma$g[1:length(score),1:length(score)],
    i=sigma$i[1:length(score),1:length(score)])
  mean <- list(
    g=mu$g[1:length(score)],
    i=mu$i[1:length(score)])
  
  post <- list(
    g=dmnorm(score,mean$g,(cov$g)%*%(cov$g)),
    i=dmnorm(score,mean$i,(cov$i)%*%(cov$i)))
  bf <- (post$g/post$i)
  res <- list(bf=bf,post=post)
  return(res)
}

checkmv <- function(user, score, mean, sigma, auth.decider) {
  a <- 1
  i <- 1
  decision <- "UNSURE"
  while (decision == "UNSURE") {
    ans <- calc.mvn.bf(score[1:i],mean,sigma)
    decision <- decide.bf(ans$bf)
    print(paste(user,", auth#",a,":",decision,",","BF =",ans$bf,sep=" "))
    if (decision == "UNSURE") {
      a <- auth.decider(a)
    }
    i <- i+1
  }
}

############################ demo ############################
cat("\014") 
clear()
#naive.auth.decider <- function(a) {return(a+1)}
normal.postf <- function(mean,std,score,evid,prior) {((1/(sqrt(2*pi)*std))*exp((-1/2)*(((score-mean)/std)^2)/evid)*prior)}

# Tom's scores for various authenticators
score <- c(1.03,1.04,1.01)

# Tom's genuine/imposter (normal) distribution parameters
mean  <- list(list(g=1.01,i=-1.01),
              list(g=0.98,i=-0.98),
              list(g=1,   i=-1))
std   <- list(list(g=0.75,i=1),
              list(g=2,   i=3),
              list(g=0.3, i=0.7))

# initial conditions for Tom
prior <- list(g=1,i=1)
evid  <- list(g=1,i=1)

# Does Tom pass?
a <- 1
check("Tom",score,mean,std,prior,evid,a,normal.postf)
#check2("Tom",score,mean,std,evid,naive.auth.decider,normal.postf) #Need to make sure prior file is available for check2 function to find.

# Dick's scores for various authenticators
score <- c(0.1,0.7,1.01)

# Dick's genuine/imposter (normal) distribution parameters
mean  <- list(list(g=1.01,i=-1.01),
              list(g=0.98,i=-0.98),
              list(g=1,   i=-1))
std   <- list(list(g=0.75,i=1),
              list(g=2,   i=3),
              list(g=0.3, i=0.7))

# initial conditions for Dick
prior <- list(g=1,i=1)
evid  <- list(g=1,i=1)

# Does Dick pass?
a <- 1
check("Dick",score,mean,std,prior,evid,a,normal.postf)

a <- 2
check("Dick",score,mean,std,prior,evid,a,normal.postf)

# We should get the same results using check2
#check2("Dick",0.1,mean,std,evid,naive.auth.decider,normal.postf)
#check2("Dick",0.7,mean,std,evid,naive.auth.decider,normal.postf)
#check2("Dick",1.01,mean,std,evid,naive.auth.decider,normal.postf)

# Harry's scores for various authenticators
score <- c(-1.2,1.04,1.01)

# Harry's genuine/imposter (normal) distribution parameters
mean  <- list(list(g=1.01,i=-1.01),
              list(g=0.98,i=-0.98),
              list(g=1,   i=-1))
std   <- list(list(g=0.75,i=1),
              list(g=2,   i=3),
              list(g=0.3, i=0.7))

# initial conditions for Harry
prior <- list(g=1,i=1)
evid  <- list(g=1,i=1)

# Does Harry pass?
check("Harry",score,mean,std,prior,evid,naive.auth.decider,normal.postf)


# John's scores for various samples for authenticators
score <- c(0.5,0.5,0.5)
#score <- c(0.7,0.5,0.3)
#score <- c(0.3,0.5,0.7)

# John's genuine/imposter (normal) distribution parameters
mean  <- list(g=c(1,1,1),
              i=c(-1,-1,-1))
std   <- list(g=c(0.8,0.8,0.8),
              i=c(0.8,0.8,0.8))
sigma <- list(
            g=matrix(c(0.8,0.05,0.1,0.05,0.8,0.05,0.1,0.05,0.8),3,3),
            i=matrix(c(0.8,0.05,0.1,0.05,0.8,0.05,0.1,0.05,0.8),3,3))
# Does John pass?
checkmv("John",score,mean,sigma,naive.auth.decider)