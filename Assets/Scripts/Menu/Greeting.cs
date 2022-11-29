using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greeting : MonoBehaviour
{
    private GameObject panelGreeting;
    void Start()
    {
        panelGreeting = GameObject.Find("PanelGreeting");
        if (PlayerPrefs.GetInt("NotFirstEnter") == 1)
        {
            panelGreeting.SetActive(false);
        }
    }

    void Update()
    {
        if (panelGreeting.activeSelf)
        {
            if (Input.anyKeyDown)
            {
                panelGreeting.SetActive(false);
                PlayerPrefs.SetInt("NotFirstEnter", 1);
            }
        }
    }
}
