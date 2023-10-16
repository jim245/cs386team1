# Project Requirements

## 1. Positioning

### Problem Statement
The problem of boring level design and sluggish gameplay affects casual gamers and serious gamers alike, the impact of which is
games being unable to retain a playerbase and gamers being unwilling to invest time in the game to compete for high scores.

### Product Position Statement
For gamers who are siting at their computers bored out of their minds, *Go Forth!* is a game centered around 2d platforming that has engaging competitive gameplay with a leaderboard. Unlike most other platformers or games in general, our product has an innate speedrunning leaderboard to test your skills against all other players. 

### Value Proposition
For casual gamers looking for a thrilling experience and serious gamers seeking a competitive edge, Go Forth! is a 2D platforming game that offers a lively gameplay experience through its distinct speedrunning leaderboard. Our product distinguishes itself from other platformers and games by providing a fast-paced and engaging competitive environment where players can test their skills and compete for high scores. The built in timer and leaderboard enables competition between players and promotes innovation in their playstyle. 


Go Forth! ensures that boredom and sluggish gameplay are replaced with excitement and the motivation to achieve top rankings, ultimately reinvigorating the gaming community and increasing player retention.

### Customer Segment

## 2. Stakeholders
- Casual gamers – targeted to combat boredom
- Competitive gamers – targeted for leaderboard and for fun challenging game
- Publisher – once we finish developing we need someone in charge of releasing the game
- Potential Investors – we will need investors to back the game, so we can add all the necessary features
(Try to get subsections of gaming marker?)

## 3. Functional requirements (features)
1. Multiple levels
2. Checkpoints in levels
3. Fluid player movement
4. Traps and/or enemies
5. Leaderboard
6. Different difficulties
7. Power-ups
8. Accessibility options
9. Achievements
10. Music
11. Sound effects
12. Secret areas/levels
13. Collectibles
14. Cosmetics
15. Different themes for each level

## 4. Non-functional requirements
1. Difficulty sliders – Ensure that players can adjust the game's difficulty level to match their skill
2. Colorblind accessibility option – Enable players with colorblindness to play the game comfortably
3. Mobile port – Make the game available and functional on mobile platforms
4. Controller support – Provide an alternative control method for players who prefer controllers
5. Frame rate – Maintain a consistent frame rate to ensure smooth gameplay
6. Monetization (skins) – Generate revenue through in-game purchases without compromising the player's experience
7. Storage requirements – Manage the game's storage space efficiently
8. Loading times – Minimize loading times to enhance the player's experience

## 5. Minimum Viable Product
A game where you can move in a 2d plane with a camera that moves with you. You can die when stepping on certain objects and get thrown back to the last spawn point.
(Test Plan)


## 6. Use Cases
![image](https://github.com/jim245/cs386team1/assets/101908863/3b1ee449-d01f-443e-a432-b93de6415228)

1. Use Case: Play the game <br>
   Actor: Casual gamer <br>
   Trigger: Casual gamer wants to have fun <br>
   Pre-conditions: Casual gamer has the game installed<br>
   Post-conditions: Player completes level
   Success Scenario: <br>
    1. Open game
    2. Start game
    3. Play game
   Alternate Scenario: <br>
    1. <br>
  
2. Use Case: Use leaderboard <br>
   Actor: Competitive Gamer <br>
   Trigger: Competitive gamer wants to compete for fast times <br>
   Pre-conditions: Competitive gamer beats the game once <br>
   Post-conditions: Competitive gamer's time is scored <br>
   Success Scenario: <br>
    1. Competitive gamer opens game <br>
    2. Competitive gamer learns game <br>
    3. Competitive gamer completes game <br>
    4. Time and score are recorded on leaderboard <br>
   Alternate Scenario: <br>
    1. Competitive beats game offline <br>
    2. Score is not sent to online leaderboard <br>

3. Use Case: Obtain power-up <br>
   Actor: Player <br>
   Trigger: Player wants to use power-ups <br>
   Pre-conditions: Player has the game installed <br>
   Post-conditions: Player obtains a power-up <br>
   Success Scenario: <br>
    1. Player opens game <br>
    2. Player searches for the power-up triggers <br>
    3. Play obtains all triggers and gets power-up<br>
   Alternate Scenario: <br>
    1. Player misses power-up trigger <br>
    2. Player does not obtain power-up <br>

5. Use Case: Difficulty Options In-game <br>
   Actor: Casual Gamer <br>
   Trigger: Casual gamers require an easier difficulty than competitive ones. <br>
   Pre-Conditions: Certain players cannot play the game at a high difficulty. <br>
   Post-Conditions: The change in difficulty increases playability. <br>
   Success Scenario: <br>
      1. A player begins the game, and plays a few levels, noting a certain difficulty level. <br>
      2. They look in the settings, find the difficulty option, and change it. <br>
      3. The game doesn't lose a player because of a difficulty roadblock. <br>
   Alternate Scenario: <br>
      1. A player begins the game, and detects a high difficulty level. <br>
      2. They have trouble or do not look for the difficulty setting. <br>
      3. They quit due to the difficulty level being too high. <br>
      4. The game loses casual players. <br>
(Apparently this one is bad because it doesn't specify difficulty settings, but it does?)

(Colorblind use case was shit, so I shot it)
(Alternate scenarios are failures, not actually alternate scenarios apparently)

## 7. User Stories
- As a casual gamer, I want checkpoints in levels so that I can play the game less intensively.
- As a speedrunner, I want a leaderboard so that I can compare my times with other people.
- As a gamer, I want power ups to make the gameplay more interactive
- As a non-gamer, I want a key bind menu, so I can know what buttons to press and change them if I need to.
- As a colorblind gamer, I want a colorblind accessibility mode, so I can enjoy the game like everyone else.
- As a competitive gamer, I want there to be enemies, so the game is more interactive and challenging.
- As a console player, I want to be able to use a controller on PC, so that I can play like I normally do.
- As someone who appreciates level design, I want a variety of levels to play, so that I can enjoy the game in many different environments.

## 8. Issue Tracker
https://github.com/jim245/cs386team1/issues
<img width="928" alt="Screenshot 2023-09-29 142309" src="https://github.com/jim245/cs386team1/assets/102260172/5e65b5bd-20e9-4ac8-b5e6-13ab861bb84d">
