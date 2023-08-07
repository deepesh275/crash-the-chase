using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private Button nextLevelButton;
    public GameObject completeLevelUI;

    private void Awake() {
        nextLevelButton.onClick.AddListener(() => {

            completeLevelUI.SetActive(false);

        });

        // Time.timeScale = 1f;
    }

    
   
   

    // Start is called before the first frame update
//     void Start()
//     {
//         // SceneManager.LoadScene("NextLevel");
//         nextScene = SceneManager.GetActiveScene().buildIndex + 1;
//     }
}
