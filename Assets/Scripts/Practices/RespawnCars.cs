using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCars : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject car = other.gameObject;
        if (car.transform.rotation.y == 0)
        {
            car.transform.rotation = new Quaternion(car.transform.rotation.x, 180, car.transform.rotation.z, car.transform.rotation.w);
            car.transform.position = GameObject.Find("CarsSpawner2").transform.position;
        }
        else
        {
            car.transform.rotation = new Quaternion(car.transform.rotation.x, 0, car.transform.rotation.z, car.transform.rotation.w);
            car.transform.position = GameObject.Find("CarsSpawner1").transform.position;
        }
    }
}
