/*
 * Author Name:Ramandeep Singh Sandhu
 * Student ID:100993238
 * Date Created:24 October,2016
 * Last date modified:29 October,2016
 * Program description:This script is used to detect the collision and make changes in the health and points.
    On collision with gold, the points will increment and on collision with heath the health will decrement.
 */
using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

    [SerializeField]
    GameObject expolsion = null;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Gold")
        {

            Debug.Log("Collision with " + col.gameObject.tag);
            Player.Instance.Points++;
        }

            else if (col.gameObject.tag == "Enemy")

        {
            Debug.Log("Collison With " + col.gameObject.tag);

            //Update health
            Player.Instance.Health = Player.Instance.Health - 10;

            //show explosion
            GameObject ex = Instantiate(expolsion);
            ex.transform.position = col.transform.position;

            EnemyController sp = col.gameObject.GetComponent<EnemyController>();

            //Play explosion sound
            AudioSource asrc = gameObject.GetComponent<AudioSource>();
            if (asrc != null)
            {
                asrc.Play();
            }
            if (sp != null)
            {
                 //reallocate
                sp.Reallocate();
            }
        }
    }
}
