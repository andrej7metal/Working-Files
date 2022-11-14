Public Class AreaPet

    

 
    Private Sub BtnAreaPet_Click(sender As Object, e As EventArgs) Handles BtnAreaPet.Click
        Grpfotos.Visible = True
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            BackgroundImage = My.Resources.cão_e_gato_viajam_11_760x910
        End If
    End Sub
End Class