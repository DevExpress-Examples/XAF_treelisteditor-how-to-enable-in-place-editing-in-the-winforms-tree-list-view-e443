using DevExpress.Persistent.Base.General;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace HowToUseTreeListEditor.Module;

public class Project : Category {
    protected override ITreeNode GetParent() {
        return ProjectGroup;
    }
    BindingList<ProjectArea> children;
    protected override IBindingList GetChildren() {
        if(children == null) {
            children = new BindingList<ProjectArea>(ProjectAreas);
        }
        return children;
    }
    public virtual ProjectGroup ProjectGroup { get; set; }
    public virtual IList<ProjectArea> ProjectAreas { get; set; } = new ObservableCollection<ProjectArea>();
}
