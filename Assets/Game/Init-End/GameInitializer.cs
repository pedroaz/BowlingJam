﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour {

    [Tooltip("From 0 to 1")]
    [SerializeField] private float startingPurplePower;

    [Tooltip("From 0 to 10")]
    [SerializeField] private int startingRedPower;

    [SerializeField] private LevelManager levelManager;

    [SerializeField] private PowersStats powersStats;

    [SerializeField] private BallStats ballStats;

	// Use this for initialization
	void Start () {

        powersStats.CurrentPurplePower = startingPurplePower;
        powersStats.CurrentRedPower = startingRedPower;
        powersStats.RedDuration = 0;
        levelManager.RevivePlayer();
        ballStats.grounded = false;

        //levelManager.InitLevel();
    }

    [ExecuteInEditMode]
    void OnValidate() {
        startingPurplePower = Mathf.Clamp01(startingPurplePower);
        startingRedPower = Mathf.Clamp(startingRedPower, 0, 10);
    }

    // Update is called once per frame
    void Update () {
		
	}
}