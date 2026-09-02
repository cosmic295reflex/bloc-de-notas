<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlocNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlocNotas))
        tsPrincipal = New ToolStrip()
        tsbNuevo = New ToolStripButton()
        tsbAbrir = New ToolStripButton()
        tsbGuardar = New ToolStripButton()
        tsbNegrita = New ToolStripButton()
        tsbCursiva = New ToolStripButton()
        tsbSubrayado = New ToolStripButton()
        tscbFuente = New ToolStripComboBox()
        tscbTamaño = New ToolStripComboBox()
        mnuPrincipal = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        EdicionToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        HerramientasToolStripMenuItem = New ToolStripMenuItem()
        BuscarToolStripMenuItem = New ToolStripMenuItem()
        ContarPalabrasToolStripMenuItem = New ToolStripMenuItem()
        RichTextBox1 = New RichTextBox()
        cmsTexto = New ContextMenuStrip(components)
        CortarToolStripMenuItem = New ToolStripMenuItem()
        PegarToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        SeleccionatTodoToolStripMenuItem = New ToolStripMenuItem()
        FuentesToolStripMenuItem = New ToolStripMenuItem()
        stsInferior = New StatusStrip()
        stsEstado = New ToolStripStatusLabel()
        stsPosicion = New ToolStripStatusLabel()
        stsCaracteres = New ToolStripStatusLabel()
        stsFechaHora = New ToolStripStatusLabel()
        digAbrir = New OpenFileDialog()
        digGuardar = New SaveFileDialog()
        digFuente = New FontDialog()
        digColor = New ColorDialog()
        tmrReloj = New Timer(components)
        rtbDocumento = New RichTextBox()
        ColorDeTextoToolStripMenuItem = New ToolStripMenuItem()
        tsPrincipal.SuspendLayout()
        mnuPrincipal.SuspendLayout()
        cmsTexto.SuspendLayout()
        stsInferior.SuspendLayout()
        SuspendLayout()
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.GripStyle = ToolStripGripStyle.Hidden
        tsPrincipal.Items.AddRange(New ToolStripItem() {tsbNuevo, tsbAbrir, tsbGuardar, tsbNegrita, tsbCursiva, tsbSubrayado, tscbFuente, tscbTamaño})
        tsPrincipal.Location = New Point(0, 24)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Size = New Size(708, 25)
        tsPrincipal.TabIndex = 0
        tsPrincipal.Text = "ToolStrip1"
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), Image)
        tsbNuevo.ImageTransparentColor = Color.Magenta
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New Size(23, 22)
        tsbNuevo.Text = "ToolStripButton1"
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAbrir.Image = CType(resources.GetObject("tsbAbrir.Image"), Image)
        tsbAbrir.ImageTransparentColor = Color.Magenta
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New Size(23, 22)
        tsbAbrir.Text = "ToolStripButton2"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), Image)
        tsbGuardar.ImageTransparentColor = Color.Magenta
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New Size(23, 22)
        tsbGuardar.Text = "ToolStripButton3"
        ' 
        ' tsbNegrita
        ' 
        tsbNegrita.CheckOnClick = True
        tsbNegrita.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNegrita.Image = CType(resources.GetObject("tsbNegrita.Image"), Image)
        tsbNegrita.ImageTransparentColor = Color.Magenta
        tsbNegrita.Name = "tsbNegrita"
        tsbNegrita.Size = New Size(23, 22)
        tsbNegrita.Text = "ToolStripButton4"
        ' 
        ' tsbCursiva
        ' 
        tsbCursiva.CheckOnClick = True
        tsbCursiva.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCursiva.Image = CType(resources.GetObject("tsbCursiva.Image"), Image)
        tsbCursiva.ImageTransparentColor = Color.Magenta
        tsbCursiva.Name = "tsbCursiva"
        tsbCursiva.Size = New Size(23, 22)
        tsbCursiva.Text = "ToolStripButton5"
        ' 
        ' tsbSubrayado
        ' 
        tsbSubrayado.CheckOnClick = True
        tsbSubrayado.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbSubrayado.Image = CType(resources.GetObject("tsbSubrayado.Image"), Image)
        tsbSubrayado.ImageTransparentColor = Color.Magenta
        tsbSubrayado.Name = "tsbSubrayado"
        tsbSubrayado.Size = New Size(23, 22)
        tsbSubrayado.Text = "ToolStripButton6"
        ' 
        ' tscbFuente
        ' 
        tscbFuente.Name = "tscbFuente"
        tscbFuente.Size = New Size(121, 25)
        tscbFuente.Text = "Fuente"
        ' 
        ' tscbTamaño
        ' 
        tscbTamaño.Name = "tscbTamaño"
        tscbTamaño.Size = New Size(121, 25)
        tscbTamaño.Text = "Tamaño"
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, FormatoToolStripMenuItem, EdicionToolStripMenuItem, AyudaToolStripMenuItem, HerramientasToolStripMenuItem})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Size = New Size(708, 24)
        mnuPrincipal.TabIndex = 1
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(60, 20)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ColorDeTextoToolStripMenuItem})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(64, 20)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' EdicionToolStripMenuItem
        ' 
        EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        EdicionToolStripMenuItem.Size = New Size(58, 20)
        EdicionToolStripMenuItem.Text = "Edicion"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(53, 20)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' HerramientasToolStripMenuItem
        ' 
        HerramientasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BuscarToolStripMenuItem, ContarPalabrasToolStripMenuItem})
        HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        HerramientasToolStripMenuItem.Size = New Size(90, 20)
        HerramientasToolStripMenuItem.Text = "Herramientas"
        ' 
        ' BuscarToolStripMenuItem
        ' 
        BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        BuscarToolStripMenuItem.Size = New Size(157, 22)
        BuscarToolStripMenuItem.Text = "Buscar"
        ' 
        ' ContarPalabrasToolStripMenuItem
        ' 
        ContarPalabrasToolStripMenuItem.Name = "ContarPalabrasToolStripMenuItem"
        ContarPalabrasToolStripMenuItem.Size = New Size(157, 22)
        ContarPalabrasToolStripMenuItem.Text = "Contar Palabras"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(0, 49)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(708, 569)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = "escribe aqui el contenido de tu nota"
        ' 
        ' cmsTexto
        ' 
        cmsTexto.Items.AddRange(New ToolStripItem() {CortarToolStripMenuItem, PegarToolStripMenuItem, CopiarToolStripMenuItem, SeleccionatTodoToolStripMenuItem, FuentesToolStripMenuItem})
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(162, 114)
        ' 
        ' CortarToolStripMenuItem
        ' 
        CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        CortarToolStripMenuItem.Size = New Size(161, 22)
        CortarToolStripMenuItem.Text = "cortar"
        ' 
        ' PegarToolStripMenuItem
        ' 
        PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        PegarToolStripMenuItem.Size = New Size(161, 22)
        PegarToolStripMenuItem.Text = "pegar"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(161, 22)
        CopiarToolStripMenuItem.Text = "copiar"
        ' 
        ' SeleccionatTodoToolStripMenuItem
        ' 
        SeleccionatTodoToolStripMenuItem.Name = "SeleccionatTodoToolStripMenuItem"
        SeleccionatTodoToolStripMenuItem.Size = New Size(161, 22)
        SeleccionatTodoToolStripMenuItem.Text = "seleccionat todo"
        ' 
        ' FuentesToolStripMenuItem
        ' 
        FuentesToolStripMenuItem.Name = "FuentesToolStripMenuItem"
        FuentesToolStripMenuItem.Size = New Size(161, 22)
        FuentesToolStripMenuItem.Text = "fuentes"
        ' 
        ' stsInferior
        ' 
        stsInferior.Items.AddRange(New ToolStripItem() {stsEstado, stsPosicion, stsCaracteres, stsFechaHora})
        stsInferior.Location = New Point(0, 596)
        stsInferior.Name = "stsInferior"
        stsInferior.Size = New Size(708, 22)
        stsInferior.TabIndex = 4
        stsInferior.Text = "StatusStrip1"
        ' 
        ' stsEstado
        ' 
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(333, 17)
        stsEstado.Spring = True
        stsEstado.Text = "ToolStripStatusLabel1"
        ' 
        ' stsPosicion
        ' 
        stsPosicion.Name = "stsPosicion"
        stsPosicion.Size = New Size(120, 17)
        stsPosicion.Text = "ToolStripStatusLabel2"
        ' 
        ' stsCaracteres
        ' 
        stsCaracteres.Name = "stsCaracteres"
        stsCaracteres.Size = New Size(120, 17)
        stsCaracteres.Text = "ToolStripStatusLabel3"
        ' 
        ' stsFechaHora
        ' 
        stsFechaHora.Name = "stsFechaHora"
        stsFechaHora.Size = New Size(120, 17)
        stsFechaHora.Text = "ToolStripStatusLabel4"
        ' 
        ' digAbrir
        ' 
        digAbrir.FileName = "OpenFileDialog1"
        digAbrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        ' 
        ' digGuardar
        ' 
        digGuardar.DefaultExt = """txt"""
        ' 
        ' digFuente
        ' 
        digFuente.ShowColor = True
        ' 
        ' digColor
        ' 
        digColor.FullOpen = True
        ' 
        ' tmrReloj
        ' 
        tmrReloj.Enabled = True
        tmrReloj.Interval = 1000
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.ContextMenuStrip = cmsTexto
        rtbDocumento.Dock = DockStyle.Fill
        rtbDocumento.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbDocumento.Location = New Point(0, 49)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(708, 547)
        rtbDocumento.TabIndex = 5
        rtbDocumento.Text = ""
        ' 
        ' ColorDeTextoToolStripMenuItem
        ' 
        ColorDeTextoToolStripMenuItem.Name = "ColorDeTextoToolStripMenuItem"
        ColorDeTextoToolStripMenuItem.Size = New Size(180, 22)
        ColorDeTextoToolStripMenuItem.Text = "Color de texto"
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(708, 618)
        Controls.Add(rtbDocumento)
        Controls.Add(stsInferior)
        Controls.Add(RichTextBox1)
        Controls.Add(tsPrincipal)
        Controls.Add(mnuPrincipal)
        MainMenuStrip = mnuPrincipal
        MinimumSize = New Size(600, 400)
        Name = "frmBlocNotas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bloc de Notas VB.NET"
        tsPrincipal.ResumeLayout(False)
        tsPrincipal.PerformLayout()
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        cmsTexto.ResumeLayout(False)
        stsInferior.ResumeLayout(False)
        stsInferior.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tsPrincipal As ToolStrip
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents cmsTexto As ContextMenuStrip
    Friend WithEvents stsInferior As StatusStrip
    Friend WithEvents digAbrir As OpenFileDialog
    Friend WithEvents digGuardar As SaveFileDialog
    Friend WithEvents digFuente As FontDialog
    Friend WithEvents digColor As ColorDialog
    Friend WithEvents tmrReloj As Timer
    Friend WithEvents rtbDocumento As RichTextBox
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionatTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbAbrir As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbNegrita As ToolStripButton
    Friend WithEvents tsbCursiva As ToolStripButton
    Friend WithEvents tsbSubrayado As ToolStripButton
    Friend WithEvents stsEstado As ToolStripStatusLabel
    Friend WithEvents stsPosicion As ToolStripStatusLabel
    Friend WithEvents stsCaracteres As ToolStripStatusLabel
    Friend WithEvents stsFechaHora As ToolStripStatusLabel
    Friend WithEvents tscbFuente As ToolStripComboBox
    Friend WithEvents tscbTamaño As ToolStripComboBox
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContarPalabrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDeTextoToolStripMenuItem As ToolStripMenuItem

End Class
