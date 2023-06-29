Imports System
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Persistent.BaseImpl

Namespace WinSolution.Module

    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As DevExpress.ExpressApp.IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub

        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            Dim p1 As Person = ObjectSpace.CreateObject(Of Person)()
            p1.FirstName = "Person1"
            Dim p2 As Person = ObjectSpace.CreateObject(Of Person)()
            p2.FirstName = "Person2"
            Dim pg As ProjectGroup = ObjectSpace.CreateObject(Of ProjectGroup)()
            pg.NameProp = "ProjectGroup1"
            pg.Person = p1
            Dim pr As Project = ObjectSpace.CreateObject(Of Project)()
            pr.NameProp = "Project1"
            pr.Person = p1
            pg.Projects.Add(pr)
            Dim pa As ProjectArea = ObjectSpace.CreateObject(Of ProjectArea)()
            pa.NameProp = "ProjectArea1"
            pa.Person = p1
            pr.ProjectAreas.Add(pa)
            p1.Save()
            p2.Save()
            pa.Save()
            pr.Save()
            pg.Save()
        End Sub
    End Class
End Namespace
