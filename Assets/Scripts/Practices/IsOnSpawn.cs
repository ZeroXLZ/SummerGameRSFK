using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOnSpawn : MonoBehaviour
{
    public bool isFree = true;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Car"))
        {
            isFree = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Car"))
        {
            isFree = true;
        }
    }
    public bool getIsFree()
    {
        return isFree;
    }
    public void setIsFree(bool b)
    {
        isFree = b;
    }
}
