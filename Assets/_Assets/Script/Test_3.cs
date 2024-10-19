using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_3 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Game object Awake");
    }
    void Start()
    {
        Debug.Log("Game Started");

        Debug.Log("This is a log message.");
        Debug.LogWarning("This is a warning message.");
        Debug.LogError("This is an error message.");


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
        }

        Debug.Log("Time since start: " +Time.time);
        Debug.Log("Time between frams: " +Time.deltaTime);

    }
}
