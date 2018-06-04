using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour {
    public Text txtScore;

    public static int levelGame = 0;

    public static int maxChickenInScene = 1;
    public static int score;

    float timeGame = 0;

    // Use this for initialization
    void Start() {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update() {
        CalculateGameData();
        SetDataUI();

    }
    void CalculateGameData()
    {
        timeGame += Time.deltaTime;
        levelGame = (timeGame < 10) ? 0 : (timeGame < 20) ? 1 : (timeGame < 30) ? 2 : (timeGame < 40) ? 3 : 4;

        maxChickenInScene = levelGame + 1;
    }
    void SetDataUI()
    {
        txtScore.text = "Score: " + score;
    }
}
