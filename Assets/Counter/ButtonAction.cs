using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{   
    private Button button;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {   
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(UpdateBetAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateBetAmount()
    {   
        if (gameManager.betAmount >= 20)
        {
            gameManager.betAmount = 20;
            gameManager.betText.text = "Bet amount: " + gameManager.betAmount;
        } else
        {
            gameManager.betAmount += 1;
            gameManager.betText.text = "Bet amount: " + gameManager.betAmount;
        }
    }
}
