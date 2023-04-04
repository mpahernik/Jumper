using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public RectTransform panelGameOver;
    public Text bluewon;
    public Text greenwon;
    static private int bluepoints;
    static private int greenpoaints;
    public PlayerController movement;
    public PlayerController movement2;

    // Start is called before the first frame update
    void Start()
    {
        panelGameOver.gameObject.SetActive(false);
        bluewon.gameObject.SetActive(false);
        greenwon.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        bluepoints = Target.pointsblue;
        greenpoaints = Target.pointsgreen;

        if(bluepoints >= 100)
        {
            panelGameOver.gameObject.SetActive(true);
            bluewon.gameObject.SetActive(true);
            movement.enabled = false;
            movement2.enabled = false;

        }
        if (greenpoaints >= 100)
        {
            panelGameOver.gameObject.SetActive(true);
            greenwon.gameObject.SetActive(true);
            movement.enabled = false;
            movement2.enabled = false;

        }
    }
}
