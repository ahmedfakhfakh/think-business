using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MoneyStart4 : MonoBehaviour {
    public static Text dollars;
    public static Text bitcoins;
    public static Text liteCoins;
    public static Text mastercoin;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;


    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        dollars = Text1.GetComponent<Text>();
        bitcoins = Text2.GetComponent<Text>();
        liteCoins = Text3.GetComponent<Text>();
        mastercoin = Text4.GetComponent<Text>();

    }
}
