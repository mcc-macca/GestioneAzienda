<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApriNuovaIstanzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabLauncher = New System.Windows.Forms.TabControl()
        Me.tabAzienda = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tabRegistrazioni = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tabPianoConti = New System.Windows.Forms.TabPage()
        Me.tabIva = New System.Windows.Forms.TabPage()
        Me.tabScadenzari = New System.Windows.Forms.TabPage()
        Me.tabFornitori = New System.Windows.Forms.TabPage()
        Me.tabCassa = New System.Windows.Forms.TabPage()
        Me.tabDocumenti = New System.Windows.Forms.TabPage()
        Me.tabVarie = New System.Windows.Forms.TabPage()
        Me.MenuStrip1.SuspendLayout()
        Me.tabLauncher.SuspendLayout()
        Me.tabAzienda.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1112, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApriNuovaIstanzaToolStripMenuItem, Me.ToolStripMenuItem2, Me.EsciToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ApriNuovaIstanzaToolStripMenuItem
        '
        Me.ApriNuovaIstanzaToolStripMenuItem.Name = "ApriNuovaIstanzaToolStripMenuItem"
        Me.ApriNuovaIstanzaToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.ApriNuovaIstanzaToolStripMenuItem.Text = "Apri nuova istanza"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(214, 26)
        Me.ToolStripMenuItem2.Text = "------"
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.EsciToolStripMenuItem.Text = "&Esci"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(30, 24)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'tabLauncher
        '
        Me.tabLauncher.Controls.Add(Me.tabAzienda)
        Me.tabLauncher.Controls.Add(Me.tabRegistrazioni)
        Me.tabLauncher.Controls.Add(Me.TabPage3)
        Me.tabLauncher.Controls.Add(Me.tabPianoConti)
        Me.tabLauncher.Controls.Add(Me.tabIva)
        Me.tabLauncher.Controls.Add(Me.tabScadenzari)
        Me.tabLauncher.Controls.Add(Me.tabFornitori)
        Me.tabLauncher.Controls.Add(Me.tabCassa)
        Me.tabLauncher.Controls.Add(Me.tabDocumenti)
        Me.tabLauncher.Controls.Add(Me.tabVarie)
        Me.tabLauncher.Location = New System.Drawing.Point(12, 31)
        Me.tabLauncher.Name = "tabLauncher"
        Me.tabLauncher.SelectedIndex = 0
        Me.tabLauncher.Size = New System.Drawing.Size(1088, 614)
        Me.tabLauncher.TabIndex = 1
        '
        'tabAzienda
        '
        Me.tabAzienda.Controls.Add(Me.GroupBox1)
        Me.tabAzienda.Controls.Add(Me.Button3)
        Me.tabAzienda.Controls.Add(Me.Button2)
        Me.tabAzienda.Controls.Add(Me.Button1)
        Me.tabAzienda.Location = New System.Drawing.Point(4, 29)
        Me.tabAzienda.Name = "tabAzienda"
        Me.tabAzienda.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAzienda.Size = New System.Drawing.Size(1080, 581)
        Me.tabAzienda.TabIndex = 0
        Me.tabAzienda.Text = "Azienda"
        Me.tabAzienda.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1068, 474)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Attuali dati aziendali"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(543, 486)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(531, 44)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Nuova Azienda"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(543, 536)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(531, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Modifica dati aziendali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(6, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(531, 89)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SCELTA AZIENDA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tabRegistrazioni
        '
        Me.tabRegistrazioni.Location = New System.Drawing.Point(4, 29)
        Me.tabRegistrazioni.Name = "tabRegistrazioni"
        Me.tabRegistrazioni.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRegistrazioni.Size = New System.Drawing.Size(1080, 581)
        Me.tabRegistrazioni.TabIndex = 1
        Me.tabRegistrazioni.Text = "Registrazioni"
        Me.tabRegistrazioni.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1080, 581)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Contabilità"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'tabPianoConti
        '
        Me.tabPianoConti.Location = New System.Drawing.Point(4, 29)
        Me.tabPianoConti.Name = "tabPianoConti"
        Me.tabPianoConti.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPianoConti.Size = New System.Drawing.Size(1080, 581)
        Me.tabPianoConti.TabIndex = 3
        Me.tabPianoConti.Text = "Piano conti"
        Me.tabPianoConti.UseVisualStyleBackColor = True
        '
        'tabIva
        '
        Me.tabIva.Location = New System.Drawing.Point(4, 29)
        Me.tabIva.Name = "tabIva"
        Me.tabIva.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIva.Size = New System.Drawing.Size(1080, 581)
        Me.tabIva.TabIndex = 4
        Me.tabIva.Text = "IVA"
        Me.tabIva.UseVisualStyleBackColor = True
        '
        'tabScadenzari
        '
        Me.tabScadenzari.Location = New System.Drawing.Point(4, 29)
        Me.tabScadenzari.Name = "tabScadenzari"
        Me.tabScadenzari.Padding = New System.Windows.Forms.Padding(3)
        Me.tabScadenzari.Size = New System.Drawing.Size(1080, 581)
        Me.tabScadenzari.TabIndex = 5
        Me.tabScadenzari.Text = "Scandenzari"
        Me.tabScadenzari.UseVisualStyleBackColor = True
        '
        'tabFornitori
        '
        Me.tabFornitori.Location = New System.Drawing.Point(4, 29)
        Me.tabFornitori.Name = "tabFornitori"
        Me.tabFornitori.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFornitori.Size = New System.Drawing.Size(1080, 581)
        Me.tabFornitori.TabIndex = 6
        Me.tabFornitori.Text = "Fornitori"
        Me.tabFornitori.UseVisualStyleBackColor = True
        '
        'tabCassa
        '
        Me.tabCassa.Location = New System.Drawing.Point(4, 29)
        Me.tabCassa.Name = "tabCassa"
        Me.tabCassa.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCassa.Size = New System.Drawing.Size(1080, 581)
        Me.tabCassa.TabIndex = 7
        Me.tabCassa.Text = "Cassa e C/C"
        Me.tabCassa.UseVisualStyleBackColor = True
        '
        'tabDocumenti
        '
        Me.tabDocumenti.Location = New System.Drawing.Point(4, 29)
        Me.tabDocumenti.Name = "tabDocumenti"
        Me.tabDocumenti.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDocumenti.Size = New System.Drawing.Size(1080, 581)
        Me.tabDocumenti.TabIndex = 8
        Me.tabDocumenti.Text = "Documenti"
        Me.tabDocumenti.UseVisualStyleBackColor = True
        '
        'tabVarie
        '
        Me.tabVarie.Location = New System.Drawing.Point(4, 29)
        Me.tabVarie.Name = "tabVarie"
        Me.tabVarie.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVarie.Size = New System.Drawing.Size(1080, 581)
        Me.tabVarie.TabIndex = 9
        Me.tabVarie.Text = "Varie"
        Me.tabVarie.UseVisualStyleBackColor = True
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 657)
        Me.Controls.Add(Me.tabLauncher)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Launcher"
        Me.Text = "Launcher - Gestione Aziende"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabLauncher.ResumeLayout(False)
        Me.tabAzienda.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApriNuovaIstanzaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EsciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tabLauncher As TabControl
    Friend WithEvents tabAzienda As TabPage
    Friend WithEvents tabRegistrazioni As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents tabPianoConti As TabPage
    Friend WithEvents tabIva As TabPage
    Friend WithEvents tabScadenzari As TabPage
    Friend WithEvents tabFornitori As TabPage
    Friend WithEvents tabCassa As TabPage
    Friend WithEvents tabDocumenti As TabPage
    Friend WithEvents tabVarie As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
End Class
