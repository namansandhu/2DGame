/*
 * Author Name:Ramandeep Singh Sandhu
 * Student ID:100993238
 * Date Created:24 October,2016
 * Last date modified:29 October,2016
 * Program description: As the player collide with enemy, an expolsion will occur .
    But we also need to destroy the explosion as well as the object.
    This script destroy the object.
 */
using UnityEngine;
using System.Collections;

public class ExplosionController : MonoBehaviour {

    public void End()
    {

        Destroy(gameObject);

    }
}
