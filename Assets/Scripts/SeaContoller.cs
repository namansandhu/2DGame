/*
 * Author Name:Ramandeep Singh Sandhu
 * Student ID:100993238
 * Date Created:24 October,2016
 * Last date modified:29 October,2016
 * Program description:This program is used to control the movement of background.The background move from right to left at fixed speed.
 */
using UnityEngine;
using System.Collections;

public class SeaContoller : MonoBehaviour {

    [SerializeField]

    private float speed = 0.6f;
    Vector2 offset;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;

    }
}
