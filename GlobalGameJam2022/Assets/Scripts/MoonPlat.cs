using UnityEngine;

public class MoonPlat : MonoBehaviour
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
        if (day == false)
        {
            rend.enabled = true;
            box.enabled = true;
        }
        else
        {
            rend.enabled = false;
            box.enabled = false;

        }
    }
}
