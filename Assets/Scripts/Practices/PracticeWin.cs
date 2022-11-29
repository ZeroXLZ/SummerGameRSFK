using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PracticeWin : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Time.timeScale = 0.0f;
            Cursor.visible = true;
            GameObject panel = GameObject.Find("Panel");
            panel.GetComponent<CanvasGroup>().interactable = true;
            panel.GetComponent<CanvasGroup>().alpha = 1;
            int.TryParse(string.Join("", SceneManager.GetActiveScene().name.Where(c => char.IsDigit(c))), out int sceneNum);
            if (sceneNum > PlayerPrefs.GetInt("PracticePr"))
                PlayerPrefs.SetInt("PracticePr", PlayerPrefs.GetInt("PracticePr") + 1);
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
