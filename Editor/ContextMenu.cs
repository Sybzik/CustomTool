using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.UI;
using System.Collections;
using System.Collections.Generic;
using System; using System.Reflection;

public class ContextMenu
{
    //Console.Clear();
    [MenuItem("Utills/PlayerPrefs/Delete All", false, 101)]
    public static void _delData() { PlayerPrefs.DeleteAll(); }
    [MenuItem("Utills/Debug/Get Number Of Objects", false, 101)]
    public static void _getCountOfObj() {
        List<GameObject> list = new List<GameObject>();
        
        for (int i = 0; i < GameObject.FindObjectsOfType<GameObject>().Length; i++)
        {
            list.Add(GameObject.FindObjectsOfType<GameObject>()[i]);
        }
        int j = 0;
        foreach (var gj in list)
        {
            
            Debug.Log("<color=red>" + j +"</color> | " + GameObject.FindObjectsOfType<GameObject>()[j].name);
            j++;    
        }
        Debug.Log("<color=green>" + j + "</color> | " + "Number of Objects");
        
    }

    [MenuItem("Utills/Debug/Clear console", false, 101)]
    public static void _clearConsole()
    {
        Assembly assembly = Assembly.GetAssembly(typeof(SceneView));

        Type type = assembly.GetType("UnityEditor.LogEntries");
        MethodInfo method = type.GetMethod("Clear");
        method.Invoke(new object(), null);
    }

    [MenuItem("Utills/Instantiate/Platform", false, 101)]
    public static void _platform()
    {
        string fileLocation = "Assets/Editor/Prefabs/Platform.prefab";
        GameObject prefab = AssetDatabase.LoadAssetAtPath(fileLocation, typeof(GameObject)) as GameObject;

        if (prefab == null)
            Debug.LogWarning("<color=red>Fatal error:</color> The file in the directory: " + fileLocation + " was not found | Check if the directory is correct");
        else
        {
            PrefabUtility.InstantiatePrefab(prefab);
            prefab.transform.position = Vector3.zero;
            Debug.Log("<color=green>Instantiate: " + prefab.name + " | Successfully</color>");
        }
    }

    [MenuItem("Utills/Instantiate/CrossHair", false, 101)]
    public static void _crossHair()
    {
        string fileLocation = "Assets/Editor/Prefabs/UiPrefabs/CrossHair.prefab";
        GameObject prefab = AssetDatabase.LoadAssetAtPath(fileLocation, typeof(GameObject)) as GameObject;

        if (prefab == null)
            Debug.LogWarning("<color=red>Fatal error:</color> The file in the directory: " + fileLocation + " was not found | Check if the directory is correct");
        else
        {
            if (GameObject.FindObjectOfType<Canvas>())
            {
                PrefabUtility.InstantiatePrefab(prefab, GameObject.FindObjectOfType<Canvas>().transform);
                prefab.transform.position = Vector3.zero;
                Debug.Log("<color=green>Instantiate: " + prefab.name + " | Successfully</color>");
            }
            else
            {
                string canvasfileLocation = "Assets/Editor/Prefabs/UiPrefabs/Canvas.prefab";
                GameObject canvasPref = AssetDatabase.LoadAssetAtPath(canvasfileLocation, typeof(GameObject)) as GameObject;
                PrefabUtility.InstantiatePrefab(canvasPref);
                canvasPref.transform.position = Vector3.zero;

                string eventfileLocation = "Assets/Editor/Prefabs/UiPrefabs/EventSystem.prefab";
                GameObject eventPref = AssetDatabase.LoadAssetAtPath(eventfileLocation, typeof(GameObject)) as GameObject;
                PrefabUtility.InstantiatePrefab(eventPref);
                eventPref.transform.position = Vector3.zero;

                PrefabUtility.InstantiatePrefab(prefab, GameObject.FindObjectOfType<Canvas>().transform);
                prefab.transform.position = new Vector3(0f, 0f, 0f);
                Debug.Log("<color=green>Instantiate: " + prefab.name + " | Successfully</color>");
            }
        }
    }

