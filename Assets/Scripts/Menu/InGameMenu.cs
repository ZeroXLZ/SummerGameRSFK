using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    private GameObject menu;
    private GameObject settings;

    private void Start()
    {
        menu = GameObject.Find("CanvasMain");
        settings = GameObject.Find("CanvasSettings");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && menu.GetComponent<Canvas>().enabled == false
            && settings.GetComponent<Canvas>().enabled == false)
        {
            Cursor.visible = true;
            GameObject.Find("CanvasMain").GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0f;
        }
    }

    private void setVisible(GameObject obj)
    {
        obj.GetComponent<Canvas>().enabled = true;
    }
    private void unsetVisible(GameObject obj)
    {
        obj.GetComponent<Canvas>().enabled = false;
    }

    public void openMenu()
    {
        setVisible(menu);
    }
    public void openSettings()
    {
        setVisible(settings);
        unsetVisible(menu);
    }
    public void closeMenu()
    {
        unsetVisible(menu);
        Time.timeScale = 1f;
        if(SceneManager.GetActiveScene().name.Contains("Practice"))
            Cursor.visible = false;
    }
    public void closeSettings()
    {
        unsetVisible(settings);
        setVisible(menu);
    }
}
