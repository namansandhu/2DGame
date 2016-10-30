using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManage : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene (scene);

    }
}
