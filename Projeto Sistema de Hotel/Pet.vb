Public Class FrmPet

    Private Sub Pet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Hide()
        BackgroundImage = My.Resources.dog_in_shopping_cart_with_toys_850x600
        PicFoto.Visible = False
        RadFoto1.Visible = False
        RadFoto2.Visible = False
        RadFoto3.Visible = False
        RadFoto4.Visible = False
        RadFoto5.Visible = False
        RadFoto6.Visible = False
        RadFoto7.Visible = False
        radFoto8.Visible = False
        RadFoto9.Visible = False
        RadFoto10.Visible = False
        RadFoto11.Visible = False
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadFoto7.CheckedChanged
        ' PicFoto.Image = My.Resources.índice
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadFoto6.CheckedChanged
        PicFoto.Image = My.Resources.pet6
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadFoto5.CheckedChanged
        PicFoto.Image = My.Resources.pet1
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadFoto4.CheckedChanged
        PicFoto.Image = My.Resources.pet4
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadFoto3.CheckedChanged
        PicFoto.Image = My.Resources.pet3
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadFoto2.CheckedChanged
        PicFoto.Image = My.Resources.pet2
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadFoto1.CheckedChanged
        PicFoto.Image = My.Resources.petatual
    End Sub

    Private Sub BtnAreaPet_Click(sender As Object, e As EventArgs) Handles BtnAreaPet.Click
        BackgroundImage = My.Resources.petatual
        BtnGaleriaFotos.Visible = True
        GrpTipoMedicamento.Visible = False
    End Sub

    Private Sub BtnGaleriaFotos_Click(sender As Object, e As EventArgs) Handles BtnGaleriaFotos.Click
        PicFoto.Visible = True
        RadFoto1.Visible = True
        RadFoto2.Visible = True
        RadFoto3.Visible = True
        RadFoto4.Visible = True
        RadFoto5.Visible = True
        RadFoto6.Visible = True
        RadFoto7.Visible = True
        radFoto8.Visible = True
        RadFoto9.Visible = True
        RadFoto10.Visible = True
        RadFoto11.Visible = True

    End Sub

    Private Sub BtnMedicamentos_Click(sender As Object, e As EventArgs) Handles BtnMedicamentos.Click
        BtnGaleriaFotos.Visible = False
        PicFoto.Visible = False
        RadFoto1.Visible = False
        RadFoto2.Visible = False
        RadFoto3.Visible = False
        RadFoto4.Visible = False
        RadFoto5.Visible = False
        RadFoto6.Visible = False
        RadFoto7.Visible = False
        RadFoto8.Visible = False
        RadFoto9.Visible = False
        RadFoto10.Visible = False
        RadFoto11.Visible = False
        GrpTipoMedicamento.Visible = True
        BackgroundImage = My.Resources.filhoteremedio


    End Sub

    Private Sub RadComprimido_CheckedChanged(sender As Object, e As EventArgs) Handles RadComprimido.CheckedChanged
        If RadComprimido.Checked = True Then
            LinkLabel1.LinkVisited = True
            System.Diagnostics.Process.Start("https://www.petz.com.br/busca?q=comprimidos")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' LinkLabel1.LinkVisited = True
        '  System.Diagnostics.Process.Start("https://www.petz.com.br/busca?q=comprimidos")
    End Sub

    Private Sub RadLiquido_CheckedChanged(sender As Object, e As EventArgs) Handles RadLiquido.CheckedChanged
        If RadLiquido.Checked = True Then
            LinkLabel1.LinkVisited = True
            System.Diagnostics.Process.Start("https://www.petz.com.br/busca?q=petz+liquido")
        End If
    End Sub

    Private Sub RadInjetavel_CheckedChanged(sender As Object, e As EventArgs) Handles RadInjetavel.CheckedChanged
        If RadInjetavel.Checked = True Then
            LinkLabel1.LinkVisited = True
            System.Diagnostics.Process.Start("https://www.petz.com.br/busca?q=injetaveis")
        End If
    End Sub

    Private Sub RadFoto11_CheckedChanged(sender As Object, e As EventArgs) Handles RadFoto11.CheckedChanged
        PicFoto.Image = My.Resources.índice
    End Sub

    Private Sub RadFoto10_CheckedChanged(sender As Object, e As EventArgs) Handles RadFoto10.CheckedChanged
        PicFoto.Image = My.Resources.petprincipal1
    End Sub

    Private Sub RadFoto9_CheckedChanged(sender As Object, e As EventArgs) Handles RadFoto9.CheckedChanged
        PicFoto.Image = My.Resources.petprincipal2
    End Sub

    Private Sub radFoto8_CheckedChanged(sender As Object, e As EventArgs) Handles radFoto8.CheckedChanged
        PicFoto.Image = My.Resources.creches_para_cachorro_cover
    End Sub
End Class