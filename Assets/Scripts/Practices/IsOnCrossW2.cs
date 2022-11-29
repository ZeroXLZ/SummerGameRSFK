using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOnCrossW2 : MonoBehaviour
{
    private bool isOnCross = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            isOnCross = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            isOnCross = false;
        }
    }
    public bool getIsOnCross()
    {
        return isOnCross;
    }
}
