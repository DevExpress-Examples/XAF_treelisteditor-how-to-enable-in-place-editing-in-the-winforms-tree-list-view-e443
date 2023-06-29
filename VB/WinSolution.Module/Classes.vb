Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports System.ComponentModel
Imports DevExpress.Persistent.Base.General

Namespace WinSolution.Module

    <NavigationItem>
    Public MustInherit Class Category
        Inherits BaseObject
        Implements ITreeNode

        Private nameField As String

        Protected MustOverride ReadOnly Property ParentProp As ITreeNode

        Protected MustOverride ReadOnly Property ChildrenProp As IBindingList

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Property NameProp As String
            Get
                Return nameField
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Name", nameField, value)
            End Set
        End Property

        Private _person As Person

        Public Property Person As Person
            Get
                Return _person
            End Get

            Set(ByVal value As Person)
                SetPropertyValue("Person", _person, value)
            End Set
        End Property

        Private _Active As Boolean

        Public Property Active As Boolean
            Get
                Return _Active
            End Get

            Set(ByVal value As Boolean)
                SetPropertyValue("Active", _Active, value)
            End Set
        End Property

#Region "ITreeNode"
        Private ReadOnly Property Children As IBindingList Implements ITreeNode.Children
            Get
                Return ChildrenProp
            End Get
        End Property

        Private ReadOnly Property Name As String Implements ITreeNode.Name
            Get
                Return NameProp
            End Get
        End Property

        Private ReadOnly Property Parent As ITreeNode Implements ITreeNode.Parent
            Get
                Return ParentProp
            End Get
        End Property
#End Region
    End Class

    Public Class ProjectGroup
        Inherits Category

        Protected Overrides ReadOnly Property ParentProp As ITreeNode
            Get
                Return Nothing
            End Get
        End Property

        Protected Overrides ReadOnly Property ChildrenProp As IBindingList
            Get
                Return Projects
            End Get
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal name As String)
            MyBase.New(session)
            NameProp = name
        End Sub

        <Association("ProjectGroup-Projects"), Aggregated>
        Public ReadOnly Property Projects As XPCollection(Of Project)
            Get
                Return GetCollection(Of Project)("Projects")
            End Get
        End Property
    End Class

    Public Class Project
        Inherits Category

        Private projectGroupField As ProjectGroup

        Protected Overrides ReadOnly Property ParentProp As ITreeNode
            Get
                Return projectGroupField
            End Get
        End Property

        Protected Overrides ReadOnly Property ChildrenProp As IBindingList
            Get
                Return ProjectAreas
            End Get
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal name As String)
            MyBase.New(session)
            NameProp = name
        End Sub

        <Association("ProjectGroup-Projects")>
        Public Property ProjectGroup As ProjectGroup
            Get
                Return projectGroupField
            End Get

            Set(ByVal value As ProjectGroup)
                projectGroupField = value
                SetPropertyValue("ProjectGroup", projectGroupField, value)
            End Set
        End Property

        <Association("Project-ProjectAreas"), Aggregated>
        Public ReadOnly Property ProjectAreas As XPCollection(Of ProjectArea)
            Get
                Return GetCollection(Of ProjectArea)("ProjectAreas")
            End Get
        End Property
    End Class

    Public Class ProjectArea
        Inherits Category

        Private projectField As Project

        Protected Overrides ReadOnly Property ParentProp As ITreeNode
            Get
                Return projectField
            End Get
        End Property

        Protected Overrides ReadOnly Property ChildrenProp As IBindingList
            Get
                Return New BindingList(Of Object)()
            End Get
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal name As String)
            MyBase.New(session)
            NameProp = name
        End Sub

        <Association("Project-ProjectAreas")>
        Public Property Project As Project
            Get
                Return projectField
            End Get

            Set(ByVal value As Project)
                projectField = value
                SetPropertyValue("Project", projectField, value)
            End Set
        End Property
    End Class
End Namespace
