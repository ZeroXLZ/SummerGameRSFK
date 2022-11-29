using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel9 : MonoBehaviour
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
        panels = new Panel[] { new Panel("<b>Занятие 9 – Виды травм при ДТП</b>\n<b>ДТП</b> – это <B>Д</B>орожно-<B>Т</B>ранспортное <B>П</B>роисшествие, т. е. происшествие на дороге, когда кто-то из участников дорожного движения (пешеход, водитель авто, велосипедист) нарушает правила.\nТравмы, полученные в ДТП, - сложнейшие и опаснейшие травмы. Как правило, это многочисленные ушибы, переломы, ожоги, порезы, раны."),
        new Panel("<b>Рана</b> – это повреждение, при котором нарушается целостность кожных покровов тела, слизистых оболочек. \n<b>Ушиб</b> – это повреждение тканей и органов, при котором не нарушена целостность кожи. Могут быть кровоподтеки (синяки), припухлости (отеки). \n<b>Перелом</b> – это нарушение целостности кости. \n<b>Ожог</b> – это повреждение тканей организма в результате действия высокой температуры (пламени, горячего пара, раскалённого металла).  \n \nРебята, будьте внимательны и дисциплинированны на дороге! Позаботьтесь сами о своей жизни и здоровье!")};

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
