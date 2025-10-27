<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ATIVIDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VBScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoletrandoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdivinharNúmeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperadoresMatemáticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JoKenPoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PythonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutomaçãoDeLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APLICATIVOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocoDeNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GERENCIARCLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GERENCIARCONTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENCERRARPROGRAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ATIVIDADESToolStripMenuItem, Me.APLICATIVOSToolStripMenuItem, Me.GERENCIARCLIENTESToolStripMenuItem, Me.GERENCIARCONTASToolStripMenuItem, Me.ENCERRARPROGRAMAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1141, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ATIVIDADESToolStripMenuItem
        '
        Me.ATIVIDADESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VBScriptToolStripMenuItem, Me.BatchToolStripMenuItem, Me.PythonToolStripMenuItem})
        Me.ATIVIDADESToolStripMenuItem.Name = "ATIVIDADESToolStripMenuItem"
        Me.ATIVIDADESToolStripMenuItem.Size = New System.Drawing.Size(126, 29)
        Me.ATIVIDADESToolStripMenuItem.Text = "&ATIVIDADES"
        '
        'VBScriptToolStripMenuItem
        '
        Me.VBScriptToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoletrandoToolStripMenuItem})
        Me.VBScriptToolStripMenuItem.Image = CType(resources.GetObject("VBScriptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VBScriptToolStripMenuItem.Name = "VBScriptToolStripMenuItem"
        Me.VBScriptToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.VBScriptToolStripMenuItem.Text = "VBScript"
        '
        'SoletrandoToolStripMenuItem
        '
        Me.SoletrandoToolStripMenuItem.Name = "SoletrandoToolStripMenuItem"
        Me.SoletrandoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.SoletrandoToolStripMenuItem.Size = New System.Drawing.Size(257, 34)
        Me.SoletrandoToolStripMenuItem.Text = "Soletrando"
        '
        'BatchToolStripMenuItem
        '
        Me.BatchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdivinharNúmeroToolStripMenuItem, Me.OperadoresMatemáticosToolStripMenuItem, Me.JoKenPoToolStripMenuItem})
        Me.BatchToolStripMenuItem.Image = CType(resources.GetObject("BatchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BatchToolStripMenuItem.Name = "BatchToolStripMenuItem"
        Me.BatchToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.BatchToolStripMenuItem.Text = "Batch"
        '
        'AdivinharNúmeroToolStripMenuItem
        '
        Me.AdivinharNúmeroToolStripMenuItem.Name = "AdivinharNúmeroToolStripMenuItem"
        Me.AdivinharNúmeroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.AdivinharNúmeroToolStripMenuItem.Size = New System.Drawing.Size(376, 34)
        Me.AdivinharNúmeroToolStripMenuItem.Text = "Adivinhar Número"
        '
        'OperadoresMatemáticosToolStripMenuItem
        '
        Me.OperadoresMatemáticosToolStripMenuItem.Name = "OperadoresMatemáticosToolStripMenuItem"
        Me.OperadoresMatemáticosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.OperadoresMatemáticosToolStripMenuItem.Size = New System.Drawing.Size(376, 34)
        Me.OperadoresMatemáticosToolStripMenuItem.Text = "Operadores Matemáticos"
        '
        'JoKenPoToolStripMenuItem
        '
        Me.JoKenPoToolStripMenuItem.Name = "JoKenPoToolStripMenuItem"
        Me.JoKenPoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.JoKenPoToolStripMenuItem.Size = New System.Drawing.Size(376, 34)
        Me.JoKenPoToolStripMenuItem.Text = "Jo-Ken-Po"
        '
        'PythonToolStripMenuItem
        '
        Me.PythonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutomaçãoDeLoginToolStripMenuItem})
        Me.PythonToolStripMenuItem.Image = CType(resources.GetObject("PythonToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PythonToolStripMenuItem.Name = "PythonToolStripMenuItem"
        Me.PythonToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.PythonToolStripMenuItem.Text = "Python"
        '
        'AutomaçãoDeLoginToolStripMenuItem
        '
        Me.AutomaçãoDeLoginToolStripMenuItem.Name = "AutomaçãoDeLoginToolStripMenuItem"
        Me.AutomaçãoDeLoginToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D7), System.Windows.Forms.Keys)
        Me.AutomaçãoDeLoginToolStripMenuItem.Size = New System.Drawing.Size(384, 34)
        Me.AutomaçãoDeLoginToolStripMenuItem.Text = "Automação de Login"
        '
        'APLICATIVOSToolStripMenuItem
        '
        Me.APLICATIVOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.BlocoDeNotasToolStripMenuItem})
        Me.APLICATIVOSToolStripMenuItem.Name = "APLICATIVOSToolStripMenuItem"
        Me.APLICATIVOSToolStripMenuItem.Size = New System.Drawing.Size(134, 29)
        Me.APLICATIVOSToolStripMenuItem.Text = "A&PLICATIVOS"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(235, 34)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'BlocoDeNotasToolStripMenuItem
        '
        Me.BlocoDeNotasToolStripMenuItem.Name = "BlocoDeNotasToolStripMenuItem"
        Me.BlocoDeNotasToolStripMenuItem.Size = New System.Drawing.Size(235, 34)
        Me.BlocoDeNotasToolStripMenuItem.Text = "Bloco de Notas"
        '
        'GERENCIARCLIENTESToolStripMenuItem
        '
        Me.GERENCIARCLIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem})
        Me.GERENCIARCLIENTESToolStripMenuItem.Name = "GERENCIARCLIENTESToolStripMenuItem"
        Me.GERENCIARCLIENTESToolStripMenuItem.Size = New System.Drawing.Size(200, 29)
        Me.GERENCIARCLIENTESToolStripMenuItem.Text = "&GERENCIAR CLIENTES"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(247, 34)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'GERENCIARCONTASToolStripMenuItem
        '
        Me.GERENCIARCONTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeContasToolStripMenuItem})
        Me.GERENCIARCONTASToolStripMenuItem.Name = "GERENCIARCONTASToolStripMenuItem"
        Me.GERENCIARCONTASToolStripMenuItem.Size = New System.Drawing.Size(194, 29)
        Me.GERENCIARCONTASToolStripMenuItem.Text = "GERENCIAR CONTAS"
        '
        'CadastroDeContasToolStripMenuItem
        '
        Me.CadastroDeContasToolStripMenuItem.Name = "CadastroDeContasToolStripMenuItem"
        Me.CadastroDeContasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.CadastroDeContasToolStripMenuItem.Size = New System.Drawing.Size(330, 34)
        Me.CadastroDeContasToolStripMenuItem.Text = "Cadastro de Contas"
        '
        'ENCERRARPROGRAMAToolStripMenuItem
        '
        Me.ENCERRARPROGRAMAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.ENCERRARPROGRAMAToolStripMenuItem.Name = "ENCERRARPROGRAMAToolStripMenuItem"
        Me.ENCERRARPROGRAMAToolStripMenuItem.Size = New System.Drawing.Size(218, 29)
        Me.ENCERRARPROGRAMAToolStripMenuItem.Text = "&ENCERRAR PROGRAMA"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F14), System.Windows.Forms.Keys)
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 492)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ATIVIDADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BatchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdivinharNúmeroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperadoresMatemáticosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JoKenPoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VBScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoletrandoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents APLICATIVOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocoDeNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GERENCIARCLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENCERRARPROGRAMAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PythonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutomaçãoDeLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GERENCIARCONTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeContasToolStripMenuItem As ToolStripMenuItem
End Class
