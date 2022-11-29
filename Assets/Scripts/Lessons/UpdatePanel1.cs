using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel1 : MonoBehaviour
{
    public Image image;
    public TMPro.TMP_Text text;
    public int num;
    private Panel[] panels;
    public Sprite[] images;
    public Button toTestB;
    private UpdatePanel upd = new UpdatePanel();

    public void Start()
    {
        panels = new Panel[] { new Panel("<b>Занятие 1 – Улица полна неожиданностей\n" +
            "</b>Участниками дорожного движения являются:\n" +
            "* <b>водитель</b> – человек, управляющий транспортным средством;\n" +
            "* <b> пассажир </b> – человек, который находится в транспортном средстве, но не является его водителем;\n" +
            "* <b> пешеход </b> – человек, который ходит по улице пешком."),
        new Panel("Элементы улицы:\n" +
        "*тротуар – часть улицы, предназначенная для движения пешеходов;\n" +
        "*мостовая(проезжая часть) – часть улицы, предназначенная для движения автомобилей."),
        new Panel("Правила поведения на тротуаре:\n" +
        "*иди спокойно, не задевая других пешеходов;\n" +
        "*двигайся по правой стороне, чтобы не мешать идущим навстречу;\n" +
        "*не играй на тротуаре в подвижные игры, не толкайся и не балуйся."),
        new Panel("Правила дорожного движения должны соблюдать все, кто находится на улице или дороге!")};

        text.text = panels[0].text;
        image.sprite = images[0];
        num = 0;

        upd = new UpdatePanel(panels, image, text, images, toTestB);
    }

    public void updatePanelUp()
    {
        upd.updatePanelUp();
    }
    public void updatePanelDown()
    {
        upd.updatePanelDown();
    }
}
