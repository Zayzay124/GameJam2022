using UnityEngine;

public class MoonPlat : MonoBehaviour
{
    private bool day;

    public Renderer rend;
    public Collider2D box;

    PlayerControl time;

    void Start()
    {
        time = FindObjectOfType<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        day = time.GetComponent<PlayerControl>().isDay;
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
