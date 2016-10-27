/*
 * Author Name:Ramandeep Singh Sandhu
 * Student ID:100993238
 * Date Created:24 October,2016
 * Last date modified:29 October,2016
 * Program description:All the controls of player are maintained in this script.It control the movement of player by using W,A,S,D keys or you can even use arrow.
    Moreover, certain boundries are also set the player so that it does not go offset.
 */
 using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float speed = 80f;

    private Transform _transform;
    private Vector2 _cuurentposition;
    private float _playerInput;
    private float _playerInput2;

	// Use this for initialization
	void Start () {

        _transform = gameObject.GetComponent<Transform>();
        _cuurentposition = _transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        _playerInput = Input.GetAxis ("Horizontal");
        _playerInput2 = Input.GetAxis("Vertical");
        _cuurentposition = _transform.position;

        //move right
        if (_playerInput > 0)
        {
            _cuurentposition += new Vector2(speed, 0);
        }

        //move left
        if (_playerInput < 0)
        {
            _cuurentposition -= new Vector2(speed, 0);
        }


        //move up
        if (_playerInput2 > 0)
        {
            _cuurentposition += new Vector2(0, speed);
        }

        //move down
        if (_playerInput2 < 0)
        {
            _cuurentposition -= new Vector2(0, speed);
        }

        //fixed bounds
        checkBounds();
        _transform.position = _cuurentposition;
    }

    private void checkBounds()
    {
        if(_cuurentposition.x < -68.0f)
        {
            _cuurentposition.x = -68.0f;
        }
        if (_cuurentposition.x > 68.0f)
        {
            _cuurentposition.x = 68.0f;
        }
        if (_cuurentposition.y < -24.5f)
        {
            _cuurentposition.y = -24.5f;
        }
        if (_cuurentposition.y > 22.4f)
        {
            _cuurentposition.y = 22.4f;
        }
    }
}

