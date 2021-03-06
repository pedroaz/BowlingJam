﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level")]
public class Level : ScriptableObject {

    // Needs to be public
    public GameObject levelPrefab;
    public int amountOfPinsInLevel;
    public int levelIndex;
}
