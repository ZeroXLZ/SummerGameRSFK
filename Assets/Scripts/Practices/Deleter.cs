using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleter : MonoBehaviour
{
    private int numCars = 1;
    public GameObject spawn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Car"))
        {
            Destroy(other.gameObject);
            numCars = spawn.GetComponent<SpawnCars>().getCars() - 1;
            spawn.GetComponent<SpawnCars>().setCars(numCars);
        }
    }
}
