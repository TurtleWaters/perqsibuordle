using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hellSceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
