﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]

public class UI{

    [Serializable]

    public class HUD {

        [Header("Text")]

        public Text txtcoinCount;
        public Text txtLifeCount;
        public Text txtTimer;

        [Header("Other")]

        public GameObject hudPanel;

    }

    [Serializable]

    public class GameOver{

        [Header("Text")]

        public Text txtcoinCount;
        public Text txtTimer;

        [Header("Other")]

        public GameObject gameOverPanel;

    }

    public HUD hud;
    public GameOver gameOver;

}
