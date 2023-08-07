using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMainMenuSystem : MonoBehaviour
{
    // public Button level02Button, level03Button;
    public Button[] lvlButtons;
    // int levelPassed;
    int levelsUnlocked;

    // void Start() {
    //     levelPassed = PlayerPrefs.GetInt("LevelPassed");
    //     lvlButtons.interactable = false;
    //     lvlButtons.interactable = false;

    //     switch (levelPassed) {
    //     case 1:
    //         lvlButtons.interactable = true;
    //         break;
    //     case 2: 
    //         lvlButtons.interactable = true;
    //         lvlButtons.interactable = true;
    //         break;
    //     }
    // }

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2); 

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if(i + 2 > levelAt)
                // lvlButtons[i].interactable = false;
            lvlButtons[i].interactable = true;
        }

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            lvlButtons[i].interactable = false;
        }
        
    }

    public void levelToLoad (int level) {
        SceneManager.LoadScene(level);
    }

    // public void resetPlayerPrefs() {
    //     level02Button.interactable = false;
    //     level03Button.interactable = false;
    //     // PlayerPrefs.DeleteAll();
    // }
}
