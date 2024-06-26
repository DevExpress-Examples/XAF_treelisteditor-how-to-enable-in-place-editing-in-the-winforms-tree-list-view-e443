<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E443)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# TreeListEditor - How to enable in-place editing in the WinForms tree List View

This example shows how to enable in place editing for WinForms TreeList control. 
![TreeListInplaceEF Win_gmXv5LULjX](https://github.com/DevExpress-Examples/XAF_treelisteditor-how-to-enable-in-place-editing-in-the-winforms-tree-list-view-e443/assets/14300209/b534e9ae-7c68-463b-99f5-2ab2ad475a2b)


## Implementation Details

This example implements a custom ViewController that gets access to the TreeList control and makes it editable according to the XtraTreeList documentation:
[Tree List > Feature Center > Data Editing](https://docs.devexpress.com/WindowsForms/5599/controls-and-libraries/tree-list/feature-center/data-editing)
[TreeListOptionsBehavior.Editable property](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeListOptionsBehavior.Editable)
[TreeList.ShowingEditor event](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.ShowingEditor)
[TreeList.CellValueChanged event](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.CellValueChanged)

Take special note that this is not a complete solution and you will need to modify and test this example code further in other scenarios according to your business requirements. For instance, if you require supporting ConditionalAppearance rules, consider using the code from the following ticket: [AppearanceRule for TreeList to Enable\Disable a property.](https://supportcenter.devexpress.com/ticket/details/q479878/appearancerule-for-treelist-to-enable-disable-a-property). If you require supporting member-level security permissions, consider extending this example by analogy with the DevExpress.ExpressApp.Win.SystemModule.GridListEditorMemberLevelSecurityController class for GridListEditor.Refer to the following thread to learn more about possible limitations and alternative solutions:  [Tree List Editors - How to edit data directly in the tree view (inplace / inline modifications)](https://supportcenter.devexpress.com/ticket/details/s30514/tree-list-editors-how-to-edit-data-directly-in-the-tree-view-inplace-inline-modifications)>.

## See also:
[Access List View Grid Component Settings Using a Controller (.NET 5)](https://docs.devexpress.com/eXpressAppFramework/402154/getting-started/in-depth-tutorial-blazor/extend-functionality/access-data-grid-settings)

## Files to Review

- [TreeListAppearanceControllerEx.cs](CS/EFCore/TreeListInplaceEF/TreeListInplaceEF.Win/Controllers/TreeListAppearanceControllerEx.cs) 
- [TreeListInplaceEditViewController.cs](CS/EFCore/TreeListInplaceEF/TreeListInplaceEF.Win/Controllers/TreeListInplaceEditViewController.cs) 

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF_treelisteditor-how-to-enable-in-place-editing-in-the-winforms-tree-list-view-e443&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF_treelisteditor-how-to-enable-in-place-editing-in-the-winforms-tree-list-view-e443&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
