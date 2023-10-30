using UnityEngine;
using UnityEditor;
using System.Collections;

public class SpriteRenamer : MonoBehaviour
{
    public Texture2D[] texture2Ds;
    public string newName;

    private string path;
    private TextureImporter textureImporter;

    void Start ()
    {
        foreach(Texture2D texture2D in texture2Ds){
            path = AssetDatabase.GetAssetPath (texture2D);
            textureImporter = AssetImporter.GetAtPath (path) as TextureImporter;
            SpriteMetaData[] sliceMetaData = textureImporter.spritesheet;

            int index = 0;
            foreach (SpriteMetaData individualSliceData in sliceMetaData)
            {
                sliceMetaData[index].name = string.Format (newName + "_{0}", index);
                print (sliceMetaData[index].name);

                index++;
            }

            textureImporter.spritesheet = sliceMetaData;
            EditorUtility.SetDirty (textureImporter);
            textureImporter.SaveAndReimport ();

            AssetDatabase.ImportAsset (path, ImportAssetOptions.ForceUpdate);
        }
    }
}