using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private GameObject main;
    private GameObject settings;
    private GameObject about;
    private GameObject types;
    private GameObject lessons;
    private GameObject tests;
    private GameObject exams;
    private GameObject practices;
    private GameObject current;
    private Vector3 pos;
    private Button yesB;
    private Button noB;
    private void Start()
    {
        main = GameObject.Find("CanvasMain");
        settings = GameObject.Find("CanvasSettings");
        about = GameObject.Find("CanvasAbout");
        types = GameObject.Find("CanvasTypes");
        lessons = GameObject.Find("CanvasLessons");
        tests = GameObject.Find("CanvasTests");
        practices = GameObject.Find("CanvasPractices");
        exams = GameObject.Find("CanvasExamTypes");
        yesB = GameObject.Find("YesB").GetComponent<Button>();
        noB = GameObject.Find("NoB").GetComponent<Button>();
    }
    private void setVisible(GameObject obj)
    {
        obj.GetComponent<Canvas>().enabled = true;
    }
    private void unsetVisible(GameObject obj)
    {
        obj.GetComponent<Canvas>().enabled = false;
    }

    public void openMain()
    {
        setVisible(main);
        unsetVisible(current);
        current = main;
    }
    public void openTypes()
    {
        setVisible(types);
        unsetVisible(main);
        if (current != null)
            if (current != types)
                unsetVisible(current);
        current = types;
    }
    public void openExams()
    {
        setVisible(exams);
        unsetVisible(types);
        if (current != null)
            if (current != types)
                unsetVisible(current);
        current = exams;
    }
    public void openLessons()
    {
        setVisible(lessons);
        unsetVisible(types);
        current = lessons;
    }
    public void openTests()
    {
        setVisible(tests);
        unsetVisible(types);
        current = tests;
    }
    public void openPractices()
    {
        setVisible(practices);
        unsetVisible(types);
        current = practices;
    }
    public void openSettings()
    {
        setVisible(settings);
        unsetVisible(main);
        current = settings;
    }
    public void openAbout()
    {
        setVisible(about);
        unsetVisible(main);
        current = about;
    }
    public void exit()
    {
        Application.Quit();
    }
    public void openProgressPanel()
    {
        GameObject panel = GameObject.Find("PanelProgress");
        yesB.interactable = true;
        noB.interactable = true;
        pos = panel.transform.position;
        panel.transform.position = main.transform.position;
    }
    public void closeProgressPanel()
    {
        GameObject panel = GameObject.Find("PanelProgress");
        yesB.interactable = false;
        noB.interactable = false;
        panel.transform.position = pos;
    }
}