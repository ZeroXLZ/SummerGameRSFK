using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOnCrossW : MonoBehaviour
{
    private bool isOnCross = false;
    public GameObject tl;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            isOnCross = true;
        }
        if(tl.GetComponent<TL>().priorityF == 0 && tl.GetComponent<TL>().priorityS == 0)
        {
            gameObject.GetComponent<PracticeFail>().timer = 20;
            gameObject.GetComponent<OTEtext>().text = "";
        }
        else
        {
            gameObject.GetComponent<PracticeFail>().timer = 3;
            gameObject.GetComponent<OTEtext>().text = "Переходить дорогу можно только на зелёный сигнал светофора для пешеходов!";
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
