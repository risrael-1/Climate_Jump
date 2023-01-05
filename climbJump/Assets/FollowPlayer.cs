using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.y - player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = player.position.y + offset;
        transform.position = pos;
    }
}
