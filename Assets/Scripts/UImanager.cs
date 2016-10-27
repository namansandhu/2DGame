/*
 * Author Name:Ramandeep Singh Sandhu
 * Student ID:100993238
 * Date Created:24 October,2016
 * Last date modified:29 October,2016
 * Program description: the calculation of points and player script is done in this scripts. When the player will collide with enemy, the heath will decrease by 10%.
 * Similarly, when the player will cross the coins,the points will increase.The label of gameover and high score will appear when the game will be over. 
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UImanager : MonoBehaviour {


    [SerializeField]
    Text pointsLabel = null;
    [SerializeField]
    Text healthLabel = null;

    //new
    [SerializeField]
    Button restartBtn = null;
    [SerializeField]
    Text gameOverLabel = null;
    [SerializeField]
    GameObject player = null;
    [SerializeField]
    Text highScore = null;

    public void UpdatePoints()
    {

        pointsLabel.text = "Points: " + Player.Instance.Points;

    }

    public void UpdateHealth()
    {

        healthLabel.text = "Health: " + Player.Instance.Health;
    }

    // Use this for initialization
    void Start()
    {
        Player.Instance.hud = this;
        RestartGame();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void GameOver()
    {

        //hide labels with health and points
        pointsLabel.gameObject.SetActive(false);
        healthLabel.gameObject.SetActive(false);

        //deactive player
        player.SetActive(false);

        //display "Game Over" label
        gameOverLabel.gameObject.SetActive(true);
        highScore.gameObject.SetActive(true);
        highScore.text = "High Score: " + Player.Instance.HighScore;

        //display "Restart" button
        restartBtn.gameObject.SetActive(true);

    }

    public void RestartGame()
    {

        //show labels with health and points
        pointsLabel.gameObject.SetActive(true);
        healthLabel.gameObject.SetActive(true);
        Player.Instance.Points = 0;
        Player.Instance.Health = 100;
        highScore.gameObject.SetActive(false);
        //activate player
        player.SetActive(true);

        //hide "Game Over" label
        gameOverLabel.gameObject.SetActive(false);

        //hide "Restart" button
        restartBtn.gameObject.SetActive(false);

    }
}
