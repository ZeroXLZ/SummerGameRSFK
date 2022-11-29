using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TLtriggers : MonoBehaviour
{
    public GameObject tl;
    public GameObject crosswalk;
    private float oldSpeed = 0f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Car"))
        {
            if((tl.GetComponent<TL>().priorityF == 0 && gameObject.tag.Equals("TriggerF")) || (tl.GetComponent<TL>().priorityS == 0 && gameObject.tag.Equals("TriggerS")))
            {
                oldSpeed = other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed;
                other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 0f;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (((tl.GetComponent<TL>().priorityF == 1 && gameObject.tag.Equals("TriggerF")) || (tl.GetComponent<TL>().priorityS == 1 && gameObject.tag.Equals("TriggerS")))
            && !crosswalk.GetComponent<IsOnCrossW>().getIsOnCross())
        {
            other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = oldSpeed;
        }
    }
}
