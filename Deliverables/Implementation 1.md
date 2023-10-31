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
[![Go Forth! Demo](data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAT4AAACfCAMAAABX0UX9AAAAeFBMVEX/////AAD/8fH/Jib/+vr/eXn/vr7/hob/RUX/c3P/UVH/VVX/9/f/3d3/qqr/19f/paX/bGz/MTH/Pj7/mZn/Skr/5eX/29v/zc3/x8f/t7f/n5//j4//fn7/Xl7/Tk7/IyP/GBj/DQ3/sbH/Nzf/u7v/YWH/KyuEdAApAAADjElEQVR4nO3da3OiMBSHcctVK16qFUG8212+/zdcsN0VOt12yImexj6/l95m8h+EcBKSXg8AAAAAAAAAAAAAAADAxxLP89JllkeVVVGs43gThuGgsn2s7Ur/Tbk7v7Ct36s+sonjdVGs6u/l2TKtfibRbsttBGk6iVan9WC4mM9Kf78/HB+Ejof93i9n88VwsD6tokmaBtqtvIJklE/DXd8/SOP6ysHv78JpPrqjAzLJw/61Y3uvH+b3kWAwnt86u1fz8R38jycznfBqs4l266WmeuHVptrtlwl103t4CLUTkFBPz+n8nrWzqz1rp2Aq007uVaadg5lAqcPy3tzN/ovyRffCzctvqR3bX6V2EiZy7dQucu0sDAy0Q7sYaGdhQFyLsueonUV3qXZmTal2Gp2NtSNrGmun0VmsHVlTrJ1GZ1vtyJq22ml0pp1Ym3YaXQXagbW5dt820Q6szbWyc6QdWFuknUdHhXZgbYV2Hh1ttANr22jn0dE3KNM3uVayX2gH1rbQzqMj04LB8TrDwq4VDYzbmT5fpVSjnUc3nnE7vV76ZDG2y8+6xLxcVbczsz+jyK2SlflNx+thcjrYS+7MrdsOaXzWh9jdis98nOjfScqz2nV0a7ToZNzOxjl+MrQX30kvCwPmf73WJTJ6sRWfWzNdzEv17R5GsD7Yic+tcr2t+KoukJ3x4p8aX3UKfCQ+QXy93q/9D4vP/L7r47srcfX16cYByNiOr5cIe4FuxWc+yvvfe/vRb0l8To30BuYd3k9KI5FguurQqaHKq8TXS6bG15DhzZpuQWBeq/+8MOeZDkEtXDr6AvOC3Vd1zZHZgd0nvjeRT3yC+Izm7BNfQ9p51j7xXXD0CeLj3CeI70dceen3iXDXIcE9rwwVFxHqfSJUm0UY6xBhpE2EcV4RZhmIMMdFhBlWIszvE2F2qQhzm0WEM+vtL9/k1sx6nuuQMW0mTxWd8UybCE9UivA8rwhPk4uwloEIK2mIsI6LCKsIyWgH1qadRmesoCbC+n0irB4pwtqlMqycK8K6zSKsGi7DmvUi7Jggwn4dMuwWI8NeRTLfoGTvWpm+RT0/p9NTv/y6edFtYI9KGXZIFWJ/Xil2h7aAvcntSTzPS5dZXu9wvyqKdRxvwjAcVLaPtV3pvyl35xe29XvVRzZxvC6KVf29PFum1c/c46EGAAAAAAAAAAAAAAAA2PEHSodX2ofU5XMAAAAASUVORK5CYII=)](https://youtu.be/vG1ObzDUziE)

