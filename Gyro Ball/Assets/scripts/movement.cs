using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float mov_x = 0f;
    private Transform tr;
    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        mov_x = Input.GetAxis("Horizontal");

        tr.transform.Rotate(0,0,-Input.acceleration.x * speed * Time.deltaTime);
        tr.transform.Rotate(0,0,-mov_x * speed * Time.deltaTime);

    }
}
