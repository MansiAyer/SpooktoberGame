using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class floorlord : MonoBehaviour
{
    public bool pause = false;
    public GameObject paused;
    
    
    


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
             

        //pause game
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Escape))
        {
            if (pause == false)
            {
                pause = true;
                Time.timeScale = 0f;
                paused.SetActive(true);
            }
            
            else if (pause == true)
            {
                pause = false;
                Time.timeScale = 1f;
                paused.SetActive(false);
            }
        }

    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        pause = false;
        Time.timeScale = 1f;
    }

    
}
