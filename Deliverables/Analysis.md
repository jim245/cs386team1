#  Project Analysis

Problem Statement <br>
The problem of boring level design and sluggish gameplay affects casual gamers and serious gamers alike, the impact of which is games being unable to retain a playerbase and gamers being unwilling to invest time in the game to compete for high scores. (Needs solution??) <br>

Product Position Statement <br>
For gamers who are siting at their computers bored out of their minds, Go Forth! is a game centered around 2d platforming that has engaging competitive gameplay with a leaderboard. Unlike most other platformers or games in general, out product has an innate speedrunning leaderboard to test your skills against all other players. <br>


## Classes
- Player
- Platform
	- Moving platform
	- Obstacles
- Collectables
	- Power-ups
	- Coins
- Block entity
- Leaderboard

## Model
Provide the conceptual model of your system as a UML class diagram. Represent proper cardinalities (multiplicities) for all associations. Also include the association names. 
 
Some points to consider:

Use UML adequately. Do not use graphical elements that are not part of the language. Represent compositions and aggregations when relevant.
This model is not an ER diagram (entity-relationship model), which is focused on relational database systems. However, both diagrams have similarities.
Do not overcomplicate how you represent the elements of your model (e.g., using inheritance or an association when they are not necessary). Pay attention to simplicity, maintainability, unnecessary repetition, cohesion, and coupling.
Do not represent actions that don’t need to be registered in the system.
Do not represent technical elements, such as user interface or programming language libraries in the model. At this point, we are modeling the business logic/domain of your system. During the design phase, the model will be refined to include technology-specific elements and decisions.
Do not represent "System" as a class in your model. Everything that you are modeling is part of the system.
If you feel the need to justify your decisions, you can write your rationale in this section or as UML comments in the diagram.
The model must have at least 8 classes. You can add requirements in the system description if you need more classes. 
Grading criteria: You should correctly use the UML specification. Your model should have the minimum number of classes. Your domain should be adequately modeled. The model should avoid unnecessary complexity, repetition, lack of cohesion, and coupling. The classes should be at an adequate abstraction level.
