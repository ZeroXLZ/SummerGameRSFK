using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congratulation : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
        {
            new ChangeScene().changeScene("MainMenu");
        }
    }
}