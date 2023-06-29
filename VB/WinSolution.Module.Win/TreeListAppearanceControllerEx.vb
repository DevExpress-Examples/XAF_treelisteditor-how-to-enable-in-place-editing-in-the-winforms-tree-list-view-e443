Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.TreeListEditors.Win
Imports DevExpress.ExpressApp.Win.Controls
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.XtraTreeList

Namespace WinSolution.Module.Win

    Public Class TreeListAppearanceControllerEx
        Inherits TreeListAppearanceController

        Protected Overrides Sub OnTreeListChanged()
            MyBase.OnTreeListChanged()
            If Active.ResultValue AndAlso View IsNot Nothing AndAlso View.Editor IsNot Nothing AndAlso TypeOf View.Editor Is TreeListEditor AndAlso CType(View.Editor, TreeListEditor).TreeList IsNot Nothing Then
                AddHandler CType(View.Editor, TreeListEditor).TreeList.ShowingEditor, New System.ComponentModel.CancelEventHandler(AddressOf control_ShowingEditor)
            End If
        End Sub

        Private Sub control_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Dim tl As TreeList = CType(sender, TreeList)
            Dim node As ObjectTreeListNode = TryCast(tl.FocusedNode, ObjectTreeListNode)
            If node Is Nothing Then Return
            OnCustomizeAppearance(New CustomizeAppearanceEventArgs(tl.FocusedColumn.FieldName, "ViewItem", New GridViewCancelEventArgsAppearanceAdapter(Nothing, e), node.Object, Nothing))
        End Sub
    End Class
End Namespace
