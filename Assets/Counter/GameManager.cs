using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    public int betAmount;
    public GameObject box;
    public TextMeshProUGUI betText;
    public Button plusButton;
    public Button minusButton;
    public Button okButton;
    public Button restartButton;
    public GameObject gameOver;
    public GameObject youWin;
    public Vector3[] spherePos;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        plusButton = GameObject.Find("PlusButton").GetComponent<Button>();
        minusButton = GameObject.Find("MinusButton").GetComponent<Button>();
        okButton = GameObject.Find("StartButton").GetComponent<Button>();
        restartButton = GameObject.Find("RestartButton").GetComponent<Button>();
        restartButton.gameObject.SetActive(false);
        box = GameObject.FindGameObjectWithTag("Box");
        StartCoroutine(WinCondition());
        spherePos = new Vector3[31];

        for (int i = 0; i <= 30; i++)
        {   
            spherePos[i] = GameObject.Find("Sphere" + i).transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        plusButton.gameObject.SetActive(false);
        minusButton.gameObject.SetActive(false);
        okButton.gameObject.SetActive(false);
    }

    public void RestartGame()
    {   
        betAmount = 1;
        betText.text = "Bet amount: " + betAmount;
        plusButton.gameObject.SetActive(true);
        minusButton.gameObject.SetActive(true);
        okButton.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(false);
        youWin.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);

        StartCoroutine(WinCondition());
        box.GetComponent<Counter>().Count = 0;
        box.GetComponent<Counter>().CounterText.text = "Count : " + 0;
        box.GetComponent<RandomPosition>().RandomPos();

        for (int i = 0; i <= 30; i++)
        {   
            GameObject.Find("Sphere" + i).transform.position = spherePos[i];
            Time.timeScale = 0;
        }        
    }

    IEnumerator WinCondition()
    {
        yield return new WaitForSeconds(4);
        if (box.GetComponent<Counter>().Count == betAmount)
        {
            Debug.Log("YOU WIN!");
            youWin.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        } else {
            Debug.Log("GAME OVER");
            gameOver.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
    }
}
