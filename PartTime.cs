using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTime : Employee
{

    public float hoursWorked;
    public float hourlyRate;
    
    public override void CalculateMonthlySalary()
    {
       Debug.Log(hoursWorked * hourlyRate);    
    }


}