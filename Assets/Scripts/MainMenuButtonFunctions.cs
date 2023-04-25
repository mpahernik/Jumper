using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonFunctions : MonoBehaviour
{
    public int duel;
    public int CoOp;
    public int Controlls;

    public void PlayDuel()
    {
        SceneManager.LoadScene(duel);
    }

    public void PlayCoOp()
    {
        SceneManager.LoadScene(CoOp);
    }

    public void Controllsscene()
    {
        SceneManager.LoadScene(Controlls);
    }

    public void Quitgame()
    {

    }
}
