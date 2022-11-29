using UnityEngine;
using System.Collections;
public class MoveTo : MonoBehaviour
{
    // Положение точки назначения
    public string goal = "Goal0";
    void Start()
    {
        // Получение компонента агента
        UnityEngine.AI.NavMeshAgent agent
            = GetComponent<UnityEngine.AI.NavMeshAgent>();
        // Указаие точки назначения
        Transform goalT = GameObject.Find(goal).transform;
        agent.destination = goalT.position;
    }
}