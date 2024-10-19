using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTime : MonoBehaviour
{
    [SerializeField] private DateTime now;
    [SerializeField] private DateTime specificDate;
    void Start()
    {
        now = DateTime.Now;
        specificDate = new DateTime(2024, 5, 25);
        Debug.Log("Current Date and Time: " + now);
        Debug.Log("Specific Date: " + specificDate);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
