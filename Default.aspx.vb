Imports Microsoft.SqlServer.Dts.Runtime
Imports System.Net
Imports System.IO
Public Class _Default
    Inherits Page

    Dim pkSSIS = Nothing
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        pkSSIS = Server.MapPath("~/SSISPackage/Package.dtsx")
        lbResultSSISExecute.Visible = False

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_GenerateExcelFile.Click

        Dim error_Msg As String = ""
        lbResultSSISExecute.Text = "The package is executing..."
        Dim pkg As Package = Nothing
        Dim app As Microsoft.SqlServer.Dts.Runtime.Application
        Dim result As DTSExecResult
        Try
            app = New Microsoft.SqlServer.Dts.Runtime.Application()
            pkg = app.LoadPackage(pkSSIS, Nothing)
            result = pkg.Execute()
            If result = Microsoft.SqlServer.Dts.Runtime.DTSExecResult.Failure Then
                For Each dt_error As Microsoft.SqlServer.Dts.Runtime.DtsError In pkg.Errors
                    error_Msg += dt_error.Description.ToString()
                Next
                lbResultSSISExecute.Text = error_Msg
            End If
            If result = Microsoft.SqlServer.Dts.Runtime.DTSExecResult.Success Then
                lbResultSSISExecute.Text = "Success!"
                lbResultSSISExecute.Visible = True

            End If
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
End Class