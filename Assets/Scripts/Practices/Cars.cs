using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    public GameObject spawnC;
    public Car[] cars;
    //public float speed = 0.2f;
    void Start()
    {
        StartCoroutine(spawnCars(5));
    }
    void FixedUpdate()
    {
        for(int i = 0; i < cars.Length; i++)
        {
            if(i > 0)
            {
                if (Mathf.Abs(cars[i].transform.position.z - cars[i - 1].transform.position.z) > 6f && cars[i].transform.position.x != cars[i - 1].transform.position.x)
                {
                    moveCar(cars[i].speed, cars[i]);
                } 
            }
            else
            {
                moveCar(cars[i].speed, cars[i]);
            }
        }
    }
    public void moveCar(float speed, Car car)
    {
        if (car.transform.rotation.y == 0)
        {
            car.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z + speed);
        }
        else
        {
            car.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z - speed);
        }
    }
    IEnumerator spawnCars(float time)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            yield return new WaitForSeconds(time);
            //GameObject car = cars[r.Next(0, cars.Length)];
            //Instantiate(car, spawnC.transform.position, spawnC.transform.rotation);
            cars[i].transform.position = spawnC.transform.position;
            cars[i].speed = 0.2f;
        }
    }
}
