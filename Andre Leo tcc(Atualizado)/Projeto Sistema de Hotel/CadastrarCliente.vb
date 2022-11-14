Public Class FrmCadastrarCliente


    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Hide()
    End Sub

   
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVagaEstacionar.CheckedChanged
        If ChkVagaEstacionar.Checked = True Then
            LblDigitePlaca.Visible = True
            TxtPlaca.Visible = True
        Else

            LblDigitePlaca.Visible = False
            TxtPlaca.Visible = False
        End If
    End Sub

  



    Private Sub FrmCadastrarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Tb_cadastroDataSet.tb_cadastro'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_cadastroTableAdapter.Fill(Me.Tb_cadastroDataSet.tb_cadastro)
        Tb_cadastroBindingSource.AddNew()
        Me.TableAdapterManager.UpdateAll(Me.Tb_cadastroDataSet)
        txtnome.Focus()

    End Sub

   
    



     



    Private Sub TxtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ChkVagaEstacionar.Checked = True Then
                If TxtEmail.Text <> Nothing Then
                    TxtPlaca.Enabled = True
                    TxtPlaca.Focus()
                Else
                    MsgBox("Preencha o email ", vbExclamation, "Aviso")
                End If
            Else
                Tb_cadastroBindingSource.AddNew()
                Maskcell.Clear()
                MaskCPF.Clear()
                MaskRG.Clear()
                txtnome.Focus()
                txtnome.Focus()

            End If
            End If

    End Sub


    Private Sub TxtPlaca_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPlaca.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ChkVagaEstacionar.Checked = True Then
                If TxtPlaca.Text <> Nothing Then
                    Tb_cadastroBindingSource.AddNew()
                    Me.TableAdapterManager.UpdateAll(Me.Tb_cadastroDataSet)
                    Maskcell.Clear()
                    MaskCPF.Clear()
                    MaskRG.Clear()
                    txtnome.Focus()


                Else
                    MsgBox("Preecha a placa", vbExclamation, "Aviso")
                End If
            End If

        End If
    End Sub

   
   

    Private Sub txtnome_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnome.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtnome.Text <> Nothing Then
                MaskRG.Enabled = True
                MaskRG.Focus()
            Else
                MsgBox("Digite o Nome", vbExclamation, "Aviso")
                MaskRG.Focus()

            End If
        End If
    End Sub

    Private Sub MaskRG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskRG.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            If MaskRG.Text <> Nothing Then
                MaskCPF.Enabled = True
                MaskCPF.Focus()
            Else
                MsgBox("Digite o RG!", vbExclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub MaskCPF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskCPF.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            If MaskCPF.Text <> Nothing Then

                Maskcell.Enabled = True
                Maskcell.Focus()
            Else
                MsgBox("Digite o CPF", vbExclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub Maskcell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Maskcell.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            If Maskcell.Text <> Nothing Then

                TxtEmail.Enabled = True
                TxtEmail.Focus()
            Else
                MsgBox("Digite o celular", vbExclamation, "Aviso")
            End If
        End If
    End Sub

   
End Class