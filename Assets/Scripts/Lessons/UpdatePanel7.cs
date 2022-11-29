using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel7 : MonoBehaviour
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
        panels = new Panel[] { new Panel("<b>Занятие 7 – Поездка на трамвае\n</b>Слово «трамвай» пришло к нам из Англии. Только там оно произносится «Трэм-вэй». «Трэм» - «вагон», «вэй» - «путь». «Трэм-вэй» - «вагон, ходящий по путям, по рельсам».\nЗнак «Место остановки трамвая» - информационно-указательный, он красноречиво говорит сам за себя: в белом квадрате нарисован трамвай. Здесь же можно увидеть расписание движения трамваев.") };

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
