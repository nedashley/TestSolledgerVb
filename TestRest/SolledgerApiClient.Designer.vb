<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SolledgerApiClientForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnListDatabases = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelDatabase = New System.Windows.Forms.Label()
        Me.ButtonSearchClients = New System.Windows.Forms.Button()
        Me.DataGridViewClients = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonSearchMatters = New System.Windows.Forms.Button()
        Me.DataGridViewMatters = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonCreateBranch = New System.Windows.Forms.Button()
        Me.ButtonCreateMatter = New System.Windows.Forms.Button()
        CType(Me.DataGridViewClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewMatters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "API Key:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(109, 13)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(178, 26)
        Me.txtUsername.TabIndex = 2
        '
        'txtApiKey
        '
        Me.txtApiKey.Location = New System.Drawing.Point(109, 52)
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(178, 26)
        Me.txtApiKey.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Clients:"
        '
        'btnListDatabases
        '
        Me.btnListDatabases.Location = New System.Drawing.Point(346, 13)
        Me.btnListDatabases.Name = "btnListDatabases"
        Me.btnListDatabases.Size = New System.Drawing.Size(203, 30)
        Me.btnListDatabases.TabIndex = 6
        Me.btnListDatabases.Text = "Get Current Database"
        Me.btnListDatabases.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Using Database:"
        '
        'LabelDatabase
        '
        Me.LabelDatabase.AutoSize = True
        Me.LabelDatabase.Location = New System.Drawing.Point(147, 85)
        Me.LabelDatabase.Name = "LabelDatabase"
        Me.LabelDatabase.Size = New System.Drawing.Size(0, 20)
        Me.LabelDatabase.TabIndex = 8
        '
        'ButtonSearchClients
        '
        Me.ButtonSearchClients.Enabled = False
        Me.ButtonSearchClients.Location = New System.Drawing.Point(588, 13)
        Me.ButtonSearchClients.Name = "ButtonSearchClients"
        Me.ButtonSearchClients.Size = New System.Drawing.Size(203, 33)
        Me.ButtonSearchClients.TabIndex = 9
        Me.ButtonSearchClients.Text = "Get Clients"
        Me.ButtonSearchClients.UseVisualStyleBackColor = True
        '
        'DataGridViewClients
        '
        Me.DataGridViewClients.AllowUserToAddRows = False
        Me.DataGridViewClients.AllowUserToDeleteRows = False
        Me.DataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.ClientName, Me.Address})
        Me.DataGridViewClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewClients.Location = New System.Drawing.Point(12, 156)
        Me.DataGridViewClients.Name = "DataGridViewClients"
        Me.DataGridViewClients.ReadOnly = True
        Me.DataGridViewClients.RowTemplate.Height = 28
        Me.DataGridViewClients.Size = New System.Drawing.Size(928, 167)
        Me.DataGridViewClients.TabIndex = 10
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        '
        'ClientName
        '
        Me.ClientName.HeaderText = "Name"
        Me.ClientName.Name = "ClientName"
        Me.ClientName.ReadOnly = True
        Me.ClientName.Width = 350
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 350
        '
        'ButtonSearchMatters
        '
        Me.ButtonSearchMatters.Enabled = False
        Me.ButtonSearchMatters.Location = New System.Drawing.Point(588, 52)
        Me.ButtonSearchMatters.Name = "ButtonSearchMatters"
        Me.ButtonSearchMatters.Size = New System.Drawing.Size(203, 33)
        Me.ButtonSearchMatters.TabIndex = 11
        Me.ButtonSearchMatters.Text = "Get Matters"
        Me.ButtonSearchMatters.UseVisualStyleBackColor = True
        '
        'DataGridViewMatters
        '
        Me.DataGridViewMatters.AllowUserToAddRows = False
        Me.DataGridViewMatters.AllowUserToDeleteRows = False
        Me.DataGridViewMatters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMatters.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Description})
        Me.DataGridViewMatters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewMatters.Location = New System.Drawing.Point(12, 373)
        Me.DataGridViewMatters.Name = "DataGridViewMatters"
        Me.DataGridViewMatters.ReadOnly = True
        Me.DataGridViewMatters.RowTemplate.Height = 28
        Me.DataGridViewMatters.Size = New System.Drawing.Size(928, 167)
        Me.DataGridViewMatters.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 700
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Matters:"
        '
        'ButtonCreateBranch
        '
        Me.ButtonCreateBranch.Enabled = False
        Me.ButtonCreateBranch.Location = New System.Drawing.Point(588, 91)
        Me.ButtonCreateBranch.Name = "ButtonCreateBranch"
        Me.ButtonCreateBranch.Size = New System.Drawing.Size(203, 33)
        Me.ButtonCreateBranch.TabIndex = 14
        Me.ButtonCreateBranch.Text = "Create Branch"
        Me.ButtonCreateBranch.UseVisualStyleBackColor = True
        '
        'ButtonCreateMatter
        '
        Me.ButtonCreateMatter.Enabled = False
        Me.ButtonCreateMatter.Location = New System.Drawing.Point(391, 70)
        Me.ButtonCreateMatter.Name = "ButtonCreateMatter"
        Me.ButtonCreateMatter.Size = New System.Drawing.Size(158, 35)
        Me.ButtonCreateMatter.TabIndex = 15
        Me.ButtonCreateMatter.Text = "Create Matter"
        Me.ButtonCreateMatter.UseVisualStyleBackColor = True
        '
        'SolledgerApiClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 564)
        Me.Controls.Add(Me.ButtonCreateMatter)
        Me.Controls.Add(Me.ButtonCreateBranch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridViewMatters)
        Me.Controls.Add(Me.ButtonSearchMatters)
        Me.Controls.Add(Me.DataGridViewClients)
        Me.Controls.Add(Me.ButtonSearchClients)
        Me.Controls.Add(Me.LabelDatabase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnListDatabases)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApiKey)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SolledgerApiClientForm"
        Me.Text = "Solledger Api Client"
        CType(Me.DataGridViewClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewMatters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtApiKey As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnListDatabases As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelDatabase As Label
    Friend WithEvents ButtonSearchClients As Button
    Friend WithEvents DataGridViewClients As DataGridView
    Friend WithEvents ButtonSearchMatters As Button
    Friend WithEvents DataGridViewMatters As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents ClientName As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents ButtonCreateBranch As Button
    Friend WithEvents ButtonCreateMatter As Button
End Class
