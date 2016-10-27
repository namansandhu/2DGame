/*
 * Author Name:Ramandeep Singh Sandhu
 * Student ID:100993238
 * Date Created:24 October,2016
 * Last date modified:29 October,2016
 * Program description: Te controls of enemy are maintained by this script.All the enemies move from right to left in a repetion mode at certain speed.
    The boundries for enemies are also fixed so that the remainin the main screed.
 */
using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    [SerializeField]
    private Vector2 speed = Vector2.zero;

    private Transform _transform;
    private Vector2 _currentposition;

    //direction: posititve to move right and negative to move left
    private int direction = 1;


	// Use this for initialization
	void Start () {
        _transform = gameObject.GetComponent<Transform>();
        _currentposition = _transform.position;
        Reallocate();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        _currentposition = _transform.position;
        Vector2 currSpeed = new Vector2(speed.x, direction * speed.y);
        _currentposition -= currSpeed;
        _transform.position = _currentposition;


        if(_currentposition.x <= -65.7)
        {
            Reallocate();
        }
	}

    public void Reallocate()
    {
        _currentposition = new Vector2(72, Random.Range(22.3f, -22.2f));
         _transform.position = _currentposition;
    }
}