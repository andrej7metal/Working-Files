Public Class FrmLogin
   

    
    Private Sub TxtLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            FrmPrincipal.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class