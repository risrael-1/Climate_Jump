using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float offset;


    void Start()
    {
        offset = transform.position.y - player.position.y;
    }

    void Update()
    {
        if(player.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = newPosition;
        }

        if(player.position.y < (player.position.y - 10))
        {
            SceneManager.LoadScene("Menu");
        }

    }
}
