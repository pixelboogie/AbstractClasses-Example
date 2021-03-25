using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTime : Employee
{

    public int salary;

    public override void CalculateMonthlySalary()
    {
        Debug.Log(salary/12);
    }



}
