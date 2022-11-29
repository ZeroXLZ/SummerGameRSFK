using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCrossWalk : MonoBehaviour
{
    public Cars cars1;
    public Cars cars2;
    public Car[] cars;
    private bool turnL = false;
    private bool turnR = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            foreach (Car car in cars)
            {
                if (Mathf.Abs(transform.position.z - car.transform.position.z) < 5f)
                {
                    car.speed = 0f;
                }
            }
        }
        if(other.gameObject.transform.eulerAngles.y < 90)
        {
            turnL = true;
        }
        if (other.gameObject.transform.eulerAngles.y > 90)
        {
            turnR = true;
        }
    }
    public bool[] getBools()
    {
        return new bool[] {turnL,  turnR};
    }
    private void OnTriggerExit(Collider other)
    {
        foreach (Car car in cars)
            car.speed = 0.2f;
        if(!turnL || !turnR)
        {
            PracticeFail fail = new PracticeFail();
            StartCoroutine(fail.restart(0.1f));
        }
    }
}
