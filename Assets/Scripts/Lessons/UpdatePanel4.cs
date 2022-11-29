using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel4 : MonoBehaviour
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
        panels = new Panel[] { new Panel("<b>Занятие 4 – Регулируемые перекрёстки. Светофор\n</b>Светофор – это устройство, управляющее движением на дороге. Именно светофор распоряжается, когда идти, а когда стоять. Если на перекрёстке установлен светофор, то такой перекрёсток называется регулируемым.\nKаждый сигнал светофора означает свою команду:"),
        new Panel("Движение через дорогу можно начинать только на зелёный свет. \nНи в коем случае не переходите дорогу на красный или жёлтый сигнал светофора, даже если на дороге совсем не видно машин. Это опасно!")};

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
