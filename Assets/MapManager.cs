using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {
    private GameObject[] _tiles;
    private GameObject[] _tilesWithBuilding;

    private void Awake() {
        _tiles = GetComponentsInChildren<GameObject>();
    }

    void GetTilesAtPosition(float position) {

    }

}
