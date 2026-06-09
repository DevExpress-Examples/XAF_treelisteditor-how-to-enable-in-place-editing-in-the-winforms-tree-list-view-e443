using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.TreeListEditors.Win;
using DevExpress.ExpressApp.Win.Controls;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraTreeList;

namespace WinSolution.Module.Win;

public class TreeListAppearanceControllerEx : TreeListAppearanceController {
    protected override void OnTreeListChanged() {
        base.OnTreeListChanged();
        if(Active.ResultValue && View?.Editor is TreeListEditor treeListEditor && treeListEditor.TreeList != null) {
            treeListEditor.TreeList.ShowingEditor += control_ShowingEditor;
        }
    }
    protected override void UnsubscribeToListEditorEvent() {
        if(View?.Editor is TreeListEditor treeListEditor && treeListEditor.TreeList != null) {
            treeListEditor.TreeList.ShowingEditor -= control_ShowingEditor;
        }
        base.UnsubscribeToListEditorEvent();
    }
    void control_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e) {
        var tl = (TreeList)sender;
        var node = tl.FocusedNode as ObjectTreeListNode;
        if(node == null) return;
        OnCustomizeAppearance(new CustomizeAppearanceEventArgs(tl.FocusedColumn.FieldName, "ViewItem", new GridViewCancelEventArgsAppearanceAdapter(null, e), node.Object, null));
    }
}