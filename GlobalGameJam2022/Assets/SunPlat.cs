using UnityEngine;

public class SunPlat : MonoBehaviour
{
    public GameObject player;
    private bool day;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        day = player.GetComponent<PlayerControl>().isDay;
        if (day==false)
        {
            gameObject.SetActive(false);
        }
    }
}
