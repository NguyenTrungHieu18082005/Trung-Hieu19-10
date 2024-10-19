using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    [SerializeField] private Vector3 vector1;
    [SerializeField] private Vector3 vector2;
    [SerializeField] private Vector3 addition;
    [SerializeField] private Vector3 subtraction;
    [SerializeField] private Vector3 multiplication;
    [SerializeField] private Vector3 division;
    void Start()
    {
        vector1 = new Vector3(1, 2, 3);
        vector2 = new Vector3(4, 5, 6);
        addition = vector1 + vector2;
        subtraction = vector1 - vector2;
        multiplication = vector1 * 2;
        division = vector1 / 2;
        Debug.Log("Addition: " + addition);
        Debug.Log("Subtraction: " + subtraction);
        Debug.Log("Multiplication: " + multiplication);
        Debug.Log("Division: " + division);

    }

    void Update()
    {

    }
}
