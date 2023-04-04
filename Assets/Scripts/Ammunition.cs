using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammunition : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public GameObject ball6;
    public GameObject ball7;
    public GameObject ball8;
    public GameObject ball9;
    public GameObject ball10;
    public GameObject ball1g;
    public GameObject ball2g;
    public GameObject ball3g;
    public GameObject ball4g;
    public GameObject ball5g;
    public GameObject ball6g;
    public GameObject ball7g;
    public GameObject ball8g;
    public GameObject ball9g;
    public GameObject ball10g;

    public Sprite spritefull;
    public Sprite spriteempty;
    public Sprite spritefullright;
    public Sprite spriteemptyright;

    private static int blueballs;
    private static int greenballs;




    void Update()
    {
        blueballs = PlayerController.blueammo;
        greenballs = PlayerController.greenammo;

        if (blueballs > 0)
        {
            ball1.GetComponent<Image>().sprite = spritefull;
        }
        else
        {
            ball1.GetComponent<Image>().sprite = spriteempty;
        }
        if (blueballs > 1)
        {
            ball2.GetComponent<Image>().sprite = spritefull;
        }
        else
        {
            ball2.GetComponent<Image>().sprite = spriteempty;
        }
        if (blueballs > 2)
        {
            ball3.GetComponent<Image>().sprite = spritefull;
        }
        else
        {
            ball3.GetComponent<Image>().sprite = spriteempty;
        }
        if (blueballs > 3)
        {
            ball4.GetComponent<Image>().sprite = spritefull;
        }
        else
        {
            ball4.GetComponent<Image>().sprite = spriteempty;
        }
        if (blueballs > 4)
        {
            ball5.GetComponent<Image>().sprite = spritefull;
        }
        else
        {
            ball5.GetComponent<Image>().sprite = spriteempty;
        }
        if (blueballs > 5)
        {
            ball6.GetComponent<Image>().sprite = spritefull;
        }
        else
        {
            ball6.GetComponent<Image>().sprite = spriteempty;
        }
        if (blueballs > 6)
        {
            ball7.GetComponent<Image>().sprite = spritefull;
        }
        else
        {
            ball7.GetComponent<Image>().sprite = spriteempty;
        }
        if (blueballs > 7)
        {
            ball8.GetComponent<Image>().sprite = spritefull;
        }
        else
        {
            ball8.GetComponent<Image>().sprite = spriteempty;
        }
        if (blueballs > 8)
        {
            ball9.GetComponent<Image>().sprite = spritefull;
        }
        else
        {
            ball9.GetComponent<Image>().sprite = spriteempty;
        }
        if (blueballs > 9)
        {
            ball10.GetComponent<Image>().sprite = spritefull;
        }
        else
        {
            ball10.GetComponent<Image>().sprite = spriteempty;
        }

        if (greenballs > 0)
        {
            ball1g.GetComponent<Image>().sprite = spritefullright;
        }
        else
        {
            ball1g.GetComponent<Image>().sprite = spriteemptyright;
        }
        if (greenballs > 1)
        {
            ball2g.GetComponent<Image>().sprite = spritefullright;
        }
        else
        {
            ball2g.GetComponent<Image>().sprite = spriteemptyright;
        }
        if (greenballs > 2)
        {
            ball3g.GetComponent<Image>().sprite = spritefullright;
        }
        else
        {
            ball3g.GetComponent<Image>().sprite = spriteemptyright;
        }
        if (greenballs > 3)
        {
            ball4g.GetComponent<Image>().sprite = spritefullright;
        }
        else
        {
            ball4g.GetComponent<Image>().sprite = spriteemptyright;
        }
        if (greenballs > 4)
        {
            ball5g.GetComponent<Image>().sprite = spritefullright;
        }
        else
        {
            ball5g.GetComponent<Image>().sprite = spriteemptyright;
        }
        if (greenballs > 5)
        {
            ball6g.GetComponent<Image>().sprite = spritefullright;
        }
        else
        {
            ball6g.GetComponent<Image>().sprite = spriteemptyright;
        }
        if (greenballs > 6)
        {
            ball7g.GetComponent<Image>().sprite = spritefullright;
        }
        else
        {
            ball7g.GetComponent<Image>().sprite = spriteemptyright;
        }
        if (greenballs > 7)
        {
            ball8g.GetComponent<Image>().sprite = spritefullright;
        }
        else
        {
            ball8g.GetComponent<Image>().sprite = spriteemptyright;
        }
        if (greenballs > 8)
        {
            ball9g.GetComponent<Image>().sprite = spritefullright;
        }
        else
        {
            ball9g.GetComponent<Image>().sprite = spriteemptyright;
        }
        if (greenballs > 9)
        {
            ball10g.GetComponent<Image>().sprite = spritefullright;
        }
        else
        {
            ball10g.GetComponent<Image>().sprite = spriteemptyright;
        }
    }
}
