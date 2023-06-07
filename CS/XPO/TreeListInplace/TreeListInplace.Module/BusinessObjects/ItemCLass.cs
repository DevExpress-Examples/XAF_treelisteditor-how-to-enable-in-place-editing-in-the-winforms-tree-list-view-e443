using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace WinSolution.Module {
    [DefaultListViewOptions(true, DevExpress.ExpressApp.NewItemRowPosition.None)]
    [Appearance("Can Edit Value", TargetItems = "Value", Criteria = "not (Owner.CanEdit and CanEdit)", Enabled = false)]
    public class ItemCLass : HCategory {
        public ItemCLass(Session s) : base(s) { }
        private OwnerClass _Owner;
        [Association]
        public OwnerClass Owner {
            get { return _Owner; }
            set { SetPropertyValue<OwnerClass>("Owner", ref _Owner, value); }
        }
        private bool _CanEdit;
        [ImmediatePostData]
        public bool CanEdit {
            get { return _CanEdit; }
            set { SetPropertyValue<bool>("CanEdit", ref _CanEdit, value); }
        }
        private int _Value;
        public int Value {
            get { return _Value; }
            set { SetPropertyValue<int>("Value", ref _Value, value); }
        }
    }

}
