Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Drawing.Printing


Public Class Form1

    Private Sub Nom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nom.KeyPress

        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If

    End Sub

    Private Sub NbCommande_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NbCommande.KeyPress

        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pdfDoc As New Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("Attestation " + Nom.Text + ".pdf", FileMode.Create))
        pdfDoc.Open()
        pdfDoc.Add(New Paragraph("Je m'appelle " + Nom.Text + " et je réside à l'adresse suivante : "))
        pdfDoc.Add(New Paragraph(AdresseFacturation.Text))
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("Mon adresse e-mail est : " + Email.Text))
        pdfDoc.Add(New Paragraph("Le " + DateAchat.Value + ", j'ai passé une commande sur Amazon.fr concernant le ou les articles suivants :"))
        pdfDoc.Add(New Paragraph(Articles.Text))
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("Dans le cadre de cet achat, j'ai demandé que la commande soit livrée à l'adresse suivante :"))
        If AdresseLivraison.Text = "" Then
            If Preset.Text = "Amazon Hub Locker - Barnabe" Then
                AdresseLivraison.Text = Barnabe.Text
                pdfDoc.Add(New Paragraph(Barnabe.Text))
            End If
            If Preset.Text = "Amazon Hub Locker - calypso" Then
                AdresseLivraison.Text = Calypso.Text
                pdfDoc.Add(New Paragraph(Calypso.Text))
            End If
            If Preset.Text = "Amazon Hub Locker - Paon" Then
                AdresseLivraison.Text = Paon.Text
                pdfDoc.Add(New Paragraph(Paon.Text))
            End If
            If Preset.Text = "Amazon Hub Locker - Ilse" Then
                AdresseLivraison.Text = Ilse.Text
                pdfDoc.Add(New Paragraph(Ilse.Text))
            End If
            If Preset.Text = "Amazon Hub Locker - Beatrice" Then
                AdresseLivraison.Text = Ilse.Text
                pdfDoc.Add(New Paragraph(Beatrice.Text))
            End If
            If Preset.Text = "Amazon Hub Locker - (Sélectionnez)" Then
                MsgBox("Sélectionnez une adresse de livraison.", MsgBoxStyle.Exclamation)
            End If
        Else
            pdfDoc.Add(New Paragraph(AdresseLivraison.Text))
        End If
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("Le numéro de commande Amazon de cette commande était " + NbCommande.Text + "."))
        If Raison.Text = "Colis vide" Then
            pdfDoc.Add(New Paragraph("Cette commande m'a été livrée le " + DateRecu.Value + ". Cependant, à la place des articles que j'ai commandés, j’ai reçu une boîte vide."))
        ElseIf Raison.Text = "Locker vide" Then
            pdfDoc.Add(New Paragraph("Cette commande m'a été livrée le " + DateRecu.Value + ". Cependant, lorsque j'ai vérifié le casier, j'ai découvert que le colis ne s'y trouvait pas."))
        Else
            MsgBox("Veuillez sélectionner une raison valide.", MsgBoxStyle.Exclamation)
        End If
        pdfDoc.Add(New Paragraph(" "))
        If Offre.Text = "Oui" Then
            pdfDoc.Add(New Paragraph("Veuillez me faire parvenir un remplacement : Oui"))
            pdfDoc.Add(New Paragraph("Veuillez me faire parvenir un remboursement : Non"))
        ElseIf Offre.Text = "Non" Then
            pdfDoc.Add(New Paragraph("Veuillez me faire parvenir un remplacement : Non"))
            pdfDoc.Add(New Paragraph("Veuillez me faire parvenir un remboursement : Oui"))
        Else
            MsgBox("Veuillez sélectionner si vous souhaitez un remplacement ou non.", MsgBoxStyle.Exclamation)
        End If
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("Déclaration de vérité : Je reconnais et confirme sur l’honneur par la présente que cette déclaration (composée d'une page signée par moi-même) est exacte et sincère, et je la remplis en sachant qu'elle peut être utilisée comme preuve, dont le contenu sera consulté, et que je pourrais être passible de poursuites si j'ai volontairement déclaré des éléments que je sais être faux ou que je ne crois pas être vrais."))
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("Date : " + Date.Now.ToString("dd/MM/yyyy")))
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("Signature :"))
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph(Nom.Text))
        pdfDoc.Close()
        Statut.Text = "Statut: Attestation générée."
        Preview.Visible = True
        Button2.Enabled = True
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("I am not the impostor.", MsgBoxStyle.Information)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Preview.LinkClicked
        Form2.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(Environment.CurrentDirectory + "\Attestation " + Nom.Text + ".pdf")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Preset.Items.Count > 0 Then
            Preset.SelectedIndex = 0
        End If
        If Raison.Items.Count > 0 Then
            Raison.SelectedIndex = 0
        End If
        If Offre.Items.Count > 0 Then
            Offre.SelectedIndex = 0
        End If

    End Sub

    Private Sub FermerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Nom.Text = ""
        AdresseFacturation.Text = ""
        Email.Text = ""
        Articles.Text = ""
        AdresseLivraison.Text = ""
        AdresseFacturation.Text = ""
        NbCommande.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        My.Settings.Save()
    End Sub

    Private Sub ResetSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSaveToolStripMenuItem.Click
        My.Settings.Reset()
    End Sub
End Class