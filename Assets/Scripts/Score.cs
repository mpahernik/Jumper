using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private static int bluescore;
    private static int greenscore;
    public Text bluetext;
    public Text greentext;


    private void Start()
    {
        bluescore = 0;
        greenscore = 0;
    }
    // Update is called once per frame
    void Update()
    {
        bluetext.text = "Blue Score : " + bluescore;
        greentext.text = "Green Score : " + greenscore;
        bluescore = Target.pointsblue;
        greenscore = Target.pointsgreen;
    }
}
