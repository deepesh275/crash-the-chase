using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public Text levelText;
    void Start()
    {
        levelText.text = level.ToString();
    }

    public void OpenScene() {
        SceneManager.LoadScene("Level" + level.ToString());
    }

    
}
