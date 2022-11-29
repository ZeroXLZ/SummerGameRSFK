using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    void Start()
    {
        for(int i = 0; i < PlayerPrefs.GetInt("TestPr") +1; i++)
        {
            try
            {
                GameObject.Find("LessonB" + i).GetComponent<Button>().interactable = true;
            }
            catch (NullReferenceException ex) { }
        }
        for (int i = 0; i < PlayerPrefs.GetInt("LessonPr"); i++)
        {
            try
            {
                GameObject.Find("TestB" + i).GetComponent<Button>().interactable = true;
            }
            catch (NullReferenceException ex) { }
        }
        for (int i = 0; i < PlayerPrefs.GetInt("TestPr"); i++)
        {
            try
            {
                GameObject.Find("PracticeB" + i).GetComponent<Button>().interactable = true;
            }
            catch (NullReferenceException ex) { }
        }
        if(PlayerPrefs.GetInt("LessonPr") >= 11 && PlayerPrefs.GetInt("TestPr") >= 11 && PlayerPrefs.GetInt("PracticePr") >= 6)
        {
            GameObject.Find("ExamB").GetComponent<Button>().interactable = true;
        }
    }

    public void clearProgress()
    {
        PlayerPrefs.SetInt("LessonPr", 0);
        PlayerPrefs.SetInt("TestPr", 0);
        PlayerPrefs.SetInt("PracticePr", 0);
        PlayerPrefs.SetInt("NotFirstEnter", 0);
        new ChangeScene().changeScene("MainMenu");
    }
}
