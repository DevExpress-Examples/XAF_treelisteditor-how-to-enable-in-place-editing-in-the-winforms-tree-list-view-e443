using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using System.ComponentModel;
using DevExpress.Persistent.Base.General;
using DevExpress.Data.Filtering;

namespace WinSolution.Module {
    [NavigationItem]
    public abstract class Category : BaseObject, ITreeNode {
        private string name;
        protected abstract ITreeNode Parent {
            get;
        }
        protected abstract IBindingList Children {
            get;
        }
        public Category(Session session) : base(session) { }
        public string Name {
            get {
                return name;
            }
            set {
                SetPropertyValue("Name", ref name, value);
            }
        }
        private Person _person;
        public Person Person {
            get { return _person; }
            set { SetPropertyValue("Person", ref _person, value); }
        }
        private bool _Active;
        public bool Active {
            get { return _Active; }
            set { SetPropertyValue("Active", ref _Active, value); }
        }
        #region ITreeNode
        IBindingList ITreeNode.Children {
            get {
                return Children;
            }
        }
        string ITreeNode.Name {
            get {
                return Name;
            }
        }
        ITreeNode ITreeNode.Parent {
            get {
                return Parent;
            }
        }
        #endregion
    }
}
