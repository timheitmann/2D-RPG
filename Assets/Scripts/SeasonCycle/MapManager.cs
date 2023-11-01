using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    const int SPRING = 0;
    const int SUMMER = 1;
    const int AUTUMN_clean = 2;
    const int AUTUMN_LEAVES = 3;
    const int AUTUMN_BARE = 4;
    const int WINTER_CLEAN = 5;
    const int WINTER_LEAVES = 6;
    const int WINTER_SNOWY = 7;


    [SerializeField] private GameObject[] maps;
    void Start() {
        SetMap(SUMMER);
    }

    void SetMap(int mapIndex) {
        for (int i = 0; i < maps.Length; i++) {
            if (i == mapIndex) {
                maps[i].SetActive(true);
            } else {
                maps[i].SetActive(false);
            }
        }
    }
}
