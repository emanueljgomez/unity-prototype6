using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActionMinus : MonoBehaviour
{   
    private Button button;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(UpdateBetAmountMinus);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateBetAmountMinus()
    {
        if (gameManager.betAmount <= 1)
        {
            gameManager.betAmount = 1;
            gameManager.betText.text = "Bet amount: " + gameManager.betAmount;
        } else
        {
            gameManager.betAmount -= 1;
            gameManager.betText.text = "Bet amount: " + gameManager.betAmount;
        }
    }
}
