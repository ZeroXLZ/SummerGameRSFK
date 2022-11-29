using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel11 : MonoBehaviour
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
        panels = new Panel[] { new Panel("<b>Занятие 11 – Поездка за город\n</b>Загородная дорога имеет свои элементы: проезжая часть, обочина, кюветы.\n<b>Проезжая часть</b> – для движения транспорта.\n<b>Обочина</b> – часть дороги, расположенная по обе стороны проезжей части. \n<b>Kюветы</b> – канавы, прорытые вдоль по обе стороны дороги, необходимые для отвода воды."),
        new Panel("На загородной трассе правила для пешеходов звучат чуть иначе: дорога – для машин, обочина – для пешеходов. Идти надо по левой стороне обочины, чтобы автомобили  двигались тебе навстречу. Тогда водитель вовремя заметит тебя. И ты вовремя увидишь приближающийся автомобиль, отступая с проезжей части, позволишь автомашине беспрепятственно и, не снижая скорости, проехать мимо."),
        new Panel("Прежде чем переходить загородную дорогу, остановитесь и осмотритесь по сторонам: нет ли близко идущего транспорта. Сначала внимательно посмотрите налево, затем направо. Убедившись в том, что машин близко нет, переходите дорогу прямо, но ни в коем случае не наискосок.")};

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
