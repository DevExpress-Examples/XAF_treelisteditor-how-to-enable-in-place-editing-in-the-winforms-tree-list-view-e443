<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595153/19.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E443)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [TreeListAppearanceControllerEx.cs](./CS/WinSolution.Module.Win/TreeListAppearanceControllerEx.cs) (VB: [TreeListAppearanceControllerEx.vb](./VB/WinSolution.Module.Win/TreeListAppearanceControllerEx.vb))
* [TreeListInplaceEditViewController.cs](./CS/WinSolution.Module.Win/TreeListInplaceEditViewController.cs) (VB: [TreeListInplaceEditViewController.vb](./VB/WinSolution.Module.Win/TreeListInplaceEditViewController.vb))
<!-- default file list end -->
# TreeListEditor - How to enable in-place editing in the WinForms tree List View (XPO)


<p>This example shows how to implement a custom ViewController that gets access to the TreeList control and makes it editable according to the XtraTreeList documentation:<br>    <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument5599">WinForms Controls > Controls > Tree List > Feature Center > Data Editing</a><br>    <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeListOptionsBehavior_Editabletopic">TreeListOptionsBehavior.Editable Property</a><br>    <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_ShowingEditortopic">TreeList.ShowingEditor Event</a><br>    <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_CellValueChangedtopic">TreeList.CellValueChanged Event</a><br>Take special note that this is not a complete solution and you will need to modify and test this example code further in other scenarios according to your business requirements. For instance, if you require supporting ConditionalAppearance rules, consider using the code from the <a href="https://www.devexpress.com/Support/Center/p/Q479878">Q479878</a> ticket. If you require supporting member-level security permissions, consider extending this example by analogy with the DevExpress.ExpressApp.Win.SystemModule.GridListEditorMemberLevelSecurityController class for GridListEditor.<br>Refer to the <a href="https://www.devexpress.com/Support/Center/p/S30514">Tree List Editors - How to edit data directly in the tree view (inplace / inline modifications)</a> thread to learn more about possible limitations and alternative solutions.</p>
<p> </p>
<p><strong>See also:<br></strong><a href="https://www.devexpress.com/Support/Center/p/E3570">How to enable in-place editing in the ASP.NET tree List View (ASPxTreeListEditor)</a></p>

<br/>


<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-win-enable-inplace-editing-in-tree-list-view&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-win-enable-inplace-editing-in-tree-list-view&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
