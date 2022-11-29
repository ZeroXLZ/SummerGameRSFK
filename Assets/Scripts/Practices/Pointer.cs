using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public float degreesPerSecond = 20;
    public float smoothTime = 0.5f;
    public float speed = 10f;
    Vector3 velocity;
    private Transform target;
    private Vector3 targetPos;
    private Vector3 downPos;
    private Vector3 upPos;
    void Start()
    {
        target = transform.Find("Down");
        downPos = new Vector3(target.position.x, target.position.y, target.position.z);
        target = transform.Find("Up");
        upPos = new Vector3(target.position.x, target.position.y, target.position.z);

        targetPos = downPos;
    }
    void FixedUpdate()
    {
        transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0, Space.Self);

        var step = speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime, speed);

        if (Vector3.Distance(transform.position, targetPos) < 0.001f)
        {
            if (targetPos == downPos)
            {
                targetPos = upPos;
            }
            else
            {
                targetPos = downPos;
            }
        }
    }
}
