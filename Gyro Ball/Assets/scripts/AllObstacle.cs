using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllObstacle : MonoBehaviour
{
    public GameObject go;
    public GameObject gp;

    
    public float Upforce = 100;
    public float Rightforce = 100;
    public float rotateSpeed = 50;
    public bool antiRotate;
    public bool isObstacle;
    
    public bool Up_boost;
    public bool Right_boost;
    public bool autorotator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (autorotator == true)
        {
            if(antiRotate == false)
            {
                gameObject.transform.Rotate(0, 0, -rotateSpeed * Time.deltaTime);
            }
            else
            {
                gameObject.transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
            }
            
        }
    }

    void Up_Boost(Rigidbody rb)
    {
        Debug.Log("jump");
        rb.AddForce(0, Upforce * Time.deltaTime, 0, ForceMode.VelocityChange);
    }
    void Right_Boost(Rigidbody rb)
    {
        Debug.Log("jump");
        rb.AddForce(Rightforce * Time.deltaTime,0, 0, ForceMode.VelocityChange);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("collide");
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (Up_boost == true)
            {
                Up_Boost(rb);
            }
            if (Right_boost == true)
            {
                Right_Boost(rb);
            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (isObstacle == true)
        {

            if (col.gameObject.tag == "Player")
            {
                gp.SetActive(false);
                go.SetActive(true);                
            }
        }
       
    }


}
