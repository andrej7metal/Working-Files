Public Class FrmLogin
   
    Dim login As String
    Dim senha As String





    Private Sub chksenha_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSenha.CheckedChanged
        If chksenha.Checked = True Then
            txtsenha.PasswordChar = ""
            txtsenha.Focus()
        Else
            txtsenha.PasswordChar = "•"
            txtsenha.Focus()
        End If
    End Sub

    Private Sub txtsenha_TextChanged(sender As Object, e As EventArgs) Handles TxtSenha.TextChanged
        If txtsenha.Text = Nothing Then
            chksenha.Enabled = False
        Else
            chksenha.Enabled = True


        End If
    End Sub

    Private Sub txtsenha_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSenha.KeyDown

        If e.KeyCode = Keys.Enter Then


            senha = txtsenha.Text
            chksenha.Enabled = True
            If txtsenha.Text = Nothing Then
                MsgBox("Digite a senha", vbExclamation, "Aviso")
                txtsenha.Clear()
                txtsenha.Focus()
                chksenha.Enabled = False

            ElseIf txtlogin.Text = login And senha = "123" Then
                MsgBox("Acesso permitido!!", vbInformation, "Usuario liberado")
                MsgBox("Iniciando Sistema Hotel", vbInformation, "Iniciando")
                Timer2.Start() 'iniciando  a o carregamento da barra
                txtlogin.Enabled = False
                TxtSenha.Enabled = False
                ChkSenha.Enabled = False
                FrmPrincipal.Show()
            Else
                MsgBox("Acesso Negado!!!", vbExclamation, "NEGADO!!")
                txtsenha.Clear()
                txtsenha.Focus()

            End If
        End If




    End Sub








    Private Sub FormLogin1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            MsgBox("Sistema de motos esta sendo encerrado", vbInformation, "Encerrando!!")
            End

        End If
    End Sub


    Private Sub txtlogin_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TxtLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            login = txtlogin.Text ' atribuição  variavel recebe  oq foi digitado
            If txtlogin.Text = Nothing Or IsNumeric(txtlogin.Text) Then ' validaçao
                MsgBox("Erro!! nao digite numeros /nao deixe vazio", vbExclamation, "AVISO!!!!!!!!!!!!")
                txtlogin.Focus() 'redirecionar cursos para login 
                txtlogin.Clear() 'limpar senha
            ElseIf login = "TCC" Then ' se o nome digitado for ... entao    
                TxtSenha.Enabled = True ' habilitar
                TxtSenha.Focus() ' redirecionar    para senha

            ElseIf login <> "TCC" Then
                MsgBox("SEM AUTORIZAÇÃO!!", vbExclamation, "aviso")
                txtlogin.Clear()
                txtlogin.Focus()
                TxtSenha.Clear()
            End If
        End If
    End Sub

    Private Sub txtlogin_TextChanged(sender As Object, e As EventArgs) Handles txtlogin.TextChanged

    End Sub
End Class