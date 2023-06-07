using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Persistent.Base.General;

namespace WinSolution.Module {
    public class ProjectArea : Category {
        private Project project;
        protected override ITreeNode Parent {
            get {
                return project;
            }
        }
        protected override IBindingList Children {
            get {
                return new BindingList<object>();
            }
        }
        public ProjectArea(Session session) : base(session) { }
        public ProjectArea(Session session, string name)
            : base(session) {
            this.Name = name;
        }
        [Association("Project-ProjectAreas")]
        public Project Project {
            get {
                return project;
            }
            set {
                project = value;
                SetPropertyValue("Project", ref project, value);
            }
        }
    }
}
