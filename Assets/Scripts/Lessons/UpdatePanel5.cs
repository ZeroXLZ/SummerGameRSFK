using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel5 : MonoBehaviour
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
        panels = new Panel[] { new Panel("<b>Занятие 5 – Где ещё можно переходить дорогу\n</b>Перейти дорогу можно не только по проезжей части по пешеходному переходу, но и пользуясь подземным или наземным переходом. Эти способы перехода дороги более безопасные, так как исключают встречу пешехода с транспортом.\n\n<b>Подземный пешеходный переход</b> обычно состоит из тоннеля под проезжей частью и ведущих к нему ступеней, расположенных на пешеходных дорожках. часто ступеньки оборудованы наклонными дорожками для спуска велосипедов и детских колясок."),
        new Panel("Надземный пешеходный переход</b> – это мостик, расположенный над дорогой. По обе стороны мостика установлены прочные перила для безопасности пешеходов.")};

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
