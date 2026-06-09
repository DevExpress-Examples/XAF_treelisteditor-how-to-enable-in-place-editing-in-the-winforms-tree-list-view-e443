using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.TreeListEditors.Win;
using DevExpress.ExpressApp.Win.Controls;
using DevExpress.ExpressApp.Win.Core;
using DevExpress.Persistent.BaseImpl;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;

namespace WinSolution.Module.Win;

public class TreeListInplaceEditViewController : ViewController<ListView> {
    protected override void OnActivated() {
        base.OnActivated();
        var treeListEditor = View.Editor as TreeListEditor;
        if(treeListEditor != null) {
            treeListEditor.AllowEditChanged += treeListEditor_AllowEditChanged;
            treeListEditor.ControlsCreated += treeListEditor_ControlsCreated;
            UpdateEditableTreeList(treeListEditor);
            SubscribeToControlEvents(treeListEditor.TreeList);
        }
    }
    void treeListEditor_ControlsCreated(object sender, EventArgs e) {
        var treeListEditor = (TreeListEditor)sender;
        UpdateEditableTreeList(treeListEditor);
        SubscribeToControlEvents(treeListEditor.TreeList);
    }
    private void SubscribeToControlEvents(TreeList treeList) {
        if(treeList != null) {
            treeList.CellValueChanged += treeList_CellValueChanged;
            treeList.ShownEditor += treeList_ShownEditor;
        }
    }
    private void UnsubscribeToControlEvents(TreeList treeList) {
        if(treeList != null) {
            treeList.CellValueChanged -= treeList_CellValueChanged;
            treeList.ShownEditor -= treeList_ShownEditor;
        }
    }

    protected override void OnDeactivated() {
        var treeListEditor = View.Editor as TreeListEditor;
        if(treeListEditor != null) {
            treeListEditor.AllowEditChanged -= treeListEditor_AllowEditChanged;
            treeListEditor.ControlsCreated -= treeListEditor_ControlsCreated;
            UnsubscribeToControlEvents(treeListEditor.TreeList);
        }
        base.OnDeactivated();
    }
    private void UpdateEditableTreeList(TreeListEditor treeListEditor) {
        var treeList = treeListEditor.TreeList as ObjectTreeList;
        if(treeList != null) {
            treeList.OptionsBehavior.Editable = treeListEditor.AllowEdit;
            foreach(RepositoryItem ri in treeList.RepositoryItems) {
                ri.ReadOnly = !treeListEditor.AllowEdit;
            }
            foreach(TreeListColumnWrapper columnWrapper in treeListEditor.Columns) {
                IModelColumn modelColumn = View.Model.Columns[columnWrapper.PropertyName];
                if(modelColumn != null)
                    columnWrapper.Column.OptionsColumn.AllowEdit = modelColumn.AllowEdit;
            }
            treeList.OptionsBehavior.ImmediateEditor = true;
        }
    }
    void treeListEditor_AllowEditChanged(object sender, EventArgs e) {
        UpdateEditableTreeList((TreeListEditor)sender);
    }
    private void treeList_ShownEditor(object sender, EventArgs e) {
        var treeList = (ObjectTreeList)sender;
        var activeEditor = treeList.ActiveEditor as IGridInplaceEdit;
        if(activeEditor != null && treeList.FocusedObject is BaseObject) {
            activeEditor.GridEditingObject = treeList.FocusedObject;
        }
    }
    private void treeList_CellValueChanged(object sender, CellValueChangedEventArgs e) {
        if(!e.ChangedByUser)
            return;

        var treeList = (ObjectTreeList)sender;
        object focusedObject = treeList.FocusedObject;
        if(focusedObject != null) {
            IMemberInfo focusedColumnMemberInfo = ObjectSpace.TypesInfo.FindTypeInfo(focusedObject.GetType()).FindMember(e.Column.FieldName);
            if(focusedColumnMemberInfo != null) {
                object newValue = e.Value is BaseObject ? ObjectSpace.GetObject(e.Value) : e.Value;
                focusedColumnMemberInfo.SetValue(focusedObject, newValue);
            }
        }
    }
}