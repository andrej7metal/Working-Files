Public Class frmLogin

    Dim login As Integer

    Private Sub txtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then 'Programando o uso da tecla ENTER
            login = Val(txtSenha.Text) 'A variável recebe o que foi digitado no TextBox
            If login = 123 Then 'Se a senha for 123
                MsgBox("LIBERADO!!!", vbInformation, "BEM VINDO")
                txtSenha.Clear()
                chkSenha.Checked = False

            Else 'Se não for digitado 123 como senha
                MsgBox("INVÁLIDO!!!", vbExclamation, "Acesso Negado")
                txtSenha.Clear() 'Limpar o que foi digitado errado
                txtSenha.Focus() 'Permitir uma nova tentativa



            End If

        End If
    End Sub

    Private Sub chkSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkSenha.CheckedChanged
        If chkSenha.Checked = True Then
            txtSenha.PasswordChar = "" 'Limpa o símbolo e mostra o que foi digitado
            txtSenha.Focus()
        Else
            txtSenha.PasswordChar = "*" 'Voltando com o símbolo
            txtSenha.Focus()
        End If
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
        End If
        If MsgBox("Você apertou a tecla ESC para sair...", vbInformation + MsgBoxStyle.OkCancel, "Saída") = vbOK Then
            End

        End If


    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
