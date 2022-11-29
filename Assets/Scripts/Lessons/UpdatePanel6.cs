using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel6 : MonoBehaviour
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
        panels = new Panel[] { new Panel("<b>Занятие 6 – Поездка на автобусе\n</b>К городскому маршрутному транспорту общественного пользования относятся трамвай, автобус, микроавтобус, такси, троллейбус, метро."),
        new Panel("Общественный транспорт движется по определённым маршрутам. \nОжидать транспорт нужно на посадочных площадках, которые называются остановками.\nЗнак «Место остановки автобуса» - информационно - указательный, его легко узнать: в белом квадрате нарисован автобус."),
        new Panel("Обязанности пассажиров:\n1. Ожидай общественный транспорт только на остановках. \n2. Входи в задние двери, а выходи из передних дверей транспорта. \n3. После выхода из автобуса переходи дорогу только по пешеходному переходу.\n4. В транспорте нужно вести себя достойно: \n- не шуми и не толкайся; \n- не высовывайся в окно; \n- не стой на ступеньках, не прислоняйся к двери во время движения транспорта; \n- не отвлекай водителя разговорами; \n- уступи место пожилым людям, будь вежлив!")};

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
