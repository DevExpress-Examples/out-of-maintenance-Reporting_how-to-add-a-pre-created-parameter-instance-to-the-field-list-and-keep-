Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Windows.Forms
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.Parameters

Namespace Parameters
    Partial Public Class Form2
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
            Dim parameter As New Parameter()
            parameter.Name = "MyDateTimeParameter"
            parameter.Type = GetType(Date)
            xrDesignPanel1.Report.Parameters.Add(parameter)
            AddField(parameter, "MyParameter")
        End Sub

        Private Sub AddField(ByVal objeto As IComponent, ByVal desiredName As String)
            Dim host As IDesignerHost = TryCast(xrDesignPanel1.GetService(GetType(IDesignerHost)), IDesignerHost)
            If host IsNot Nothing Then
                DesignTool.AddToContainer(host, objeto, desiredName)
            End If
        End Sub
    End Class
End Namespace
