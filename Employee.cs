using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour
{

    public string company = "PixelBoogie";
    public string EmployeeName;

    public abstract void CalculateMonthlySalary();

    private void Start()
    {
        CalculateMonthlySalary();

    }

}


