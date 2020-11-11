using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Mov : MonoBehaviour
{

    public Rigidbody rb;
    public float JumpForce = 50;
    public Transform tr;
    public GameObject rStartGameObject;

    private Restart rStart;

    public float distToGround = 2.087f;

    public float left =11.6f ;
    public float right  =145.2f;
    public float up  =20f;
    public float down =-8.5f;

    

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        rStart = rStartGameObject.GetComponent<Restart>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            jump();
        }

        if (tr.position.y < down || tr.position.y > up || tr.position.x < left || tr.position.x > right)
        {
            //game over ui

            rStart.gameOver();
            
        }
    }
    public void jump()
    {
        if( IsGrounded() == true)
        {
            rb.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            FindObjectOfType<AudioManager>().PlaySound("Jump");
        }
            
    }
    
    

    private bool IsGrounded()
    {
        
        return Physics.Raycast(transform.position, Vector3.down, distToGround);

        
    }
}
