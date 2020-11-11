using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayerX : MonoBehaviour
{

    //getting transform of ball
    public Transform player;
    public Vector3 offset;
    Vector3 temp;

    void Start()
    {
        transform.position = player.position + offset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // transform.position = player.position + offset;  
        temp = transform.position;
        temp.x = player.position.x + offset.x;
        temp.y = player.position.y + offset.y;
        transform.position = temp;

    }
}
