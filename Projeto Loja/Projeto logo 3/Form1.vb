Public Class frmLogo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click

        End
    End Sub


    


    Private Sub radMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles radMostrar.CheckedChanged
        PicLogo.Visible = True

    End Sub

    Private Sub RadNaoMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles RadNaoMostrar.CheckedChanged
        PicLogo.Visible = False


    End Sub

    Private Sub RadDesativar_CheckedChanged(sender As Object, e As EventArgs) Handles RadDesativar.CheckedChanged
        radMostrar.Enabled = False
        RadNaoMostrar.Enabled = False
        RadDesativar.Enabled = False

    End Sub

    Private Sub RadAtivar_CheckedChanged(sender As Object, e As EventArgs) Handles RadAtivar.CheckedChanged
        radMostrar.Enabled = True
        RadNaoMostrar.Enabled = True
        RadDesativar.Enabled = True
        BtnFechar.Enabled = True
    End Sub
End Class
