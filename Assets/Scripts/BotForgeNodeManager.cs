using UnityEngine;
using UnityEngine.UI;
using RuntimeNodeEditor;

public class BotForgeNodeManager : MonoBehaviour
{
    public RectTransform nodeHolder;          // This is your NodeEditorPanel
    public NodeEditor nodeEditorPrefab;       // Optional prefab, or just add NodeEditor in scene
    public GameObject contextMenuPrefab;      // From the RuntimeNodeEditor package

    private NodeEditor nodeEditor;

    void Start()
    {
        Debug.Log("Creating node editor...");
        // Create or find a NodeEditor instance
        nodeEditor = GetComponent<NodeEditor>();
        if (nodeEditor == null)
            nodeEditor = gameObject.AddComponent<NodeEditor>();

        nodeEditor.contextMenuPrefab = contextMenuPrefab;

        Debug.Log("Creating graph...");
        var graph = nodeEditor.CreateGraph<NodeGraph>(nodeHolder, Color.black, Color.cyan);

        Debug.Log("Starting editor...");
        nodeEditor.StartEditor(graph);
    }
}

