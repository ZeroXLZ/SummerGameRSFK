using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnNPC : MonoBehaviour
{
    public Transform spawn;
    public GameObject npc;
    void Start()
    {
        StartCoroutine(spawnPeople(3));
    }

    void Update()
    {
        
    }
    IEnumerator spawnPeople(float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(npc, spawn.position, spawn.rotation);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("NPC"))
            Destroy(other.gameObject);
    }
}
