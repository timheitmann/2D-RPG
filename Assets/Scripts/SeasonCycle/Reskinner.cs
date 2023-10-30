using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Reskinner : MonoBehaviour
{

    public string[] sheetNames;
    Sprite[][] subSprites;
    Tilemap[] tilemaps;

    void Start(){
        tilemaps = GetComponentsInChildren<Tilemap>();
        sheetNames = new string[] {"spring", "spring_wall", "spring_canopy", "spring_wang"};
        SetSkin();
    }

    public void SetSkin(){
        reloadSprites();
        foreach(Tilemap tilemap in tilemaps){
            for(int x = (int)tilemap.localBounds.min.x; x < tilemap.localBounds.max.x; x++){
                for(int y = (int)tilemap.localBounds.min.y; y < tilemap.localBounds.max.y; y++){
                    TileBase tb = tilemap.GetTile(new Vector3Int(x, y, 0));

                    ReskinnableTileBase rtb = (ReskinnableTileBase)ScriptableObject.CreateInstance(typeof(ReskinnableTileBase));

                    if(tb == null || rtb == null || tb.name.Length < 1){
                        continue;
                    }

                    Sprite[] subSprite = null;

                    if(tb.name.Contains("forest")) {
                        subSprite = subSprites[0];
                    } else if(tb.name.Contains("wall")) {
                        subSprite = subSprites[1];
                    } else if(tb.name.Contains("canopy")) {
                        subSprite = subSprites[2];
                    } else if(tb.name.Contains("wang")) {
                        subSprite = subSprites[3];
                    } else {
                        continue;
                    }

                    Sprite replace = getSubSpriteByName(tb.name, subSprite);
                    rtb.sprite = replace;
                    rtb.name = tb.name;

                    tilemap.SwapTile(tb, (TileBase)rtb);
                }
            }
        }
    }

    void reloadSprites(){
        subSprites[0] = Resources.LoadAll<Sprite>("Spritesheets/Seasonal Forest Sheets/Forest sheets/" + sheetNames[0]);
        subSprites[1] = Resources.LoadAll<Sprite>("Spritesheets/Seasonal Forest Sheets/Tree walls/Tree walls/" + sheetNames[1]);
        subSprites[2] = Resources.LoadAll<Sprite>("Spritesheets/Seasonal Forest Sheets/Tree walls/Tree walls canopy/" + sheetNames[2]);
        subSprites[3] = Resources.LoadAll<Sprite>("Spritesheets/Seasonal Forest Sheets/wang/" + sheetNames[3]);
    }

    Sprite getSubSpriteByName(string name, Sprite[] sprites){
        foreach(Sprite s in sprites){
            if(s.name == name){
                return s;
            }
        }
        return null;
    }
}