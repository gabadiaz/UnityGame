﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    private PlayerController playerController;
    private List<BaseUnit> units { get; }
    
    void Awake() {
        GameObject go = new GameObject();
        playerController = go.AddComponent<PlayerController>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void takeTurn(Turn turn) {
        //BaseUnit baseUnit = Instantiate<BaseUnit>();
        //playerController.activeUnit = turn.units[0];
        //turn.units[0] = null
    }
}