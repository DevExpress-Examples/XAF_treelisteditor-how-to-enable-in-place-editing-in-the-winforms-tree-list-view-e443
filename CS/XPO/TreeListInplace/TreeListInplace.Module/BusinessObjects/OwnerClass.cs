using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSolution.Module {

    [NavigationItem]
    [Appearance("Can Edit Items", TargetItems = "Items", Criteria = "!CanEdit", Enabled = false)]
    public class OwnerClass : BaseObject {
        public OwnerClass(Session s) : base(s) { }
        private bool _CanEdit;
        [ImmediatePostData]
        public bool CanEdit {
            get { return _CanEdit; }
            set { SetPropertyValue<bool>("CanEdit", ref _CanEdit, value); }
        }
        [Aggregated]
        [Association]
        public XPCollection<ItemCLass> Items {
            get { return GetCollection<ItemCLass>("Items"); }
        }
    }

}
