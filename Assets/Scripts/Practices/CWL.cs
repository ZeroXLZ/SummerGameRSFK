using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CWL : MonoBehaviour
{
    public GameObject crosswalk;
    private float oldSpeed = 0f;
    private void OnTriggerEnter(Collider other)
    {
        oldSpeed = other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed;
        if (other.gameObject.tag.Equals("Car"))
        {
            if (crosswalk.GetComponent<IsOnCrossW2>().getIsOnCross())
            {
                other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 0f;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (!crosswalk.GetComponent<IsOnCrossW2>().getIsOnCross())
        {
            other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = oldSpeed;
        }
    }
}
