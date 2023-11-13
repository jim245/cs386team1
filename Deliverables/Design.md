# Design

## Description
<p>The problem of boring level design and sluggish gameplay affects casual gamers and serious gamers alike, the impact of which is games being unable to retain a playerbase and gamers being unwilling to invest time in the game to compete for high scores. For gamers who are siting at their computers bored out of their minds, Go Forth! is a game centered around 2d platforming that has engaging competitive gameplay with a <b>leaderboard</b>. Unlike most other platformers or games in general, our product has an innate speedrunning <b>leaderboard</b> to test your skills against all other players. For casual gamers looking for a thrilling experience and serious gamers seeking a competitive edge, Go Forth! is a 2D platforming game that offers a lively gameplay experience through its distinct speedrunning <b>leaderboard</b>. Our product distinguishes itself from other platformers and games by providing a fast-paced and engaging competitive environment where players can test their skills and compete for high scores. Go Forth! ensures that boredom and sluggish gameplay are replaced with excitement and the motivation to achieve top rankings, ultimately reinvigorating the gaming community and increasing player retention.
</p>

<p>Our game consists of multiple <b>levels</b> in which the <b>user</b> faces various obstacles and hazards while trying to reach the end. The main obstacle that the <b>user</b> encounters is a <b>spike platform</b> that results in the <b>character's</b> death. Another hazard the <b>user</b> encounters is a <b>moving platform</b>, requiring precise reactions and timing in order to reach the <b>level's</b> end unharmed. While maneuvering through the <b>level</b>, the <b>user</b> can contact <b>collectibles</b> such as <b>coins</b> and <b>PowerUps</b> that can potentially result in a faster <b>level</b> completion. Another important feature of the game is checkpoints during a <b>level</b>, giving <b>users</b> the clarity that their progress has been saved.
</p>

<p>An exhilarating aspect of our game is the existence of a <b>leaderboard</b>. When a <b>user</b> beats a singular <b>level</b> or the game, their time and score is added to the <b>leaderboard</b>, allowing competition between <b>users</b>. Because the game consists of multiple difficulties, only the most skilled and dedicated <b>users</b> will be able to see their name at the top of the <b>leaderboard</b>. 
</p>

## Architecture
![](https://github.com/jim245/cs386team1/blob/main/Deliverables/D.5%20Architecture.png)

This shows that the system is split into 2 main parts, the client and the server. The server doesn't really do anything other than maintain the leaderboard, so it is simplified into "Server.Leaderboard". The client contains the game, a Score object, and the Title Screen. The Score is the object sent out to the server to be processed and stored.

## Class Diagram

![alt text](https://github.com/jim245/cs386team1/blob/main/Deliverables/Design%20Class%20Diagram.png?raw=true)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
## Sequence Diagram
User finishes the game, submits the time to the leaderboard, and wants to see where he placed. <br>
*leaderboard isn't properly functioning yet, but there isn't much to make a use case off currently<br>
Use Case: Use leaderboard<br>
Actor: Player <br>
Trigger: Player submits time<br>
Pre-conditions: Player beats the game once<br>
Post-conditions: Player's time is submitted to the leaderboard, and ranked among other's<br>
Success Scenario:<br>

-Player opens game<br>
-Player completes game<br>
-Player submits score<br>
-Score is sent to server<br>
-Server gives back new data<br>

![image](https://github.com/jim245/cs386team1/assets/93413915/c414625b-b7c2-4479-b9bc-d8f584ea7c6c)

## Design Patterns

- Creational Singleton
![Creational Singleton](https://github.com/jim245/cs386team1/blob/main/Deliverables/Design%20Patterns%202.png?raw=true) <br>
- Structural Adapter
![Strcutural Adapter](https://github.com/jim245/cs386team1/blob/main/Deliverables/Design%20Patterns.png?raw=true)


## Design Principles
### Single-Responsibility Principle
<p>The Single-Responsibility Principle states that "a class should have one and only one reason to change, meaning that a class should have only one job." Our classes adhere to this principle in the sense that each class serves a specific responsibility. For example, the PlayerMovement class is centered around the movement of the knight sprite that is controlled by the player. To better adhere to this design principle, collision is handled in a different class, PlayerColliderHandler. Another class that focuses on a single responsibility is CheckIfFallen.</p>

### Open-Closed Principle
<p>This principle states that "objects or entities should be open for extension but closed for modification." Our classes are generally closed for modification in the sense that their responsibilities are clear. One example of a class that can be considered as closed for modification is the CheckIfFallen class. This class has a singular purpose, however further modification can be implemented to account for what level the player is on. Another class to consider is TimeController. The timer functionality of this class is closed for modification, but it might require modification if it were to be extended to handle different time-related features.</p>

### Liskov Substitution Principle
<p>The Liskov Substitution Principle indicates that "every subclass or derived class should be substitutable for their base or parent class." Our project does not currently incorporate subclasses or derived classes in a way that would demonstrate or violate the Liskov Substitution Principle.</p>

### Interface Segregation Principle
<p>This principle states that "a client should never be forced to implement an interface that it doesn’t use, or clients shouldn’t be forced to depend on methods they do not use." Once again, our scripts do not explicitly implement interfaces that can be analyzed by the Interface Segregation principle. While this is true, none of the classes have overly large interfaces that would indicate a violation of the principle.</p>

### Dependency Inversion Principle
<p>The last principle, the Dependency Inversion Principle, states that "the high-level module must not depend on the low-level module, but they should depend on abstractions." This principle is demonstrated well in our PlayerColliderHandler class and its Start method. Dependency is demonstrated by the class receiving references to the ScoreHolder and TimerController classes, following the principle by relying on abstractions instead of concrete implementations.</p>
