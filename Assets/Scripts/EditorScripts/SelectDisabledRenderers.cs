using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class SelectDisabledRenderers : EditorWindow
{
    //Now you can select the Tools menu at the top, then hit Select Disabled Renderers
    [MenuItem("Tools/Select Disabled Renderers")]
    public static void Select()
    {
        // Find all renderer components in the scene, including inactive objects (true as second argument in older versions)
        // For newer Unity versions, the FindObjectsByType method is used.
        Renderer[] renderers = FindObjectsByType<Renderer>(FindObjectsSortMode.None);

        List<GameObject> disabledRendererObjects = new List<GameObject>();

        foreach (Renderer renderer in renderers)
        {
            // Check if the renderer component is disabled
            if (!renderer.enabled)
            {
                disabledRendererObjects.Add(renderer.gameObject);
            }
        }

        // Select all found GameObjects
        Selection.objects = disabledRendererObjects.ToArray();
        Debug.Log("Found and selected " + disabledRendererObjects.Count + " objects with disabled renderers.");
    }
}
