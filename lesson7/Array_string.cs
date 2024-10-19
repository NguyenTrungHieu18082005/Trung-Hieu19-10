using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_string : MonoBehaviour
{
    [SerializeField] private int[] numbers = new int[5];

    [SerializeField] private string message;
    [SerializeField] private string greeting;
    [SerializeField] private string Name;
    [SerializeField] private string NameI;
    [SerializeField] private string welcome;
    [SerializeField] private string Surname;
    [SerializeField] private string Add;
    void Start()
    {
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;



        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log("Element " + i + ": " + numbers[i]);
        }

        message = "Hello, Unity!";

        greeting = "Hello, " + "World!";
        // String Interpolation
        Name = "Unity";
        NameI = "Nguyen Trung Hieu";
        Surname = "Hup";
        welcome = $"Welcome to {Name} programming!";
        Add = $"Xin chào đến với {Name + Surname} toi la {NameI}";

        Debug.Log(message);
        Debug.Log(greeting);
        Debug.Log(welcome);
        Debug.Log(Name + Surname);
        Debug.Log(Add);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
