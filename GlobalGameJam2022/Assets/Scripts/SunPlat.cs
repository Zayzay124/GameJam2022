using UnityEngine;

public class SunPlat : MonoBehaviour
{
    public GameObject player;
    private bool day;

    public Renderer rend;
    public Collider2D box;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        day = player.GetComponent<PlayerControl>().isDay;
        if (day==false)
        {
            rend.enabled = false;
            box.enabled = false;
        }
        else
        {
            rend.enabled = true;
            box.enabled = true;

        }
    }
}
