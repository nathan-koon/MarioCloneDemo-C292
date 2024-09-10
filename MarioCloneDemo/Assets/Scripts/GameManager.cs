using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    bool isGameOver = false;
    public static GameManager instance;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject gameOverText;
    // Start is called before the first frame update

    private void Awake(){
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int amount){
        score += amount;
        scoreText.text = "Coins: " + score;
    }

    public void InitiateGameOver(){
        isGameOver = true;
        gameOverText.SetActive(true);
    }
}
