using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Timer : MonoBehaviour
{
    public static int timeLeft = 0;
    public Text countdownText;
    public int GameoverIndex;
    public Text Dollars;
    public Text Bitcoins;
    public Text Mastercoins;
    public Text Litecoins;
    public int score =0;
    private float timer;
    public static IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft++;
        }
    }
    void Start()
    {


    }
    void Update()
    {
        StartCoroutine("LoseTime");
        timer += Time.deltaTime;
        if (timer > 1)
        {
            score = Int32.Parse(MoneyStart4.dollars.text);
            score++;
            MoneyStart4.dollars.text = score.ToString();
            timer = 0;
        }
    }



}