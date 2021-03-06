﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.ViewInfo
Imports DevExpress.XtraTreeList.Nodes

Namespace TreeListDrawImage
    Partial Public Class Form1
        Inherits Form

        Private helper As DrawHelper
        Public Sub New()
            InitializeComponent()
            AddNodes()
            helper = New DrawHelper()
            helper.RegisterTreeList(treeList1, My.Resources.Asphalt_World___16x16)
            AddHandler helper.ImageClick, AddressOf helper_ImageClick
        End Sub

        Private Sub helper_ImageClick(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("Click!")
        End Sub

        Private Sub AddNodes()
            For i As Integer = 0 To 9
                treeList1.AppendNode(New Object() { String.Format("Node {0}", i) }, -1)
            Next i
        End Sub
        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            RemoveHandler helper.ImageClick, AddressOf helper_ImageClick
            helper.Unregister()
            MyBase.OnFormClosing(e)
        End Sub
    End Class
End Namespace
