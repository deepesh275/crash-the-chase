using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private GoogleAdMobController gameAds;

    //counting and printing score
    public int Respawn;
    public Text coinsText;
    public Text coinsTexts;

    public static int minCoinforNextScene;
    public GameObject completeLevelUI;
    // [SerializeField] private Button nextLevelButton;
    void Start()
    {
        
        minCoinforNextScene = 0;

        gameAds.RequestBannerAd();
        gameAds.ShowAppOpenAd();
        gameAds.RequestAndLoadInterstitialAd();


    }

    void Update()
    {
        coinsText.text = PlayerController.numberOfCoins.ToString();
        coinsTexts.text = PlayerController.numberOfCoins.ToString();

        //check game is over or not
        if(PlayerController.isGameOver)
        {
            // gameAds.ShowInterstitialAd();

            GameOver();

            
        }
        //open another level for pro gamer
        else if(PlayerController.isGoNext)
        {

            completeLevelUI.SetActive(true);
            NextLevel();
        }
    }

    // private void LoadingScene() {

    //     SceneManager.LoadScene("LoadingScene");
    //     PlayerController.isGameOver = false;

    // }

    private void GameOver()
    {


        // SceneManager.LoadScene("EndGame");

        // PlayerController.isGameOver = false;
        gameAds.ShowInterstitialAd();


    }


    private void NextLevel()
    {
        
        Invoke("MyFunction", 3);


   
    }

    // private void Awake() {
    //     nextLevelButton.onClick.AddListener(() => {

    //         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //         completeLevelUI.SetActive(false);

    //     });

    //     // Time.timeScale = 1f;
    // }

    public void StartGame()
    {

        SceneManager.LoadScene("LevelSelection");
        PlayerController.isGameOver = false;

    }

     void MyFunction()
    {
            completeLevelUI.SetActive(false);

        PlayerController.numberOfCoins = 0;

        // SceneManager.LoadScene("NextLevel");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerController.isGoNext = false;

    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(Respawn);
        PlayerController.isGameOver = false;
    }


    

}
