using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.General;
using DevExpress.Persistent.BaseImpl.EF;
using MySolution.Module.BusinessObjects;
using System.ComponentModel;

namespace HowToUseTreeListEditor.Module;

[NavigationItem]
public abstract class Category : BaseObject, ITreeNode {
    protected abstract ITreeNode GetParent();
    protected abstract IBindingList GetChildren();

    public virtual Contact Contact { get; set; }
    public virtual bool Active { get; set; }
    public virtual string Name { get; set; }
    #region ITreeNode
    IBindingList ITreeNode.Children {
        get {
            return GetChildren();
        }
    }
    string ITreeNode.Name {
        get {
            return Name;
        }
    }
    ITreeNode ITreeNode.Parent {
        get {
            return GetParent();
        }
    }
    #endregion
}