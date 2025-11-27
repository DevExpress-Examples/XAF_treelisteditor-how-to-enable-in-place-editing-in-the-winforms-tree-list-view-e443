<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595153/25.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E443)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# XAF WinForms - How to enable in-place editing in the Tree List View (TreeListEditor)

This example enables in-place editing for the WinForms TreeList control.

![TreeListInplaceEF Win_gmXv5LULjX](https://github.com/DevExpress-Examples/XAF_treelisteditor-how-to-enable-in-place-editing-in-the-winforms-tree-list-view-e443/assets/14300209/b534e9ae-7c68-463b-99f5-2ab2ad475a2b)

## Implementation Details

This example implements a custom View Controller ([TreeListInplaceEditViewController.cs](CS/EFCore/TreeListInplaceEF/TreeListInplaceEF.Win/Controllers/TreeListInplaceEditViewController.cs)). This controller gets access to the WinForms [TreeList](https://docs.devexpress.com/WindowsForms/2434/controls-and-libraries/tree-list) control and uses its API to make control data editable.

> **Note**:
> This example is not a complete solution. Thoroughly test, extend, and modify its code to meet your business requirements.

Possible limitations and alternative solutions:  [Tree List Editors - How to edit data directly in the tree view (inplace / inline modifications)](https://supportcenter.devexpress.com/ticket/details/s30514/tree-list-editors-how-to-edit-data-directly-in-the-tree-view-inplace-inline-modifications).

## Files to Review

- [TreeListAppearanceControllerEx.cs](CS/EFCore/TreeListInplaceEF/TreeListInplaceEF.Win/Controllers/TreeListAppearanceControllerEx.cs) 
- [TreeListInplaceEditViewController.cs](CS/EFCore/TreeListInplaceEF/TreeListInplaceEF.Win/Controllers/TreeListInplaceEditViewController.cs) 

## Documentation

* [How to: Access the Grid Component in a List View](https://docs.devexpress.com/eXpressAppFramework/402154/ui-construction/list-editors/how-to-access-list-editor-control)
* [Tree List > Feature Center > Data Editing](https://docs.devexpress.com/WindowsForms/5599/controls-and-libraries/tree-list/feature-center/data-editing)
* [TreeListOptionsBehavior.Editable property](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeListOptionsBehavior.Editable)
* [TreeList.ShowingEditor event](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.ShowingEditor)
* [TreeList.CellValueChanged event](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.CellValueChanged)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-win-enable-inplace-editing-in-tree-list-view&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-win-enable-inplace-editing-in-tree-list-view&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
