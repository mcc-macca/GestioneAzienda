<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AggiungiCliente
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ragsoc = New System.Windows.Forms.GroupBox()
        Me.ragioneSociale = New System.Windows.Forms.TextBox()
        Me.datiLocalita = New System.Windows.Forms.GroupBox()
        Me.nazione = New System.Windows.Forms.TextBox()
        Me.nazioneLabel = New System.Windows.Forms.Label()
        Me.cap = New System.Windows.Forms.TextBox()
        Me.capLabel = New System.Windows.Forms.Label()
        Me.provincia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.citta = New System.Windows.Forms.TextBox()
        Me.cittaLabel = New System.Windows.Forms.Label()
        Me.indirizzo = New System.Windows.Forms.TextBox()
        Me.indirizzoLabel = New System.Windows.Forms.Label()
        Me.datiFiscali = New System.Windows.Forms.GroupBox()
        Me.siglaNazione = New System.Windows.Forms.TextBox()
        Me.siglaNazioneLabel = New System.Windows.Forms.Label()
        Me.partitaIvaEstero = New System.Windows.Forms.TextBox()
        Me.PartitaIvaesteroLabel = New System.Windows.Forms.Label()
        Me.codiceFiscale = New System.Windows.Forms.TextBox()
        Me.codicefiscaleLabel = New System.Windows.Forms.Label()
        Me.partitaIva = New System.Windows.Forms.TextBox()
        Me.partitaIvaLabel = New System.Windows.Forms.Label()
        Me.recapitiWWW = New System.Windows.Forms.GroupBox()
        Me.telefonoLabel = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.fax = New System.Windows.Forms.TextBox()
        Me.faxLabel = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.pecLabel = New System.Windows.Forms.Label()
        Me.condizioniPagamento = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.inviaDatiBtn = New System.Windows.Forms.Button()
        Me.ragsoc.SuspendLayout()
        Me.datiLocalita.SuspendLayout()
        Me.datiFiscali.SuspendLayout()
        Me.recapitiWWW.SuspendLayout()
        Me.condizioniPagamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Immettere i Dati:"
        '
        'ragsoc
        '
        Me.ragsoc.Controls.Add(Me.ragioneSociale)
        Me.ragsoc.Location = New System.Drawing.Point(29, 46)
        Me.ragsoc.Name = "ragsoc"
        Me.ragsoc.Size = New System.Drawing.Size(574, 69)
        Me.ragsoc.TabIndex = 1
        Me.ragsoc.TabStop = False
        Me.ragsoc.Text = "Ragione sociale"
        '
        'ragioneSociale
        '
        Me.ragioneSociale.Location = New System.Drawing.Point(6, 29)
        Me.ragioneSociale.Name = "ragioneSociale"
        Me.ragioneSociale.Size = New System.Drawing.Size(562, 28)
        Me.ragioneSociale.TabIndex = 0
        '
        'datiLocalita
        '
        Me.datiLocalita.Controls.Add(Me.nazione)
        Me.datiLocalita.Controls.Add(Me.nazioneLabel)
        Me.datiLocalita.Controls.Add(Me.cap)
        Me.datiLocalita.Controls.Add(Me.capLabel)
        Me.datiLocalita.Controls.Add(Me.provincia)
        Me.datiLocalita.Controls.Add(Me.Label4)
        Me.datiLocalita.Controls.Add(Me.citta)
        Me.datiLocalita.Controls.Add(Me.cittaLabel)
        Me.datiLocalita.Controls.Add(Me.indirizzo)
        Me.datiLocalita.Controls.Add(Me.indirizzoLabel)
        Me.datiLocalita.Location = New System.Drawing.Point(29, 121)
        Me.datiLocalita.Name = "datiLocalita"
        Me.datiLocalita.Size = New System.Drawing.Size(574, 236)
        Me.datiLocalita.TabIndex = 2
        Me.datiLocalita.TabStop = False
        Me.datiLocalita.Text = "Dati località"
        '
        'nazione
        '
        Me.nazione.Location = New System.Drawing.Point(158, 194)
        Me.nazione.Name = "nazione"
        Me.nazione.Size = New System.Drawing.Size(410, 28)
        Me.nazione.TabIndex = 9
        '
        'nazioneLabel
        '
        Me.nazioneLabel.AutoSize = True
        Me.nazioneLabel.Location = New System.Drawing.Point(158, 168)
        Me.nazioneLabel.Name = "nazioneLabel"
        Me.nazioneLabel.Size = New System.Drawing.Size(87, 21)
        Me.nazioneLabel.TabIndex = 8
        Me.nazioneLabel.Text = "Nazione"
        '
        'cap
        '
        Me.cap.Location = New System.Drawing.Point(8, 194)
        Me.cap.Name = "cap"
        Me.cap.Size = New System.Drawing.Size(137, 28)
        Me.cap.TabIndex = 7
        '
        'capLabel
        '
        Me.capLabel.AutoSize = True
        Me.capLabel.Location = New System.Drawing.Point(11, 167)
        Me.capLabel.Name = "capLabel"
        Me.capLabel.Size = New System.Drawing.Size(43, 21)
        Me.capLabel.TabIndex = 6
        Me.capLabel.Text = "CAP"
        '
        'provincia
        '
        Me.provincia.Location = New System.Drawing.Point(503, 121)
        Me.provincia.Name = "provincia"
        Me.provincia.Size = New System.Drawing.Size(65, 28)
        Me.provincia.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(500, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Prov."
        '
        'citta
        '
        Me.citta.Location = New System.Drawing.Point(6, 121)
        Me.citta.Name = "citta"
        Me.citta.Size = New System.Drawing.Size(491, 28)
        Me.citta.TabIndex = 3
        '
        'cittaLabel
        '
        Me.cittaLabel.AutoSize = True
        Me.cittaLabel.Location = New System.Drawing.Point(11, 97)
        Me.cittaLabel.Name = "cittaLabel"
        Me.cittaLabel.Size = New System.Drawing.Size(65, 21)
        Me.cittaLabel.TabIndex = 2
        Me.cittaLabel.Text = "Città"
        '
        'indirizzo
        '
        Me.indirizzo.Location = New System.Drawing.Point(6, 57)
        Me.indirizzo.Name = "indirizzo"
        Me.indirizzo.Size = New System.Drawing.Size(562, 28)
        Me.indirizzo.TabIndex = 1
        '
        'indirizzoLabel
        '
        Me.indirizzoLabel.AutoSize = True
        Me.indirizzoLabel.Location = New System.Drawing.Point(6, 33)
        Me.indirizzoLabel.Name = "indirizzoLabel"
        Me.indirizzoLabel.Size = New System.Drawing.Size(109, 21)
        Me.indirizzoLabel.TabIndex = 0
        Me.indirizzoLabel.Text = "Indirizzo"
        '
        'datiFiscali
        '
        Me.datiFiscali.Controls.Add(Me.siglaNazione)
        Me.datiFiscali.Controls.Add(Me.siglaNazioneLabel)
        Me.datiFiscali.Controls.Add(Me.partitaIvaEstero)
        Me.datiFiscali.Controls.Add(Me.PartitaIvaesteroLabel)
        Me.datiFiscali.Controls.Add(Me.codiceFiscale)
        Me.datiFiscali.Controls.Add(Me.codicefiscaleLabel)
        Me.datiFiscali.Controls.Add(Me.partitaIva)
        Me.datiFiscali.Controls.Add(Me.partitaIvaLabel)
        Me.datiFiscali.Location = New System.Drawing.Point(29, 363)
        Me.datiFiscali.Name = "datiFiscali"
        Me.datiFiscali.Size = New System.Drawing.Size(574, 165)
        Me.datiFiscali.TabIndex = 3
        Me.datiFiscali.TabStop = False
        Me.datiFiscali.Text = "Dati fiscali"
        '
        'siglaNazione
        '
        Me.siglaNazione.Location = New System.Drawing.Point(396, 125)
        Me.siglaNazione.Name = "siglaNazione"
        Me.siglaNazione.Size = New System.Drawing.Size(169, 28)
        Me.siglaNazione.TabIndex = 7
        '
        'siglaNazioneLabel
        '
        Me.siglaNazioneLabel.AutoSize = True
        Me.siglaNazioneLabel.Location = New System.Drawing.Point(393, 101)
        Me.siglaNazioneLabel.Name = "siglaNazioneLabel"
        Me.siglaNazioneLabel.Size = New System.Drawing.Size(153, 21)
        Me.siglaNazioneLabel.TabIndex = 6
        Me.siglaNazioneLabel.Text = "Sigla nazione"
        '
        'partitaIvaEstero
        '
        Me.partitaIvaEstero.Location = New System.Drawing.Point(11, 125)
        Me.partitaIvaEstero.Name = "partitaIvaEstero"
        Me.partitaIvaEstero.Size = New System.Drawing.Size(379, 28)
        Me.partitaIvaEstero.TabIndex = 5
        '
        'PartitaIvaesteroLabel
        '
        Me.PartitaIvaesteroLabel.AutoSize = True
        Me.PartitaIvaesteroLabel.Location = New System.Drawing.Point(11, 101)
        Me.PartitaIvaesteroLabel.Name = "PartitaIvaesteroLabel"
        Me.PartitaIvaesteroLabel.Size = New System.Drawing.Size(208, 21)
        Me.PartitaIvaesteroLabel.TabIndex = 4
        Me.PartitaIvaesteroLabel.Text = "Partita IVA estero"
        '
        'codiceFiscale
        '
        Me.codiceFiscale.Location = New System.Drawing.Point(273, 58)
        Me.codiceFiscale.Name = "codiceFiscale"
        Me.codiceFiscale.Size = New System.Drawing.Size(295, 28)
        Me.codiceFiscale.TabIndex = 3
        '
        'codicefiscaleLabel
        '
        Me.codicefiscaleLabel.AutoSize = True
        Me.codicefiscaleLabel.Location = New System.Drawing.Point(270, 31)
        Me.codicefiscaleLabel.Name = "codicefiscaleLabel"
        Me.codicefiscaleLabel.Size = New System.Drawing.Size(164, 21)
        Me.codicefiscaleLabel.TabIndex = 2
        Me.codicefiscaleLabel.Text = "Codice fiscale"
        '
        'partitaIva
        '
        Me.partitaIva.Location = New System.Drawing.Point(11, 58)
        Me.partitaIva.Name = "partitaIva"
        Me.partitaIva.Size = New System.Drawing.Size(256, 28)
        Me.partitaIva.TabIndex = 1
        '
        'partitaIvaLabel
        '
        Me.partitaIvaLabel.AutoSize = True
        Me.partitaIvaLabel.Location = New System.Drawing.Point(6, 31)
        Me.partitaIvaLabel.Name = "partitaIvaLabel"
        Me.partitaIvaLabel.Size = New System.Drawing.Size(131, 21)
        Me.partitaIvaLabel.TabIndex = 0
        Me.partitaIvaLabel.Text = "Partita IVA"
        '
        'recapitiWWW
        '
        Me.recapitiWWW.Controls.Add(Me.TextBox14)
        Me.recapitiWWW.Controls.Add(Me.pecLabel)
        Me.recapitiWWW.Controls.Add(Me.email)
        Me.recapitiWWW.Controls.Add(Me.emailLabel)
        Me.recapitiWWW.Controls.Add(Me.fax)
        Me.recapitiWWW.Controls.Add(Me.faxLabel)
        Me.recapitiWWW.Controls.Add(Me.telefono)
        Me.recapitiWWW.Controls.Add(Me.telefonoLabel)
        Me.recapitiWWW.Location = New System.Drawing.Point(620, 46)
        Me.recapitiWWW.Name = "recapitiWWW"
        Me.recapitiWWW.Size = New System.Drawing.Size(466, 311)
        Me.recapitiWWW.TabIndex = 4
        Me.recapitiWWW.TabStop = False
        Me.recapitiWWW.Text = "Recapiti WWW"
        '
        'telefonoLabel
        '
        Me.telefonoLabel.AutoSize = True
        Me.telefonoLabel.Location = New System.Drawing.Point(6, 48)
        Me.telefonoLabel.Name = "telefonoLabel"
        Me.telefonoLabel.Size = New System.Drawing.Size(98, 21)
        Me.telefonoLabel.TabIndex = 0
        Me.telefonoLabel.Text = "Telefono"
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(6, 72)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(454, 28)
        Me.telefono.TabIndex = 1
        '
        'fax
        '
        Me.fax.Location = New System.Drawing.Point(6, 132)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(454, 28)
        Me.fax.TabIndex = 3
        '
        'faxLabel
        '
        Me.faxLabel.AutoSize = True
        Me.faxLabel.Location = New System.Drawing.Point(6, 108)
        Me.faxLabel.Name = "faxLabel"
        Me.faxLabel.Size = New System.Drawing.Size(43, 21)
        Me.faxLabel.TabIndex = 2
        Me.faxLabel.Text = "FAX"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(6, 196)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(454, 28)
        Me.email.TabIndex = 5
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Location = New System.Drawing.Point(6, 172)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(65, 21)
        Me.emailLabel.TabIndex = 4
        Me.emailLabel.Text = "Email"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(6, 266)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(454, 28)
        Me.TextBox14.TabIndex = 7
        '
        'pecLabel
        '
        Me.pecLabel.AutoSize = True
        Me.pecLabel.Location = New System.Drawing.Point(6, 242)
        Me.pecLabel.Name = "pecLabel"
        Me.pecLabel.Size = New System.Drawing.Size(43, 21)
        Me.pecLabel.TabIndex = 6
        Me.pecLabel.Text = "PEC"
        '
        'condizioniPagamento
        '
        Me.condizioniPagamento.Controls.Add(Me.ComboBox1)
        Me.condizioniPagamento.Location = New System.Drawing.Point(620, 363)
        Me.condizioniPagamento.Name = "condizioniPagamento"
        Me.condizioniPagamento.Size = New System.Drawing.Size(466, 75)
        Me.condizioniPagamento.TabIndex = 5
        Me.condizioniPagamento.TabStop = False
        Me.condizioniPagamento.Text = "Condizioni di pagamento"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Versamento bancario 30gg", "Versamento bancario 90gg", "Pagamento diretto a vista", "Pagamento diretto 30gg a vista"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(454, 28)
        Me.ComboBox1.TabIndex = 0
        '
        'inviaDatiBtn
        '
        Me.inviaDatiBtn.Location = New System.Drawing.Point(487, 576)
        Me.inviaDatiBtn.Name = "inviaDatiBtn"
        Me.inviaDatiBtn.Size = New System.Drawing.Size(170, 28)
        Me.inviaDatiBtn.TabIndex = 6
        Me.inviaDatiBtn.Text = "Invia Dati"
        Me.inviaDatiBtn.UseVisualStyleBackColor = True
        '
        'AnagraficaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 653)
        Me.Controls.Add(Me.inviaDatiBtn)
        Me.Controls.Add(Me.condizioniPagamento)
        Me.Controls.Add(Me.recapitiWWW)
        Me.Controls.Add(Me.datiFiscali)
        Me.Controls.Add(Me.datiLocalita)
        Me.Controls.Add(Me.ragsoc)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Courier New", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "AnagraficaCliente"
        Me.Text = "Registrazione Anagrafica Cliente"
        Me.ragsoc.ResumeLayout(False)
        Me.ragsoc.PerformLayout()
        Me.datiLocalita.ResumeLayout(False)
        Me.datiLocalita.PerformLayout()
        Me.datiFiscali.ResumeLayout(False)
        Me.datiFiscali.PerformLayout()
        Me.recapitiWWW.ResumeLayout(False)
        Me.recapitiWWW.PerformLayout()
        Me.condizioniPagamento.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ragsoc As GroupBox
    Friend WithEvents ragioneSociale As TextBox
    Friend WithEvents datiLocalita As GroupBox
    Friend WithEvents nazione As TextBox
    Friend WithEvents nazioneLabel As Label
    Friend WithEvents cap As TextBox
    Friend WithEvents capLabel As Label
    Friend WithEvents provincia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents citta As TextBox
    Friend WithEvents cittaLabel As Label
    Friend WithEvents indirizzo As TextBox
    Friend WithEvents indirizzoLabel As Label
    Friend WithEvents datiFiscali As GroupBox
    Friend WithEvents siglaNazione As TextBox
    Friend WithEvents siglaNazioneLabel As Label
    Friend WithEvents partitaIvaEstero As TextBox
    Friend WithEvents PartitaIvaesteroLabel As Label
    Friend WithEvents codiceFiscale As TextBox
    Friend WithEvents codicefiscaleLabel As Label
    Friend WithEvents partitaIva As TextBox
    Friend WithEvents partitaIvaLabel As Label
    Friend WithEvents recapitiWWW As GroupBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents pecLabel As Label
    Friend WithEvents email As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents fax As TextBox
    Friend WithEvents faxLabel As Label
    Friend WithEvents telefono As TextBox
    Friend WithEvents telefonoLabel As Label
    Friend WithEvents condizioniPagamento As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents inviaDatiBtn As Button
End Class
