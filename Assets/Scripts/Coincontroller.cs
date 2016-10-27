/*
 * Author Name:Ramandeep Singh Sandhu
 * Student ID:100993238
 * Date Created:24 October,2016
 * Last date modified:29 October,2016
 * Program description:This script is used to control the movement of the coins.The coins will at random from right to left.Certain boundire is set for coins so that
    they remain the frame.
 */
using UnityEngine;
using System.Collections;

public class Coincontroller : MonoBehaviour {


    [SerializeField]
    private float speed;

    private Transform _transform;
    private Vector2 _currentPosition;

    // Use this for initialization
    void Start()
    {

        _transform = gameObject.GetComponent<Transform>();
        _currentPosition = _transform.position;
        Reset();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _currentPosition = _transform.position;
        _currentPosition -= new Vector2(speed,0);
        _transform.position = _currentPosition;

        if (_currentPosition.x <= -65.7)
        {
            Reset();
        }
    }

    // Reset the position of coin for random occuring and set boundries
    private void Reset()
    {
        _currentPosition = new Vector2(72, Random.Range(22.3f, -22.2f));
        _transform.position = _currentPosition;
    }
}
