﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour
{
    public Scene gamescene;
    public void PlayGame(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
