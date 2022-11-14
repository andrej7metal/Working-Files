Public Class frmAcessoGerencial
    Dim Senha As String

    Private Sub frmAcessoGerencial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(" Bem vindo ao Acesso Gerencial ", vbInformation, " Acesso Gerencial ")


    End Sub

    Private Sub txtDigiteaSenha_TextChanged(sender As Object, e As EventArgs) Handles txtDigiteaSenha.TextChanged


    End Sub

 
    Private Sub txtDigiteaSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDigiteaSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            Senha = txtDigiteaSenha.Text
            If txtDigiteaSenha.Text = Nothing Or IsNumeric(txtDigiteaSenha.Text) Then ' não permite ficar em branco e nem digitar numeros.
                MsgBox("Digite somente Letras", vbCritical, "Aviso")
                txtDigiteaSenha.Clear()
                txtDigiteaSenha.Focus()
            Else
                If Senha = " FELIPE " Or Senha = "felipe" Or Senha = "Felipe" Then ' aceita todas essas formas de digitação do nome e faz login
                    MsgBox("Acesso Permitido", vbInformation, "Liberado")
                    Me.Hide()
                    frmFormulario2.Show()
                    txtDigiteaSenha.Clear()
                Else
                    MsgBox("Acesso Negado", vbCritical, "ERRO")
                    txtDigiteaSenha.Clear()
                    txtDigiteaSenha.Focus()


                End If
            End If


        End If
    End Sub
End Class
