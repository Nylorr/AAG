<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Raison = New System.Windows.Forms.ComboBox()
        Me.Offre = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Statut = New System.Windows.Forms.Label()
        Me.Preview = New System.Windows.Forms.LinkLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Preset = New System.Windows.Forms.ComboBox()
        Me.Barnabe = New System.Windows.Forms.TextBox()
        Me.Ilse = New System.Windows.Forms.TextBox()
        Me.Paon = New System.Windows.Forms.TextBox()
        Me.Calypso = New System.Windows.Forms.TextBox()
        Me.Beatrice = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ResetSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateRecu = New System.Windows.Forms.DateTimePicker()
        Me.DateAchat = New System.Windows.Forms.DateTimePicker()
        Me.NbCommande = New System.Windows.Forms.TextBox()
        Me.AdresseLivraison = New System.Windows.Forms.TextBox()
        Me.Articles = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.AdresseFacturation = New System.Windows.Forms.TextBox()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Générer une attestation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom :"
        '
        'Raison
        '
        Me.Raison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Raison.FormattingEnabled = True
        Me.Raison.Items.AddRange(New Object() {"Colis vide", "Locker vide"})
        Me.Raison.Location = New System.Drawing.Point(94, 520)
        Me.Raison.MaxLength = 3
        Me.Raison.Name = "Raison"
        Me.Raison.Size = New System.Drawing.Size(137, 24)
        Me.Raison.TabIndex = 10
        '
        'Offre
        '
        Me.Offre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Offre.FormattingEnabled = True
        Me.Offre.Items.AddRange(New Object() {"Oui", "Non"})
        Me.Offre.Location = New System.Drawing.Point(128, 550)
        Me.Offre.Name = "Offre"
        Me.Offre.Size = New System.Drawing.Size(103, 24)
        Me.Offre.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Adresse de facturation :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Email :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Date d'achat :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Adresse de livraison :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Articles :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 450)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Numéro de commande :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 479)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Livré le :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 523)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Problème :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 553)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Remplacement :"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(251, 548)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 33)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Imprimer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Statut
        '
        Me.Statut.AutoSize = True
        Me.Statut.Location = New System.Drawing.Point(12, 587)
        Me.Statut.Name = "Statut"
        Me.Statut.Size = New System.Drawing.Size(118, 17)
        Me.Statut.TabIndex = 25
        Me.Statut.Text = "Statut: En attente"
        '
        'Preview
        '
        Me.Preview.AutoSize = True
        Me.Preview.LinkColor = System.Drawing.Color.DimGray
        Me.Preview.Location = New System.Drawing.Point(358, 587)
        Me.Preview.Name = "Preview"
        Me.Preview.Size = New System.Drawing.Size(89, 17)
        Me.Preview.TabIndex = 27
        Me.Preview.TabStop = True
        Me.Preview.Text = "Prévisualiser"
        Me.Preview.Visible = False
        Me.Preview.VisitedLinkColor = System.Drawing.Color.DimGray
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(159, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 17)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Ou"
        '
        'Preset
        '
        Me.Preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Preset.FormattingEnabled = True
        Me.Preset.Items.AddRange(New Object() {"Amazon Hub Locker - Barnabe", "Amazon Hub Locker - Paolo", "Amazon Hub Locker - calypso", "Amazon Hub Locker - Paon", "Amazon Hub Locker - Amee", "Amazon Hub Locker - Elyne", "Amazon Hub Locker - Paul", "Amazon Hub Locker - Citron", "Amazon Hub Locker - Ilse", "Amazon Hub Locker - Anders", "Amazon Hub Locker - Myla", "Amazon Hub Locker - Beatrice"})
        Me.Preset.Location = New System.Drawing.Point(192, 418)
        Me.Preset.Name = "Preset"
        Me.Preset.Size = New System.Drawing.Size(255, 24)
        Me.Preset.TabIndex = 29
        '
        'Barnabe
        '
        Me.Barnabe.Location = New System.Drawing.Point(894, 12)
        Me.Barnabe.Multiline = True
        Me.Barnabe.Name = "Barnabe"
        Me.Barnabe.Size = New System.Drawing.Size(285, 83)
        Me.Barnabe.TabIndex = 30
        Me.Barnabe.Text = "Amazon Hub Locker - Barnabe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "234 Boulevard du Mont d'Est" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Les Arcades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "93160, Noi" &
    "sy-le-Grand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "France"
        '
        'Ilse
        '
        Me.Ilse.Location = New System.Drawing.Point(894, 279)
        Me.Ilse.Multiline = True
        Me.Ilse.Name = "Ilse"
        Me.Ilse.Size = New System.Drawing.Size(285, 83)
        Me.Ilse.TabIndex = 31
        Me.Ilse.Text = "Amazon Hub Locker - Ilse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "30 Avenue d'Italie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Centre Commercial Italie Deux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7501" &
    "3, Paris" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "France "
        '
        'Paon
        '
        Me.Paon.Location = New System.Drawing.Point(894, 190)
        Me.Paon.Multiline = True
        Me.Paon.Name = "Paon"
        Me.Paon.Size = New System.Drawing.Size(285, 83)
        Me.Paon.TabIndex = 32
        Me.Paon.Text = "Amazon Hub Locker - Paon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 Rue des Hauts Châteaux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Esso Noisy-le-Grand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "93160, N" &
    "oisy-le-Grand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "France"
        '
        'Calypso
        '
        Me.Calypso.Location = New System.Drawing.Point(894, 101)
        Me.Calypso.Multiline = True
        Me.Calypso.Name = "Calypso"
        Me.Calypso.Size = New System.Drawing.Size(285, 83)
        Me.Calypso.TabIndex = 33
        Me.Calypso.Text = "Amazon Hub Locker - calypso" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6 Boulevard Du Marechal Foch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Intermarche Noisy Le G" &
    "rand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "93160, Noisy Le Grand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "France"
        '
        'Beatrice
        '
        Me.Beatrice.Location = New System.Drawing.Point(894, 368)
        Me.Beatrice.Multiline = True
        Me.Beatrice.Name = "Beatrice"
        Me.Beatrice.Size = New System.Drawing.Size(285, 83)
        Me.Beatrice.TabIndex = 34
        Me.Beatrice.Text = "Amazon Hub Locker - Beatrice" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "14 Cours du Danube" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Centre commercial Val d'Europe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "77700, Serris" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "France"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton3, Me.ToolStripDropDownButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(461, 27)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProposToolStripMenuItem, Me.FermerToolStripMenuItem})
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(53, 24)
        Me.ToolStripDropDownButton1.Text = "AAG"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.AProposToolStripMenuItem.Text = "About AAG"
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.FermerToolStripMenuItem.Text = "Close"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ResetSaveToolStripMenuItem, Me.LoadToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(66, 24)
        Me.ToolStripDropDownButton3.Text = "Profile"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Enabled = False
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearAllToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(76, 24)
        Me.ToolStripDropDownButton2.Text = "Settings"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ClearAllToolStripMenuItem.Text = "Clear all"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AmazonPDF.My.Resources.Resources.wonder_day_among_us_21
        Me.PictureBox1.Location = New System.Drawing.Point(25, 361)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'ResetSaveToolStripMenuItem
        '
        Me.ResetSaveToolStripMenuItem.Name = "ResetSaveToolStripMenuItem"
        Me.ResetSaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ResetSaveToolStripMenuItem.Text = "Reset save"
        '
        'DateRecu
        '
        Me.DateRecu.CustomFormat = "dd/MM/yyyy"
        Me.DateRecu.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.AmazonPDF.My.MySettings.Default, "LivreSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateRecu.Location = New System.Drawing.Point(80, 479)
        Me.DateRecu.Name = "DateRecu"
        Me.DateRecu.Size = New System.Drawing.Size(367, 22)
        Me.DateRecu.TabIndex = 24
        Me.DateRecu.Value = Global.AmazonPDF.My.MySettings.Default.LivreSave
        '
        'DateAchat
        '
        Me.DateAchat.CustomFormat = "dd/MM/yyyy"
        Me.DateAchat.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.AmazonPDF.My.MySettings.Default, "DASave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateAchat.Location = New System.Drawing.Point(114, 216)
        Me.DateAchat.Name = "DateAchat"
        Me.DateAchat.Size = New System.Drawing.Size(333, 22)
        Me.DateAchat.TabIndex = 23
        Me.DateAchat.Value = Global.AmazonPDF.My.MySettings.Default.DASave
        '
        'NbCommande
        '
        Me.NbCommande.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AmazonPDF.My.MySettings.Default, "NbCommandeSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NbCommande.Location = New System.Drawing.Point(177, 450)
        Me.NbCommande.MaxLength = 19
        Me.NbCommande.Name = "NbCommande"
        Me.NbCommande.Size = New System.Drawing.Size(270, 22)
        Me.NbCommande.TabIndex = 8
        Me.NbCommande.Text = Global.AmazonPDF.My.MySettings.Default.NbCommandeSave
        '
        'AdresseLivraison
        '
        Me.AdresseLivraison.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AmazonPDF.My.MySettings.Default, "AdresseLSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AdresseLivraison.Location = New System.Drawing.Point(162, 329)
        Me.AdresseLivraison.Multiline = True
        Me.AdresseLivraison.Name = "AdresseLivraison"
        Me.AdresseLivraison.Size = New System.Drawing.Size(285, 83)
        Me.AdresseLivraison.TabIndex = 7
        Me.AdresseLivraison.Text = Global.AmazonPDF.My.MySettings.Default.AdresseLSave
        '
        'Articles
        '
        Me.Articles.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AmazonPDF.My.MySettings.Default, "ArticlesSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Articles.Location = New System.Drawing.Point(80, 244)
        Me.Articles.Multiline = True
        Me.Articles.Name = "Articles"
        Me.Articles.Size = New System.Drawing.Size(367, 79)
        Me.Articles.TabIndex = 6
        Me.Articles.Text = Global.AmazonPDF.My.MySettings.Default.ArticlesSave
        '
        'Email
        '
        Me.Email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AmazonPDF.My.MySettings.Default, "EmailSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Email.Location = New System.Drawing.Point(68, 188)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(379, 22)
        Me.Email.TabIndex = 4
        Me.Email.Text = Global.AmazonPDF.My.MySettings.Default.EmailSave
        '
        'AdresseFacturation
        '
        Me.AdresseFacturation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AmazonPDF.My.MySettings.Default, "AdresseFSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AdresseFacturation.Location = New System.Drawing.Point(177, 67)
        Me.AdresseFacturation.Multiline = True
        Me.AdresseFacturation.Name = "AdresseFacturation"
        Me.AdresseFacturation.Size = New System.Drawing.Size(270, 115)
        Me.AdresseFacturation.TabIndex = 3
        Me.AdresseFacturation.Text = Global.AmazonPDF.My.MySettings.Default.AdresseFSave
        '
        'Nom
        '
        Me.Nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AmazonPDF.My.MySettings.Default, "NomSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Nom.Location = New System.Drawing.Point(63, 36)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(384, 22)
        Me.Nom.TabIndex = 1
        Me.Nom.Text = Global.AmazonPDF.My.MySettings.Default.NomSave
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(461, 614)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Beatrice)
        Me.Controls.Add(Me.Calypso)
        Me.Controls.Add(Me.Paon)
        Me.Controls.Add(Me.Ilse)
        Me.Controls.Add(Me.Barnabe)
        Me.Controls.Add(Me.Preset)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Preview)
        Me.Controls.Add(Me.Statut)
        Me.Controls.Add(Me.DateRecu)
        Me.Controls.Add(Me.DateAchat)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Offre)
        Me.Controls.Add(Me.Raison)
        Me.Controls.Add(Me.NbCommande)
        Me.Controls.Add(Me.AdresseLivraison)
        Me.Controls.Add(Me.Articles)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.AdresseFacturation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AAG v1.1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Nom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AdresseFacturation As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Articles As TextBox
    Friend WithEvents AdresseLivraison As TextBox
    Friend WithEvents NbCommande As TextBox
    Friend WithEvents Raison As ComboBox
    Friend WithEvents Offre As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DateAchat As DateTimePicker
    Friend WithEvents DateRecu As DateTimePicker
    Friend WithEvents Statut As Label
    Friend WithEvents Preview As LinkLabel
    Friend WithEvents Label11 As Label
    Friend WithEvents Preset As ComboBox
    Friend WithEvents Barnabe As TextBox
    Friend WithEvents Ilse As TextBox
    Friend WithEvents Paon As TextBox
    Friend WithEvents Calypso As TextBox
    Friend WithEvents Beatrice As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents FermerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetSaveToolStripMenuItem As ToolStripMenuItem
End Class
