/*
 * Author Name:Ramandeep Singh Sandhu
 * Student ID:100993238
 * Date Created:24 October,2016
 * Last date modified:29 October,2016
 * Program description:This program is used to restart the game after the health become zero.I 
 */
 using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

    //Restart the game from scene1
    public void RestartGame()
    {
        Application.LoadLevel("scene1");
    }
}
