﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {

    public float maxDuration;
    public float currentDuration;

    public GameObject ball;

    public delegate void GhostDelegate();
    static public event GhostDelegate GhostEvent;

    static public bool isGhost;


    // Use this for initialization
    void Start () {

        isGhost = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ActivateGhost() {

        if (PowersManager.redPower >= 1) {

            if (!isGhost && !SlowTime.isSlow) {

                isGhost = true;

                PowersManager.RemoveRed();

                currentDuration = maxDuration;

                // Ghost
                ball.layer = 11;


                StartCoroutine(Duration());
            }
        }

    }

    IEnumerator Duration() {

        while (currentDuration > 0) {

            currentDuration -= 0.01f;
            if (currentDuration < 0.01f) {
                currentDuration = 0;
            }

            PowersManager.redDuration = currentDuration / maxDuration;
            GhostEvent();


            yield return null;
        }


        isGhost = false;

        // Wall
        ball.layer = 9;
    }
}