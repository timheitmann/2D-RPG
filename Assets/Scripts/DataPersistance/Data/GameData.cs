using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData {

    private Vector3 initialPlayerPosition = new Vector3(0, 0, 0);

    public Vector3 playerPosition;
    

    public GameData () {
        playerPosition = initialPlayerPosition;
    }
}
