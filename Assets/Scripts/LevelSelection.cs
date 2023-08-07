using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/* SUBSCRIBING TO MY YOUTUBE CHANNEL: 'VIN CODES' WILL HELP WITH MORE VIDEOS AND CODE SHARING IN THE FUTURE :) THANK YOU */

public class LevelSelection : MonoBehaviour
{

    int levelsUnlocked;

    public Button[] lvlButtons;

    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2); 

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if(i + 2 > levelAt)
                lvlButtons[i].interactable = false;
            // buttons[i].interactable = false;
        }

        // for (int i = 0; i < buttons.Length; i++)
        // {
        //     buttons[i].interactable = true;
        // }
        
    }

    // public void LoadLevel(int levelIndex) {
    //     SceneManager.LoadScene(levelIndex);
    // }

}
