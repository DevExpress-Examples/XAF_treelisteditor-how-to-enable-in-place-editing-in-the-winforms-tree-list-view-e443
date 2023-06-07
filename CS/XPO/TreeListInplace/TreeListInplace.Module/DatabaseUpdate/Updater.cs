using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using WinSolution.Module;

namespace TreeListInplace.Module.DatabaseUpdate;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
public class Updater : ModuleUpdater {
    public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
        base(objectSpace, currentDBVersion) {
    }
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();
        Person p1 = ObjectSpace.CreateObject<Person>();
        p1.FirstName = "Person1";
        Person p2 = ObjectSpace.CreateObject<Person>();
        p2.FirstName = "Person2";
        ProjectGroup pg = ObjectSpace.CreateObject<ProjectGroup>();
        pg.Name = "ProjectGroup1";
        pg.Person = p1;
        Project pr = ObjectSpace.CreateObject<Project>();
        pr.Name = "Project1";
        pr.Person = p1;
        pg.Projects.Add(pr);
        ProjectArea pa = ObjectSpace.CreateObject<ProjectArea>();
        pa.Name = "ProjectArea1";
        pa.Person = p1;
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
