using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    [SerializeField] private Button level1;
    [SerializeField] private Button level2;
    [SerializeField] private Button level3;
    [SerializeField] private Button level4;
    [SerializeField] private Button level5;
    [SerializeField] private Button level6;
    [SerializeField] private Button level7;
    [SerializeField] private Button level8;
    [SerializeField] private Button level9;


    private void Awake() {
        level1.onClick.AddListener(() => {
            SceneManager.LoadScene("Level1");
            
        });
        level2.onClick.AddListener(() => {
            SceneManager.LoadScene("Level2");
            
        });
        level3.onClick.AddListener(() => {
            SceneManager.LoadScene("Level3");
            
        });
        level3.onClick.AddListener(() => {
            SceneManager.LoadScene("Level4");
            
        });
        level3.onClick.AddListener(() => {
            SceneManager.LoadScene("Level5");
            
        });
        level3.onClick.AddListener(() => {
            SceneManager.LoadScene("Level6");
            
        });
        level3.onClick.AddListener(() => {
            SceneManager.LoadScene("Level7");
            
        });
        level3.onClick.AddListener(() => {
            SceneManager.LoadScene("Level8");
            
        });
        level3.onClick.AddListener(() => {
            SceneManager.LoadScene("Level9");
            
        });
        level3.onClick.AddListener(() => {
            SceneManager.LoadScene("Level10");
            
        });

        

        Time.timeScale = 1f;
    }
}
