using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_2 : MonoBehaviour
{
     [SerializeField] private int myInt = 19;
    [SerializeField] private float myFloat = 8.96f;
    [SerializeField] private double myDouble = 19.88;
    [SerializeField] private bool myBool = false;
    [SerializeField] private char myChar = 'N';
    [SerializeField] private string myString = "NguyenTrungHieu";
    [SerializeField] private int sum;
    [SerializeField] private int difference;
    [SerializeField] private int product;
    [SerializeField] private int quotient;
    [SerializeField] private int remainder;


    [SerializeField] private int select = 3;
    // Start is called before the first frame update
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
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
