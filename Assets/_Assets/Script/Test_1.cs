using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Data : MonoBehaviour
{
    [SerializeField] private int myInt = 10;
    [SerializeField] private float myFloat = 5.75f;
    [SerializeField] private double myDouble = 19.0;
    [SerializeField] private bool myBool = true;
    [SerializeField] private char myChar = 'A';
    [SerializeField] private string myString = "Nguyen trung hIeu";
    [SerializeField] private int sum;
    [SerializeField] private int difference;
    [SerializeField] private int product;
    [SerializeField] private int quotient;
    [SerializeField] private int remainder;


    [SerializeField] private int select = 3;

    void Start()
    {
        sum = 10 + 5;
        difference = 10 - 5;
        product = 10 * 5;
        quotient = 10 / 5;
        remainder = 10 % 4;

        Debug.Log("Ten cua ban la:" + myString);

        Debug.Log("Sum: " + sum);
        Debug.Log("Difference: " + difference);
        Debug.Log("Product: " + product);
        Debug.Log("Quotient: " + quotient);
        Debug.Log("Remainder: " + remainder);

        switch(select){
            case 1:
                {
                    Debug.Log("Day one");
                    break;
                }
            case 2:
                {
                    Debug.Log("Day three");
                    break;
                }
            case 3:
                {
                    Debug.Log("Day firve");
                    break;
                }
            default:
                {
                    Debug.Log(" select False ");
                    break;
                }
        } 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}