Public Class frmPassword
    Private mPassword As String
    Public ReadOnly Property Password() As String
        Get
            Return mPassword
        End Get
    End Property

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        mPassword = txtPwd.Text
    End Sub

    Private Sub btncncl_Click(sender As System.Object, e As System.EventArgs) Handles btncncl.Click
        mPassword = ""
    End Sub
End Class
