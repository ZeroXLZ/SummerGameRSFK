using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel2 : MonoBehaviour
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
        panels = new Panel[] { new Panel("<b>Занятие 2 – Пешеходные переходы\n</b>Для перехода дороги есть специальное место, оно так и называется – \n«<b>Пешеходный переход</b>»."),
        new Panel("На этом участке дороги установлен знак - квадрат синего цвета. \nВнутри него, в белом треугольнике, изображён пешеход.\nПерейти дорогу помогут и широкие белые полоски, нарисованные на асфальте. Полосы получили название «зебра», так как похожи на расцветку этого животного."),
        new Panel("А вот там, где установлен такой знак, <b>движение</b> <b>пешеходов</b> <b>запрещено</b>. Не зря этот знак красного цвета, а идущий человечек перечёркнут."),
        new Panel("Если по дороге транспорт движется только в одну сторону, то это дорога с <b>односторонним</b> <b>движением</b>. Переходя её, всё равно посмотри в обе стороны, так как навстречу транспортному потоку могут двигаться специальные машины – полицейская, пожарная, «Скорая помощь»."),
        new Panel("Если транспорт по дороге движется в обе стороны, то это дорога с двусторонним движением. Подойдя к проезжей части, остановись и посмотри налево, а дойдя до середины дороги — направо. Убедившись, что машин нет, спокойно, но быстро переходи."),
        new Panel("Если дорога широкая, на проезжей части можно переждать поток машин в безопасном месте, где пешехода никогда не собьют авто.\nЭто место называется «Островок безопасности».")};

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
