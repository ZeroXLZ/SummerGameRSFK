using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    private GameObject cars;
    private int numCars = 0;
    public int prior = 50;
    void Start()
    {
        cars = GameObject.Find("Cars");
    }
    private void FixedUpdate()
    {
        if(GetComponent<IsOnSpawn>().getIsFree())
        {
            if(numCars < 2)
                spawnCs();
        }
    }
    private void spawnCs()
    {
        GetComponent<IsOnSpawn>().setIsFree(false);
        int time;
        int randomChildIdx;
        time = new System.Random().Next(5, 10);
        randomChildIdx = new System.Random().Next(0, cars.transform.childCount);
        numCars++;
        StartCoroutine(spawn(time, randomChildIdx));
    }
    public int getCars()
    {
        return numCars;
    }
    public void setCars(int number)
    {
        numCars = number;
    }
    IEnumerator spawn(float time, int child)
    {
        Transform randomChild = cars.transform.GetChild(child);
        randomChild.gameObject.GetComponent<MoveTo>().goal = setGoal();
        yield return new WaitForSeconds(time);
        Instantiate(randomChild, gameObject.transform.position, gameObject.transform.rotation);
    }
    private string setGoal()
    {
        string goal = "";
        int.TryParse(string.Join("", gameObject.name.Where(c => char.IsDigit(c))), out int num);
        goal = "Goal" + num;
        Debug.Log(num);
        return goal;
    }
}