using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour {
    public static bool isStartTile = false;
    public bool hasBuilding = false;
    public bool canPlaceBuilding = false;

    [SerializeField]
    private GameObject _highlight;
    [SerializeField]
    private SpriteRenderer _building;

    private void Awake() {
        _building = GetComponent<SpriteRenderer>();
    }

    public void ToggleHighlight(bool toggle) {
        _highlight.SetActive(toggle);
        canPlaceBuilding = toggle;
    }

    public void PlaceBuilding(Sprite buildingSprite) {
        hasBuilding = true;
        _building.sprite = buildingSprite;
    }
}
