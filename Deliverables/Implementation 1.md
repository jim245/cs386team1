# Implementation 1

## Introduction
For gamers looking for a thrilling experience and serious gamers seeking a competitive edge, Go Forth! is a 2D platforming game that offers a lively gameplay experience through its distinct speedrunning leaderboard. The leaderboard and built-in timer promote a fast-paced, engaging environment that encourages competition among players. In-game, players can choose between the quickest route through the level, or the potential for a power-up that will save them time in future levels. This system allows players to pick a playstyle that works best for each individual. Go Forth! ensures that boredom and sluggish gameplay are replaced with excitement and the motivation to achieve top rankings, ultimately reinvigorating the gaming community and increasing player retention. As of now, our game contains an initial level that showcases the player's movement and the obstacles they must surpass. View our project on GitHub [here](https://github.com/jim245/cs386team1). <br>

## Implemented Requirements
NOTE: We have not reached any of the user stories and issues created in the second Deliverable, however we created new issues to account for the features we have added so far. <br>

Requirement: As a Gamer, I want to control the character using a keyboard so that I can navigate the game.<br>
Issue: [https://github.com/jim245/cs386team1/issues/17](https://github.com/jim245/cs386team1/issues/17)<br>
Pull request: [https://github.com/jim245/cs386team1/pull/10](https://github.com/jim245/cs386team1/pull/10)<br>
Implemented by: Andrew Angus<br>
Approved by: Andrew Angus (before realizing PRs had to be approved)<br>
Print screen: <br> ![image](https://github.com/jim245/cs386team1/assets/101908863/d8255cf7-7c6c-416f-849c-29695e08df14)

Requirement: As a Gamer, I want spike obstacles within the levels so that precise movement is required to reach the end.<br>
Issue: [https://github.com/jim245/cs386team1/issues/14](https://github.com/jim245/cs386team1/issues/14)<br>
Pull request: [https://github.com/jim245/cs386team1/pull/15](https://github.com/jim245/cs386team1/pull/15)<br>
Implemented by: Jade Meskill<br>
Approved by: Jack Watson<br>
Print screen: <br> ![image](https://github.com/jim245/cs386team1/assets/101908863/37708820-c57f-489e-a43f-f9e23d25ed58)

Requirement: As a Competitive Gamer, I want to track my score during a level so that I can replay levels trying to improve my score.<br>
Issue: [https://github.com/jim245/cs386team1/issues/18](https://github.com/jim245/cs386team1/issues/18)<br>
Pull request: [https://github.com/jim245/cs386team1/pull/12](https://github.com/jim245/cs386team1/pull/12)<br>
Implemented by: Colin MacDonald<br>
Approved by: Andrew Angus<br>
Print screen: <br>

Requirement: As a Gamer, I want a title screen before starting the game so that I can see the name of the game before starting.<br>
Issue: [https://github.com/jim245/cs386team1/issues/19](https://github.com/jim245/cs386team1/issues/19)<br>
Pull request: [https://github.com/jim245/cs386team1/pull/13](https://github.com/jim245/cs386team1/pull/13)<br>
Implemented by: Andrew Angus<br>
Approved by: Colin MacDonald<br>
Print screen: <br> ![image](https://github.com/jim245/cs386team1/assets/101908863/55e4703a-601b-45ff-b6d6-ad0e29649798)

Requirement: As a Gamer, I want level one to be creative so that replaying the game feels exciting.<br>
Issue: [https://github.com/jim245/cs386team1/issues/21](https://github.com/jim245/cs386team1/issues/21)<br>
Pull request: [https://github.com/jim245/cs386team1/pull/16](https://github.com/jim245/cs386team1/pull/16)<br>
Implemented by: Jack Watson<br>
Approved by: Jack Watson (before realizing PRs had to be approved)<br>
Print screen: <br>

Requirement: As a Gamer, I want an in-game timer, so I can see how fast I complete a level.<br>
Issue: https://github.com/jim245/cs386team1/issues/23 <br>
Pull request: https://github.com/jim245/cs386team1/pull/22 <br>
Implemented by: Zach Trusso<br>
Approved by: Colin MacDonald<br>
Print screen: <br> ![image](https://github.com/jim245/cs386team1/assets/101908863/811bbee4-bc06-45a0-8bed-51567494a645)

## Tests
Framework: Unity Test Framework (NUnit) <br>
Link: [here](https://github.com/jim245/cs386team1/tree/main/Go%20Forth!/Assets/Tests/PlayMode) <br>
Example: An example test case is testing the player's jump function. [class](https://github.com/jim245/cs386team1/blob/main/Go%20Forth!/Assets/Scripts/PlayerMovement.cs) and [test](https://github.com/jim245/cs386team1/blob/main/Go%20Forth!/Assets/Tests/PlayMode/MovementTest.cs) <br>
Print screen: The tests are not functioning properly as of now due to an issue connecting to an instance of an object. The current output is: <br> ![image](https://github.com/jim245/cs386team1/assets/101908863/94e1d6d2-cd57-48f4-a708-56bd92df6bf1)


## Adopted Technologies
Unity - Used for the basics of creating the game, easiest to use for a group.<br>
GitHub (GitHub Desktop) - Used to share working versions of the game and build on it in turns. <br>

## Learning/Training
YouTube Videos - Primary learning source, varied tutorials with in depth guides. <br>
Internet Research - Websites can provide valuable resources for specific issues. <br>

## Deployment
A simple dummy leaderboard in Markdown currently, likely HTML in the future, located [here](https://jim245.github.io/cs386team1/) <br>

## Licensing
We decided on the GNU GPL License v3.0, as the code can be seen and improved on by others, while also retaining basic copyrights. While it could theoretically be used commercially, we aren't doing this to make any money in the first place. 

## README File
[README](../README.md) <br>
[CONTRIBUTING](../CONTRIBUTING.md) <br>
[LICENSE](../LICENSE) <br>
[CODE_OF_CONDUCT](../CODE_OF_CONDUCT.md) <br>

## Look & Feel
Extremely simple 8 directional movement with a pixelated background. Movement will be improved as the project continues but for now it is smooth but simple. <br>

## Lessons Learned
Basic unity features, adding objects and applying attributes to them. Additionally, we also are learning bits and pieces of C# as a byproduct of using Unity as our game engine. <br>

## Demo
[![Go Forth! Demo](data:image/jpeg;base64,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)](https://youtu.be/vG1ObzDUziE)

