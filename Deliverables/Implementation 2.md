# Implementation 2

## Introduction
For gamers looking for a thrilling experience and serious gamers seeking a competitive edge, Go Forth! is a 2D platforming game that offers a lively gameplay experience through its distinct speedrunning leaderboard. The leaderboard and built-in timer promote a fast-paced, engaging environment that encourages competition among players. In-game, players can choose between the quickest route through the level, or the potential for a power-up that will save them time in future levels. This system allows players to pick a playstyle that works best for each individual. Go Forth! ensures that boredom and sluggish gameplay are replaced with excitement and the motivation to achieve top rankings, ultimately reinvigorating the gaming community and increasing player retention. As of now, our game contains an initial level that showcases the player's movement and the obstacles they must surpass. View our project on GitHub [here](https://github.com/jim245/cs386team1). <br>


## Implemented Requirements
Requirement: As a casual gamer, I want checkpoints in levels so that I can play the game without worrying too much. <br>
Issue: [https://github.com/jim245/cs386team1/issues/2](https://github.com/jim245/cs386team1/issues/2) <br>
Pull request: [https://github.com/jim245/cs386team1/pull/38](https://github.com/jim245/cs386team1/pull/38) <br>
Implemented by: Andrew Angus <br>
Approved by: Jack Watson <br>
Print screen: <br> ![image](https://github.com/jim245/cs386team1/assets/101908863/cc08d89b-837c-4389-a72e-8c163bf22fc9)

Requirement: As a Gamer, I want power-ups so that I can change the way I play the game. <br>
Issue: [https://github.com/jim245/cs386team1/issues/5](https://github.com/jim245/cs386team1/issues/5) <br>
Pull request: [https://github.com/jim245/cs386team1/pull/33](https://github.com/jim245/cs386team1/pull/33)<br>
Implemented by: Jade Meskill <br>
Approved by: Andrew Angus <br>
Print screen: <br> ![](https://github.com/jim245/cs386team1/assets/102260172/cc8bf9ec-c201-49e9-a489-371e94af41d8)

Requirement: As a gamer, I want coins in the game so that the scoring system in more in depth and variable. <br>
Issue: [https://github.com/jim245/cs386team1/issues/44](https://github.com/jim245/cs386team1/issues/44) <br>
Pull request: [https://github.com/jim245/cs386team1/pull/41](https://github.com/jim245/cs386team1/pull/41) <br>
Implemented by: Jack Watson <br>
Approved by: Zach Trusso <br>
Print screen: <br> ![alt text](https://github.com/jim245/cs386team1/blob/main/Deliverables/ScreenShotOfCoin.png?raw=true)

## Tests
Framework: Unity Test Framework (NUnit) <br>
Link: [here](https://github.com/jim245/cs386team1/tree/main/Go%20Forth!/Assets/Tests/PlayMode) <br>
Example: An example test case is ensuring the player's respawn point is updated to the checkpoint flag's position after the player interacts with the checkpoint flag. [class](https://github.com/jim245/cs386team1/blob/main/Go%20Forth!/Assets/Scripts/CheckPointScript.cs) and [test](https://github.com/jim245/cs386team1/blob/main/Go%20Forth!/Assets/Tests/PlayMode/CheckpointTests.cs) <br>
Print screen: <br> ![image](https://github.com/jim245/cs386team1/assets/101908863/6bea17b7-80ff-43d6-b213-51de435a51a0)

## Demo
[GoForth! Demo](https://youtu.be/myu_ZIy4BQ4)

### Online Deployment
Demo: [Link to game hosted online](https://jaw847.github.io/GoForth/) <br>

## Code Quality
While we all coded slightly differently, we generally agreed on certain principles. Generally, we looked to external resources for inspiration for our features and code, which also introduced some variability. Camelcase was the primary naming convention, for both variables and function names. Thorough commenting ensured readability and the ability to interpret code written by others. Objects in the Unity Engine were also named with camelcase, but also sorted properly into folders. 

## Lessons Learned
Our team learned that we need more communication between the team members, and we need to start the deliverable earlier in the week. We will make changes, so we have meetings at times when all members can attend and members will make sure to check discord more often. For the actual coding, we've gotten a bit more familiar with C# once again, and are getting more used to the unity engine and the features it has. We've gotten more familiar with different test units, in particular ones different from class since it uses C# not Python. We're also trying to cut down on the lines of code we use in each class and make things run better and make it easier to add things later on, even if it doesn't help right this second.<br>
