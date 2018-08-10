using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyOnRoom : MonoBehaviour {
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    MoneyStart4.dollars = Text1.GetComponent<Text>();
    MoneyStart4.bitcoins = Text2.GetComponent<Text>();
    MoneyStart4.liteCoins = Text3.GetComponent<Text>();
    MoneyStart4.mastercoin = Text4.GetComponent<Text>();

    }
}
