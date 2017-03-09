                                                         The Pirate ship
                                                    Welcome to this 2D game

1. Detailed Description of game:
This is a 2d game which in played in the sea.The theme of the game is that we are pirates who are exploring beneath the sea and collection gold from deep sea. But, our enemies are trying to attack on us and destroy our ship so that they could prevent us from collecting the gold.
The background of game is moving from right to left.The players is contolled by us but our enemies are controled by the computer.
The game includes health of player which will reduce by 10% on collision with enemy. Moreover, as we will cross the gold, our points will increase and we will be able to collect the gold.



2. Controls Description:
you can use W,A,S and D keys to control the player.
W is used to move up, A is used to move left, S is used to move down, D is used to move right. The enemies and gold are controlled by the computer.
Our player have a pirate ship with flags on it.
The enemies are computer controlled.



3. Screen Description:
The game has a main page with play button which open when we start the game.
As you will click on play button, the game will start playing.
On collision with enemy, explosion animation will be produced and the enemy will be destroyed.
When the health of player will become zero, the game will end and will display the maximum score .You will be also able to see the restart button to start the game again.
 
 
 
4. Enemies:
There are more than one enemies which will be moving from right to left in a zigzag way.These movement of enemies make it difficult for player to prevent collision .
They are computer controlled enemies moving at different speed and on random position on y-axis.
 
 

5. Scoring
By default, the health is 100 and the points are zero.
The points will increase on collision with the gold.On each collision, one point will increase. Whereas, on each collision the health will decrease by 10%. If the health become zero, the game will over and highest points will be displayed.
  				 			 



6. Sound Index:
There is sound of ocean playing in background which will play throughout the game. On collision with enemy, blast sound effect will be played for 3 seconds to depict the explosion.
 			 



7. Functions:
The listed below are the funtions used in this game:
•	RestartGame(): This function is used to play game on clicking the button.The health of player will be reset to 100 and points will be reset to 0.
•	UpdatePoints(): In this function, the value of points is incremented on collision with gold.
•	UpdateHealth(): The health of player decrease on collision with the game.
•	Player(): In this function, various if-else and try-catch condition are used to apply all the conditions like when to display restart button, when to called updateHeath and much more.
•	GameOver(): When the health of player reduce to zero, this function will be called which will display the button and  text of gameover.



8. Download:
This  game is being uploaded on Github.
The URL to download is listed below:
https://github.com/namansandhu/2Dgame.git

                                                          ~~ Thank you ~~

