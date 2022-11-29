using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel3 : MonoBehaviour
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
        panels = new Panel[] { new Panel("<b>Занятие 3 –Перекрёстки\n</b>Место, где встречаются и пересекаются несколько дорог, называется <b>перекрёсток</b>.\nПерекрёстки бывают:\n* трёхсторонние (если посмотреть на них сверху, они похожи на буквы «У» или «Т»)\n* четырёхсторонние (если посмотреть на них сверху, они похожи на крест)."),
        new Panel("Если на перекрёстке движением управляет светофор или регулировщик, то такой перекресток называется регулируемым. \nЕсли же на перекрёстке нет ни светофора, ни регулировщика, ни дорожных знаков, то это перекрёсток нерегулируемый."),
        new Panel("Переходить нерегулируемый перекрёсток нужно очень осторожно.\nЕсли на перекрестке есть «зебра» - идите только по ней. И самое главное, не спешите идти, пока не проедут все машины; помните, проезжая часть – для машин. Никогда не переходите перекресток наискосок, как бы вы ни торопились. \nПрежде, чем сойти на проезжую часть, убедитесь, что слева нет приближающегося транспорта. Дойдя до середины, обязательно посмотрите направо и, если понадобится, пропустив транспорт, закончите переход.")};

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
