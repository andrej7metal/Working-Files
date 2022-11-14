Public Class frmTelaLogin

    Dim NOME, SENHA As String
    Dim CONTADOR As Integer = 1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblHora.Text = TimeString
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            NOME = txtUsuario.Text
            If txtUsuario.Text = Nothing Or IsNumeric(txtUsuario.Text) Then
                MsgBox("Digite apenas letras!!!", vbExclamation, "Aviso")
                txtUsuario.Clear()
                txtUsuario.Focus()
            ElseIf NOME = "ADMIN" Then
                ChkVerSenha.Enabled = True
                TxtSenha.Enabled = True
                TxtSenha.Focus()
            End If
          End If
    End Sub

    Private Sub frmTelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            SENHA = TxtSenha.Text
            ChkVerSenha.Enabled = True
            If SENHA = Nothing Then ' se nao foi digitada a senha
                MsgBox("Digite a senha", vbExclamation, "Aviso")
                TxtSenha.Clear()
                TxtSenha.Focus()
            ElseIf NOME = "ADMIN" And SENHA = "123" Then
                MsgBox("ACESSO PERMITIDO", vbInformation, "LOGIN")
                MsgBox("ESTA INICIANDO A ABERTURA DO SISTEMA DE BODE ", vbInformation, "1 ANO LUZ PARA INICIAR")
                fRMMENU2.Show()

                txtUsuario.Enabled = False
                TxtSenha.Enabled = False

            Else
                MsgBox("ACESSO NEGADO", vbExclamation, "AVISO")
                TxtSenha.Clear()
                TxtSenha.Focus()
                CONTADOR = CONTADOR + 1 ' contador de tentativas
            End If
            If CONTADOR > 3 Then ' limite de tentativas
                MsgBox("TENTATIVAS ESGOTADAS", vbInformation, "tela de login")
                End
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Start() ' iniciar o carregamento  da ProgressBar.
        ProgressBar1.Increment(2) ' carrehgar de 2 em 2
        If ProgressBar1.Value = 100 Then ' se atingir 100%
            Me.Hide() ' ocultar tela de login
            fRMMENU2.Show() 'abrir tela de menu
            Timer2.Stop() 'parar o timer
        End If
        LblIniciar.Text = "Carregando..."
        LblPorcentagem.Text = ProgressBar1.Value & "&"
    End Sub

    Private Sub ChkVerSenha_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVerSenha.CheckedChanged
        If ChkVerSenha.Checked = True Then
            TxtSenha.PasswordChar = "" 'Mostra o que foi digitado
        Else
            TxtSenha.PasswordChar = "*" ' Volta o simbolo

        End If
        TxtSenha.Focus()
    End Sub

    Private Sub TxtSenha_TextChanged(sender As Object, e As EventArgs) Handles TxtSenha.TextChanged
        If TxtSenha.Text = Nothing Then ' se nao foi digitado nada 
            ChkVerSenha.Enabled = False 'Nao Habilitar
        Else
            ChkVerSenha.Enabled = True

        End If
    End Sub

    Private Sub frmTelaLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            MsgBox("Sistemas de motos esta sendo Encerrado""", vbInformation, "Tela De Login")
            End
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class