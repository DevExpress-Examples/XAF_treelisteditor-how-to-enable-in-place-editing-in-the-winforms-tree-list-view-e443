using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.General;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using dxTestSolution.Module.BusinessObjects;
using System.ComponentModel;

namespace WinSolution.Module;

[NavigationItem]
public abstract class Category : BaseObject, ITreeNode {
    private string name;
    protected abstract ITreeNode GetParent();
    protected abstract IBindingList GetChildren();
    public Category(Session session) : base(session) { }
    public string Name {
        get {
            return name;
        }
        set {
            SetPropertyValue(nameof(Name), ref name, value);
        }
    }
    private Contact _person;
    public Contact Contact {
        get { return _person; }
        set { SetPropertyValue(nameof(Contact), ref _person, value); }
    }
    private bool _Active;
    public bool Active {
        get { return _Active; }
        set { SetPropertyValue(nameof(Active), ref _Active, value); }
    }
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

