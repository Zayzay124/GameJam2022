using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    GameManager sceneloader;
    

    // Start is called before the first frame update
    void Start()
    {
        sceneloader = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        sceneloader.LoadNextScene();
        Debug.Log("hit");
    }
}