    [MenuItem("Utills/Instantiate/Timer", false, 101)]
    public static void _timer()
    {
        string fileLocation = "Assets/Editor/Prefabs/UiPrefabs/TimerText.prefab";
        GameObject prefab = AssetDatabase.LoadAssetAtPath(fileLocation, typeof(GameObject)) as GameObject;

        if (prefab == null)
            Debug.LogWarning("<color=red>Fatal error:</color> The file in the directory: " + fileLocation + " was not found | Check if the directory is correct");
        else
        {
            if (GameObject.FindObjectOfType<Canvas>())
            {
                PrefabUtility.InstantiatePrefab(prefab, GameObject.FindObjectOfType<Canvas>().transform);
                prefab.transform.position = Vector3.zero;
                Debug.Log("<color=green>Instantiate: " + prefab.name + " | Successfully</color>");
            }
            else
            {
                string canvasfileLocation = "Assets/Editor/Prefabs/UiPrefabs/Canvas.prefab";
                GameObject canvasPref = AssetDatabase.LoadAssetAtPath(canvasfileLocation, typeof(GameObject)) as GameObject;
                PrefabUtility.InstantiatePrefab(canvasPref);
                canvasPref.transform.position = Vector3.zero;

                string eventfileLocation = "Assets/Editor/Prefabs/UiPrefabs/EventSystem.prefab";
                GameObject eventPref = AssetDatabase.LoadAssetAtPath(eventfileLocation, typeof(GameObject)) as GameObject;
                PrefabUtility.InstantiatePrefab(eventPref);
                eventPref.transform.position = Vector3.zero;

                PrefabUtility.InstantiatePrefab(prefab, GameObject.FindObjectOfType<Canvas>().transform);
                prefab.transform.position = Vector3.zero;
                Debug.Log("<color=green>Instantiate: " + prefab.name + " | Successfully</color>");
            }
        }
    }

    [MenuItem("Utills/Instantiate/Window preset", false, 101)]
    public static void _window()
    {
        string fileLocation = "Assets/Editor/Prefabs/UiPrefabs/WindowPreset.prefab";
        GameObject prefab = AssetDatabase.LoadAssetAtPath(fileLocation, typeof(GameObject)) as GameObject;

        if (prefab == null)
            Debug.LogWarning("<color=red>Fatal error:</color> The file in the directory: " + fileLocation + " was not found | Check if the directory is correct");
        else
        {
            if (GameObject.FindObjectOfType<Canvas>())
            {
                PrefabUtility.InstantiatePrefab(prefab, GameObject.FindObjectOfType<Canvas>().transform);
                prefab.transform.position = Vector3.zero;
                Debug.Log("<color=green>Instantiate: " + prefab.name + " | Successfully</color>");
            }
            else
            {
                string canvasfileLocation = "Assets/Editor/Prefabs/UiPrefabs/Canvas.prefab";
                GameObject canvasPref = AssetDatabase.LoadAssetAtPath(canvasfileLocation, typeof(GameObject)) as GameObject;
                PrefabUtility.InstantiatePrefab(canvasPref);
                canvasPref.transform.position = Vector3.zero;

                string eventfileLocation = "Assets/Editor/Prefabs/UiPrefabs/EventSystem.prefab";
                GameObject eventPref = AssetDatabase.LoadAssetAtPath(eventfileLocation, typeof(GameObject)) as GameObject;
                PrefabUtility.InstantiatePrefab(eventPref);
                eventPref.transform.position = Vector3.zero;

                PrefabUtility.InstantiatePrefab(prefab, GameObject.FindObjectOfType<Canvas>().transform);
                prefab.transform.position = Vector3.zero;
                Debug.Log("<color=green>Instantiate: " + prefab.name + " | Successfully</color>");
            }
        }
    }

}
