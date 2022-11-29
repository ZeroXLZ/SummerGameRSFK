using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Test : MonoBehaviour
{
    public Text result;
    public int questions;
    private int mistakes;
    private int rights;
    private int panelNum = 1;

    private void Start()
    {
        try
        {
            GameObject.Find("Panel" + panelNum).transform.position = GetComponentInParent<Transform>().position;
        }
        catch (NullReferenceException ex)
        {

        }
    }
    void Update()
    {
        if (mistakes == (questions / 2))
        {
            result.text = $"Вы совершили слишком много ошибок. Повторите материал и пройдите тест снова.";
            result.color = Color.red;
            blockB();
        }
        if (rights == questions - mistakes)
        {
            result.text = "Вы прошли тест! Поздравляю!";
            result.color = Color.green;
            blockB();
            int.TryParse(string.Join("", SceneManager.GetActiveScene().name.Where(c => char.IsDigit(c))), out int sceneNum);
            if (sceneNum > PlayerPrefs.GetInt("TestPr"))
                PlayerPrefs.SetInt("TestPr", PlayerPrefs.GetInt("TestPr") + 1);
            if (SceneManager.GetActiveScene().name.Equals("ExamTest"))
            {
                PlayerPrefs.SetInt("ExamTestPr", 1);
                SceneManager.LoadScene("Congratulation");
            }
        }
    }

    private void blockB()
    {
        List<GameObject> buttons = new List<GameObject>();
        buttons.AddRange(GameObject.FindGameObjectsWithTag("Right"));
        buttons.AddRange(GameObject.FindGameObjectsWithTag("Wrong"));
        foreach (GameObject btn in buttons)
        {
            btn.GetComponent<Button>().interactable = false;
        }
        if (rights == questions - mistakes)
        {
            try
            {
                GameObject.Find("PracticeB").GetComponent<Button>().interactable = true;
            }
            catch (NullReferenceException ex)
            {
                GameObject.Find("MenuB1").GetComponent<Button>().interactable = true;
            }
        }
    }
    public void blockQ()
    {
        List<Image> images = new List<Image>();
        List<Button> buttons = new List<Button>();
        GameObject g = EventSystem.current.currentSelectedGameObject;
        g.AddComponent<Outline>();

        GameObject gp = g.transform.parent.gameObject;
        buttons.AddRange(gp.GetComponentsInChildren<Button>());

        foreach (Button button in buttons)
        {
            button.interactable = false;
            if (button.gameObject.tag.Equals("Right"))
            {
                button.targetGraphic.color = Color.green;
            }
            else
            {
                button.targetGraphic.color = Color.red;
            }
        }
    }
    public void makeMistake()
    {
        mistakes++;
    }
    public void makeRight()
    {
        rights++;
    }
    public void nextPanel()
    {
        changePanel(1);
    }
    public void previousPanel()
    {
        changePanel(-1);
    }
    private void changePanel(int num)
    {
        GameObject oldP = GameObject.Find("Panel" + panelNum);
        oldP.transform.position = new Vector3(oldP.transform.position.x, 1000f, oldP.transform.position.z);
        panelNum += num;
        GameObject newP = GameObject.Find("Panel" + panelNum);
        newP.transform.position = GetComponentInParent<Transform>().position;
    }
}