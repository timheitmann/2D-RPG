using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData {

    private Vector3 initialPlayerPosition = new Vector3(0, 0, 0);

    public Vector3 playerPosition;
    public int timeOfDay;
    public int day;
    public int season;
    public int year;

    public GameData () {
        playerPosition = initialPlayerPosition;
        timeOfDay = 360;
        day = 0;
        season = 0;
    }
}
