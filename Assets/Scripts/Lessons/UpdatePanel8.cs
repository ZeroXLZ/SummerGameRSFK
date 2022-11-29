using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel8 : MonoBehaviour
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
        panels = new Panel[] { new Panel("<b>Занятие 8 – Где можно и где нельзя играть\n</b>Улица – не место для игр: по дороге едут машины, не заметишь автомобиль – попадёшь под колёса.\nНе играйте ни в какие игры и на тротуарах: вы мешаете другим пешеходам. Кроме того, мяч может выкатиться на дорогу, или вы, заигравшись, не заметите, как сами выскочите на мостовую. И тогда уже не миновать беды!"),
        new Panel("Нельзя играть рядом с проезжей частью, в местах дорожных работ, в общественном транспорте. Это опасно!\n\nИграть можно во дворе на детской площадке, в парке или в саду. Кататься на велосипедах, самокатах, роликах, на коньках, лыжах и санках в зимнее время года нужно в парках, скверах или на стадионах.")};

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
