using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuySomething : MonoBehaviour{
    public GameObject BuyingPanel;
    public GameObject Anotherone;
    public GameObject BuyingCompleted;
    public GameObject Hiring;
    public Animation designer;
    public GameObject Designer;
    public GameObject Hacker;
    public GameObject Developer;
    public GameObject Gamer;
    public GameObject Designer1;
    public GameObject Hacker1;
    public GameObject Developer1;
    public GameObject Gamer1;
    public GameObject Hirepaneltwo;
    public bool WorkedDesigner = false;
    public bool WorkedGamer = false;
    public bool WorkedDeveloper = false;
    public bool WorkedHacker = false;
    public bool WorkedDesigner1 = false;
    public bool WorkedGamer1 = false;
    public bool WorkedDeveloper1 = false;
    public bool WorkedHacker1 = false;

    public void BuyClick()
    {
        BuyingPanel.SetActive(true);
    }
    public void Anotther()
    {
        Hirepaneltwo.SetActive(true);
        Anotherone.SetActive(false);

    }
    public void Home()
    {
        BuyingPanel.SetActive(false);
    }
    public void Home2()
    {
        Hirepaneltwo.SetActive(false);

    }
    public void Cancancna()
    {
        Anotherone.SetActive(false);
        BuyingPanel.SetActive(true);
    }
    public void BuySuccess()
    {
        BuyingPanel.SetActive(false);
        BuyingCompleted.SetActive(true);
    }
    public void Hiiring()
    {
        Hiring.SetActive(true);
    }
    public void TransformScene()
    {
        SceneManager.LoadScene(2);
    }
    public void HireNotDone()
    {
        Hiring.SetActive(false);
    }
    public void HireDoneDesigner ()
    {
        if (WorkedHacker == false && WorkedDeveloper == false && WorkedGamer == false)
        {
            WorkedDesigner = true;
            Hiring.SetActive(false);
            Designer.SetActive(true);
        }
        else
        {
            Anotherone.SetActive(true);
            Hiring.SetActive(false);
        }
    }
    public void HireDoneHacker()
    {
        if (WorkedDesigner == false && WorkedDeveloper == false && WorkedGamer == false)
        {
            WorkedHacker = true;
            Hiring.SetActive(false);
            Hacker.SetActive(true);
        }
        else
        {
            Anotherone.SetActive(true);
            Hiring.SetActive(false);

        }

    }
    public void HireDoneGamer()
    {
        if (WorkedHacker == false && WorkedDeveloper == false && WorkedDesigner == false)
        {
            WorkedGamer = true;
            Hiring.SetActive(false);
            Gamer.SetActive(true);
        }
        else
        {
            Anotherone.SetActive(true);
            Hiring.SetActive(false);

        }

    }
    public void HireDoneDeveloper()
    {
        if (WorkedHacker == false && WorkedDesigner == false && WorkedGamer == false)
        {
            WorkedDeveloper = true;
            Hiring.SetActive(false);
            Developer.SetActive(true);
        }
        else
        {
            Anotherone.SetActive(true);
            Hiring.SetActive(false);

        }

    }
    public void HireDoneDesigner1()
    {
        if (WorkedHacker1 == false && WorkedDeveloper1 == false && WorkedGamer1 == false)
        {
            WorkedDesigner = true;
            Hirepaneltwo.SetActive(false);
            Designer1.SetActive(true);
        }
        else
        {
            Anotherone.SetActive(false);
            Hiring.SetActive(false);

        }

    }
    public void HireDoneHacker1()
    {
        if (WorkedDesigner1 == false && WorkedDeveloper1 == false && WorkedGamer1 == false)
        {
            WorkedHacker = true;
            Hirepaneltwo.SetActive(false);
            Hacker1.SetActive(true);
        }
        else
        {
            Anotherone.SetActive(false);
            Hiring.SetActive(false);

        }

    }
    public void HireDoneGamer1()
    {
        if (WorkedHacker1 == false && WorkedDeveloper1 == false && WorkedDesigner1 == false)
        {
            WorkedGamer = true;
            Hirepaneltwo.SetActive(false);
            Gamer1.SetActive(true);
        }
        else
        {
            Anotherone.SetActive(true);
            Hiring.SetActive(false);

        }

    }
    public void HireDoneDeveloper1()
    {
        if (WorkedHacker1 == false && WorkedDesigner1 == false && WorkedGamer1 == false)
        {
            WorkedDeveloper = true;
            Hirepaneltwo.SetActive(false);
            Developer1.SetActive(true);
        }
        else
        {
            Anotherone.SetActive(true);
            Hiring.SetActive(false);

        }

    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
