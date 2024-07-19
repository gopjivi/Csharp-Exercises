// See https://aka.ms/new-console-template for more information
using ClassPlay;

SportsPlayer sportsPlayer = new SportsPlayer();
sportsPlayer.PlayerId = 1;
sportsPlayer.PlayerName = "karpagam";
sportsPlayer.YearsOfPlaying = 5;
sportsPlayer.SportsName = "VollyBalll";
sportsPlayer.Age = 33;

sportsPlayer.GetPlayerDetais();

SportsPlayer sportsPlayer2 = new SportsPlayer();
sportsPlayer2.PlayerId = 2;
sportsPlayer2.PlayerName = "hanu";
sportsPlayer2.YearsOfPlaying = 2;
sportsPlayer2.SportsName = "VollyBalll";
sportsPlayer2.Age = 4;

sportsPlayer2.GetPlayerDetais();


SportsPlayer sportsPlayer3 = new SportsPlayer(3,"samu","vollyball",3,9);

sportsPlayer3.GetPlayerDetais();
