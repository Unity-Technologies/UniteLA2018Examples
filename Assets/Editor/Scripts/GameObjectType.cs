﻿using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEditor.Experimental.SceneManagement;

public class GameObjectType
{
    [MenuItem("Prefabs/Query/Get GameObject Info")]
    static void LogSelectedGameObjectInfo()
    {
        var go = Selection.activeGameObject;
        if (go == null)
        {
            Debug.Log("Please select a GameObject");
            return;
        }

        GameObjectTypeLogging.LogGameObjectInformation(go);
    }
}
