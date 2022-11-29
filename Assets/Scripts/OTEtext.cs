using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OTEtext : MonoBehaviour
{
    public TMPro.TMP_Text window;
    public string text;
    public Color color;
    public TMPro.TextAlignmentOptions alignment;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            string t = text.Replace("\\n", "\n");
            window.text = t;
            window.color = new Color(color.r, color.g, color.b);
            window.alignment = alignment;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            window.text = "";
        }
    }
}
