Public Class FrmTelaDeLogin
    Dim Login As Integer


    Private Sub TxtDigiteASenha_TextChanged(sender As Object, e As EventArgs) Handles TxtDigiteASenha.TextChanged

    End Sub

    Private Sub TxtDigiteASenha_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDigiteASenha.KeyDown
        If e.KeyCode = Keys.Enter Then ' Programando o uso da tecla ENTER
            Login = Val(TxtDigiteASenha.Text) ' o variavel recebe o que foi digitado no textbox
            If Login = 123 Then ' se a senha for 123
                MsgBox("Liberado", vbInformation, "Bem Vindo ")
                TxtDigiteASenha.Clear()
            Else ' se nao for digitado 123 como senha
                MsgBox(" INVALIDO", vbExclamation, " Acesso Negado")
                TxtDigiteASenha.Clear()
                TxtDigiteASenha.Focus() ' permitir uma nova tentativa de digitar a senha certa

            End If
        End If
    End Sub

    Private Sub ChkMostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMostrarSenha.CheckedChanged
        If ChkMostrarSenha.Checked = True Then
            TxtDigiteASenha.PasswordChar = ""
        Else
            TxtDigiteASenha.PasswordChar = "*" ' mostrar ou esconder a senha e nao mostrar 
            TxtDigiteASenha.Focus()
            ChkMostrarSenha.Checked = False
        End If
    End Sub

    Private Sub FrmTelaDeLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox(" voce apertou a tecla esc para sair ", vbInformation + MsgBoxStyle.OkCancel, "saida") = vbOK Then
                End
            End If
        End If
    End Sub
End Class
