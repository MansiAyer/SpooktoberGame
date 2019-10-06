using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {
    Vector3 dir = Vector3.forward;
    GameObject player;
    
    

    // Use this for initialization
    void Start ()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //constantly moving
        transform.Translate(dir * Time.deltaTime * 1.3f);

        //endless path
       

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            
            dir = Vector3.right;
            
        }


        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
           
            dir = -Vector3.forward;    // '-up' means 'down'
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            
            dir = -Vector3.right; // '-right' means 'left'
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            
            dir = Vector3.forward;
        }
    }

   
}
