using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class UpdatePanel : MonoBehaviour
{
    private Image image;
    private TMPro.TMP_Text text;
    private int num;
    private Panel[] panels;
    private Sprite[] images;
    private Button toTestB;

    public UpdatePanel(Panel[] panels, Image image, TMPro.TMP_Text text, Sprite[] images, Button toTestB)
    {
        this.panels = panels;
        this.image = image;
        this.text = text;
        this.images = images;
        this.toTestB = toTestB;
    }
    public UpdatePanel()
    {

    }

    public int updatePanelUp()
    {
        if (num + 1 < panels.Length)
        {
            text.text = panels[num + 1].text;
            if (images[num + 1])
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
            }
            else
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
            }
            image.sprite = images[num + 1];
            num++;
        }
        if (num == panels.Length - 1)
        {
            toTestB.interactable = true;
            int.TryParse(string.Join("", SceneManager.GetActiveScene().name.Where(c => char.IsDigit(c))), out int sceneNum);
            if (sceneNum > PlayerPrefs.GetInt("LessonPr"))
                PlayerPrefs.SetInt("LessonPr", PlayerPrefs.GetInt("LessonPr") + 1);
        }
        return num;
    }
    public int updatePanelDown()
    {
        if (num - 1 >= 0)
        {
            text.text = panels[num - 1].text;
            if (images[num - 1])
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
            }
            else
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
            }
            image.sprite = images[num - 1];
            num--;
        }
        return num;
    }
}
