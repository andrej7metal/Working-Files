Public Class FrmTelaDeLogin
    Dim SENHA As Integer





    Private Sub TxtDigiteASenha_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDigiteASenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            SENHA = Val(TxtDigiteASenha.Text)
            If SENHA = 123 Then
                MsgBox("Acesso Livre", vbInformation, "Bem Vindo")
                TxtDigiteASenha.Clear()
            Else
                MsgBox("Acesso Negado ", vbCritical, " ERRO")
                TxtDigiteASenha.Focus()
                TxtDigiteASenha.Clear()

            End If






        End If
    End Sub
End Class