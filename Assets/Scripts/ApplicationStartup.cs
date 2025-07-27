using RuntimeNodeEditor;
using UnityEngine;


public class ApplicationStartup : MonoBehaviour
{
    public RectTransform editorHolder;
    public GameObject ctxMenuPrefab;

    private NodeEditorTest _editor;

    private void Start()
    {
        _editor = gameObject.AddComponent<NodeEditorTest>();
        _editor.contextMenuPrefab = ctxMenuPrefab; 
        var graph = _editor.CreateGraph<NodeGraph>(editorHolder,Color.black, Color.green);
        _editor.StartEditor(graph);
    }
}