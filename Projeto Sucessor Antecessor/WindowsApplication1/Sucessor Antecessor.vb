Public Class FrmTitulo
    Dim CoresEValores As Integer 'Criando variável que só aceitará números inteiros



    Private Sub FrmTitulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(" Seja Bem Vindo ao YAAAAAH ", vbInformation, "Saudações")
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        If MsgBox(" Deseja Encerrar o programa ? ", vbQuestion+MsgBoxStyle.YesNo, "Aviso") = vbYes Then
            End
        Else

            txtNumero.Focus()
        End If
    End Sub

    Private Sub btnAntecessor_Click(sender As Object, e As EventArgs) Handles btnAntecessor.Click
        CoresEValores = Val(txtNumero.Text) 'Atribuição- a variável recebe o que foi digitado no TextBox e conversor VAL
        If IsNumeric(txtNumero.Text) Then 'Validalção - Verificando se foi digitado número
            CoresEValores = CoresEValores - 1 'Cálculo do Antecessor
            MsgBox("O Antecessor é: " & CoresEValores, vbInformation, "Resultado ")
        Else
            MsgBox("Digite Somente Números !! ")
            txtNumero.Clear()
            txtNumero.Focus()
        End If
    End Sub

    Private Sub btnSucessor_Click(sender As Object, e As EventArgs) Handles btnSucessor.Click
        CoresEValores = Val(txtNumero.Text) 'Atribuição- a variável recebe o que foi digitado no TextBox e conversor VAL
        If IsNumeric(txtNumero.Text) Then 'Validalção - Verificando se foi digitado número
            CoresEValores = CoresEValores + 1 'Cálculo do Antecessor
            MsgBox("O Sucessor é: " & CoresEValores, vbInformation, "O Resultado do Sucessor é:")
        Else
            MsgBox("Digite Somente Números", vbCritical, "AVISO")
        End If
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtNumero.Clear()
    End Sub
End Class
