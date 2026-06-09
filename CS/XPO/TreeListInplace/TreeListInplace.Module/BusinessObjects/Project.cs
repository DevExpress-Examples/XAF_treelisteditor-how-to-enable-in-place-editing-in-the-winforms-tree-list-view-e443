using DevExpress.Persistent.Base.General;
using DevExpress.Xpo;
using System.ComponentModel;

namespace WinSolution.Module;

public class Project : Category {
    private ProjectGroup projectGroup;
    protected override ITreeNode GetParent() {
        return ProjectGroup;
    }
    protected override IBindingList GetChildren() {
        return ProjectAreas;
    }
    public Project(Session session) : base(session) { }
    public Project(Session session, string name)
        : base(session) {
        this.Name = name;
    }
    [Association("ProjectGroup-Projects")]
    public ProjectGroup ProjectGroup {
        get {
            return projectGroup;
        }
        set {
            projectGroup = value;
            SetPropertyValue("ProjectGroup", ref projectGroup, value);
        }
    }
    [Association("Project-ProjectAreas"), Aggregated]
    public XPCollection<ProjectArea> ProjectAreas {
        get {
            return GetCollection<ProjectArea>("ProjectAreas");
        }
    }
}