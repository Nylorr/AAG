Imports System.IO
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxAcroPDF1.src = Environment.CurrentDirectory + "\Attestation " + Form1.Nom.Text + ".pdf"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName
            Label1.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class