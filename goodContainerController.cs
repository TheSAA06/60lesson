using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goodContainerController : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        SceneManager.LoadScene("scene2");
    }
}
