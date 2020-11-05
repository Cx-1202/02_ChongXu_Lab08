using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    int spacebar = 0;
    public GameObject scoretext;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space))
        {
            scoretext.GetComponent<Text>().text = "SpaceBar : " + spacebar;
            spacebar++;
        }
    }
}    
