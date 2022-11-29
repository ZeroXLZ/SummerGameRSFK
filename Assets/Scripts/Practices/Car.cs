using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed { get; set; }
    public Car(float speed)
    {
        this.speed = speed;
    }
    public Car()
    {
        this.speed = 0f;
    }
}
