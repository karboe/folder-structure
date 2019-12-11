using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

public class CreateFolderStructure : MonoBehaviour
{
    [MenuItem("GameObject/Create Folder Structure")]


    static void CreateFolders()
    {
        List<string> folderNames = new List<string>()
    {
        "Animations","Editor","Media","Models","Materials","Plugins","Prefabs","Resources","Scenes","Scripts","Shaders","StreamingAssets","SandBox","Sprites"
    };
       

        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Assets");
 

        foreach (string folder in folderNames)
        {
            if (!Directory.Exists(Path.Combine(filePath, folder)))
            {
                string guid = AssetDatabase.CreateFolder("Assets", folder);
                string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

            }
          
        }

    }
}