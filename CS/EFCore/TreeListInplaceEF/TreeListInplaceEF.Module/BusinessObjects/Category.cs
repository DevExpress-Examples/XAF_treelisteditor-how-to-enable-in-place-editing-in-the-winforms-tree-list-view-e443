using System;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Persistent.Base.General;
using System.ComponentModel;
using DevExpress.Persistent.BaseImpl.EF;
using MySolution.Module.BusinessObjects;

namespace HowToUseTreeListEditor.Module {
    [NavigationItem]
    public abstract class Category : BaseObject, ITreeNode {
        protected abstract ITreeNode Parent {
            get;
        }
        protected abstract IBindingList Children {
            get;
        }
        public virtual Contact Contact { get; set; }
        public virtual bool Active { get; set; }
        public virtual string Name { get; set; }
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
