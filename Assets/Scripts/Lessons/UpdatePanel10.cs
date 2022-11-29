using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel10 : MonoBehaviour
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
        panels = new Panel[] { new Panel("<b>Занятие 10 – Ты - велосипедист\n</b>Велосипед занимает на дорогах планеты первое место среди других транспортных средств. Это потому, что он прост в управлении, не требует топлива, занимает мало места.\nСлово «велосипед» пришло к нам из латинского языка. По латыни «великос» - «быстрый», а «педес» - «ноги». «Велосипед» - значит «быстроног»."),
        new Panel("Детям до 14 лет запрещено выезжать на велосипеде на проезжую часть дороги. Ездить по тротуару или пешеходной дорожке тоже запрещено - можно задеть прохожих или играющих детей. Поэтому кататься можно только во дворах домов, на стадионах, детских или спортивных площадках.  \nУчиться ездить на велосипеде надо там, где нет движения автомобилей и пешеходов."),
        new Panel("Ребенок на велосипеде тоже водитель. Поэтому водителям велосипеда необходимо хорошо знать Правила дорожного движения, знать устройство и постоянно поддерживать свой транспорт в исправном состоянии.")};

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
