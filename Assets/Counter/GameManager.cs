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
    public GameObject gameOver;
    public GameObject youWin;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        plusButton = GameObject.Find("PlusButton").GetComponent<Button>();
        minusButton = GameObject.Find("MinusButton").GetComponent<Button>();
        okButton = GameObject.Find("StartButton").GetComponent<Button>();
        box = GameObject.FindGameObjectWithTag("Box");
        StartCoroutine(WinCondition());
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

    IEnumerator WinCondition()
    {
        yield return new WaitForSeconds(4);
        if (box.GetComponent<Counter>().Count == betAmount)
        {
            Debug.Log("YOU WIN!");
            youWin.gameObject.SetActive(true);
        } else {
            Debug.Log("GAME OVER");
            gameOver.gameObject.SetActive(true);
        }
    }
}
