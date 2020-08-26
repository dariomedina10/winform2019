Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("hola, aqui estamos")
        MessageBox.Show("Error: ", "Formulario de Entrada", MessageBoxButtons.OK)

        MessageBox.Show("botonOk cancel: ", "Formulario de Entrada", MessageBoxButtons.OKCancel)

        ' MessageBox.Show("Si/np: ", "Formulario de Entrada", MessageBoxButtons.YesNo)
        Dim opcion As String
        Dim opcion2 As String
        Dim opcion3 As String


        opcion = MessageBox.Show("Realmente desea Salir",
                                 "Salir del Programa",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

        ' DialogResult.No

        If (opcion = DialogResult.Yes) Then
            MessageBox.Show("Nos Fuimos")
            Me.Close()
        End If
        '
        opcion2 = MessageBox.Show("Realmente desea Salir",
                                 "Salir del Programa",
                                 MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Warning)
        ''
        If (opcion2 = DialogResult.OK) Then

            MessageBox.Show("Nos Fuimos")
        End If
    End Sub
End Class
