﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame(int scene)
    {
        //Debug.Log("XD");
        SceneManager.LoadScene(scene);
    }
}
