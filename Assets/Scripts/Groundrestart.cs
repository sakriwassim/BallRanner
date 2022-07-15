using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Groundrestart : MonoBehaviour
{
   
    void OnTriggerEnter()
    {

        SceneManager.LoadScene("MainScene");

    }

}
