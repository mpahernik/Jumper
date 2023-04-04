using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowballpile : MonoBehaviour
{
    private static int pileblue;
    private static int pilegreen;
    public float timer = 0.3f;

    // Update is called once per frame
    void Update()
    {
        pileblue = PlayerController.blueammo;
        pilegreen = PlayerController.greenammo;
        timer -= Time.deltaTime;
    }


    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.tag == "BluePlayer" && timer <= 0 && pileblue < 10)
        {
            PlayerController.blueammo += 1;
            timer = 0.3f;
        }
        if(other.gameObject.tag == "GreenPlayer" && timer <= 0 && pilegreen < 10)
        {
            PlayerController.greenammo += 1;
            timer = 0.3f;
        }
    }


}
