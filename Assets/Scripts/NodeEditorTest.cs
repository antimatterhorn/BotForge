using UnityEngine;
using RuntimeNodeEditor;

public class NodeEditorTest : MonoBehaviour
{
    public RectTransform holderPanel;
    public GameObject contextMenuPrefab;

    void Start()
    {
        var editor = gameObject.AddComponent<NodeEditor>();
        editor.contextMenuPrefab = contextMenuPrefab;

        var graph = editor.CreateGraph<NodeGraph>(holderPanel, Color.gray, Color.yellow);
        editor.StartEditor(graph);
    }
}
