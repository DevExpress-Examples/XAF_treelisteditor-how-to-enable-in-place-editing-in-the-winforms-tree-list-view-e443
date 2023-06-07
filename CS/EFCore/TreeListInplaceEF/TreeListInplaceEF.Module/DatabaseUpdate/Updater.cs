using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;
using MySolution.Module.BusinessObjects;
using HowToUseTreeListEditor.Module;

namespace TreeListInplace.Module.DatabaseUpdate;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
public class Updater : ModuleUpdater {
    public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
        base(objectSpace, currentDBVersion) {
    }
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();
        var cnt = ObjectSpace.GetObjectsCount(typeof(Contact), null);
        if(cnt > 0) {
            return;
        }
        Contact p1 = ObjectSpace.CreateObject<Contact>();
        p1.FirstName = "Contact1";
        Contact p2 = ObjectSpace.CreateObject<Contact>();
        p2.FirstName = "Contact2";
        ProjectGroup pg = ObjectSpace.CreateObject<ProjectGroup>();
        pg.Name = "ProjectGroup1";
        pg.Contact = p1;
        Project pr = ObjectSpace.CreateObject<Project>();
        pr.Name = "Project1";
        pr.Contact = p1;
        pg.Projects.Add(pr);
        ProjectArea pa = ObjectSpace.CreateObject<ProjectArea>();
        pa.Name = "ProjectArea1";
        pa.Contact = p1;
        pr.ProjectAreas.Add(pa);

        ObjectSpace.CommitChanges();
    }
    public override void UpdateDatabaseBeforeUpdateSchema() {
        base.UpdateDatabaseBeforeUpdateSchema();
        //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
        //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
        //}
    }
}
