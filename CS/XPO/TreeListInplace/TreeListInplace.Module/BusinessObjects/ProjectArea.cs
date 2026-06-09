using DevExpress.Persistent.Base.General;
using DevExpress.Xpo;
using System.ComponentModel;

namespace WinSolution.Module;

public class ProjectArea : Category {
    private Project project;
    protected override ITreeNode GetParent() {
        return Project;
    }
    protected override IBindingList GetChildren() {
        return new BindingList<object>();
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

