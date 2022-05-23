using UnityEngine;
using System.Collections;

public class PlayerCam : MonoBehaviour
{

    private Transform player;
    public int Cam = 10;

    void Start()
    {
        player = GameObject.Find("Player_Knight").transform;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x + 2, player.position.y + 1, player.position.z - Cam);
    }
}