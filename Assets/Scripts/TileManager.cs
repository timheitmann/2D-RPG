using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileManager : MonoBehaviour {
    [SerializeField] private Tilemap interactableTilemap;
    [SerializeField] private Tile hiddenInteractableTile;
    void Start() {
        foreach(var position in interactableTilemap.cellBounds.allPositionsWithin) {
            TileBase tile = interactableTilemap.GetTile(position);

            if(tile != null && tile.name == "Interactable") {
                interactableTilemap.SetTile(position, hiddenInteractableTile);
            }
        }
    }

    public bool isInteractable(Vector3Int possition) {
        TileBase tile = interactableTilemap.GetTile(possition);

        return tile != null && tile.name == "Interactable";
    }
}
