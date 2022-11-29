using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTask : MonoBehaviour
{
    public TMPro.TMP_Text window;
    public string text;
    public bool check;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if (check)
            {
                string t = text.Replace("\\n", "\n");
                window.text = t;
            }
        }
    }
}
