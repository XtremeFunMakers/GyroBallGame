using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject rStartGameObject;
    public GameObject levelCompGB;
    public GameObject jumpButton;

    private Restart rStart;
    // Start is called before the first frame update
    void Start()
    {
        rStart = rStartGameObject.GetComponent<Restart>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            
            Debug.Log("fin");
            //game win template
            jumpButton.SetActive(false);
            levelCompGB.SetActive(true);
            
            
        }
    }

} 