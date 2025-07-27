using UnityEngine;
using RuntimeNodeEditor;
using UnityEngine.EventSystems;

public class NodeEditorTest : NodeEditor
{
    public override void StartEditor(NodeGraph graph)
    {
        base.StartEditor(graph);

        // use fluent builder create a context
        var ctx = new ContextMenuBuilder()
            .Add("nodes/float", () => Graph.Create("Nodes/FloatNode"))
            .Add("nodes/operation", () => Graph.Create("Nodes/MathOperationNode"))
            .Build();
        // set the context
        SetContextMenu(ctx);
        // listen for graph events
        Events.OnGraphPointerClickEvent += OnClick;
    }
    private void OnClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            CloseContextMenu();
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            DisplayContextMenu();
        }
    }
}
