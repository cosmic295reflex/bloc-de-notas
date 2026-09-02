Imports System.IO
Imports System.Drawing

Public Class frmBlocNotas
    Private rutaActual As String = String.Empty
    Private documentoModificado As Boolean = False

    ' Actualiza la información mostrada en la barra de estado
    Private Sub ActualizarBarraEstado()
        Try
            ' Caracteres
            stsCaracteres.Text = String.Format("Caracteres: {0}", rtbDocumento.TextLength)

            ' Posición (línea y columna)
            Dim linea As Integer = rtbDocumento.GetLineFromCharIndex(rtbDocumento.SelectionStart) + 1
            Dim columna As Integer = rtbDocumento.SelectionStart - rtbDocumento.GetFirstCharIndexOfCurrentLine() + 1
            stsPosicion.Text = String.Format("Ln {0}, Col {1}", linea, columna)

            ' Fecha y hora (actual)
            stsFechaHora.Text = DateTime.Now.ToString("g")

            ' Estado genérico
            If documentoModificado Then
                stsEstado.Text = "Modificado"
            Else
                stsEstado.Text = "Listo"
            End If
        Catch ex As Exception
            ' Evitar romper la aplicación si la barra de estado aún no está inicializada
        End Try
    End Sub

    Private Sub frmBlocNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial del RichTextBox
        rtbDocumento.Font = New Font("Consolas", 11)
        rtbDocumento.WordWrap = True
        ' mnuAjusteLinea no existe en el diseñador actual; evitar acceso directo

        ' Llenar combos del ToolStrip
        tscbFuente.Items.AddRange(New String() {"Segoe UI", "Consolas", "Arial", "Times New Roman"})
        tscbFuente.SelectedIndex = 1
        tscbTamaño.Items.AddRange(New String() {"8", "10", "11", "12", "14", "18", "24"})
        tscbTamaño.SelectedIndex = 2

        ' Añadir entrada dinámica "Acerca de..." al menú Ayuda si existe

        ActualizarBarraEstado()
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
    End Sub

    Private Sub rtbDocumento_TextChanged(sender As Object, e As EventArgs) Handles rtbDocumento.TextChanged
        documentoModificado = True
        ActualizarBarraEstado()
    End Sub

    Private Sub rtbDocumento_SelectionChanged(sender As Object, e As EventArgs) Handles rtbDocumento.SelectionChanged
        ActualizarBarraEstado()
    End Sub

    ' Operaciones básicas: Nuevo, Abrir y Guardar

    Private Sub NuevoDocumento()
        If documentoModificado Then
            ' Si hay cambios, simplemente reiniciamos (el diálogo de guardado puede añadirse después)
        End If

        rutaActual = String.Empty
        rtbDocumento.Clear()
        documentoModificado = False
        ActualizarBarraEstado()
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
    End Sub

    Private Sub AbrirDocumento()
        Try
            Using ofd As New OpenFileDialog()
                ofd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
                ofd.Title = "Abrir documento"
                If ofd.ShowDialog() = DialogResult.OK Then
                    rtbDocumento.Text = File.ReadAllText(ofd.FileName)
                    rutaActual = ofd.FileName
                    documentoModificado = False
                    ActualizarBarraEstado()
                    Me.Text = String.Format("Bloc de Notas VB.NET - [{0}]", Path.GetFileName(rutaActual))
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al abrir el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GuardarDocumento(guardarComo As Boolean)
        Try
            If String.IsNullOrEmpty(rutaActual) OrElse guardarComo Then
                Using sfd As New SaveFileDialog()
                    sfd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
                    sfd.Title = "Guardar documento"
                    If sfd.ShowDialog() = DialogResult.OK Then
                        File.WriteAllText(sfd.FileName, rtbDocumento.Text)
                        rutaActual = sfd.FileName
                        documentoModificado = False
                        ActualizarBarraEstado()
                        Me.Text = String.Format("Bloc de Notas VB.NET - [{0}]", Path.GetFileName(rutaActual))
                    End If
                End Using
            Else
                File.WriteAllText(rutaActual, rtbDocumento.Text)
                documentoModificado = False
                ActualizarBarraEstado()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al guardar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub mnuNuevo_Click(sender As Object, e As EventArgs)
        NuevoDocumento()
    End Sub

    Private Sub mnuAbrir_Click(sender As Object, e As EventArgs)
        AbrirDocumento()
    End Sub

    Private Sub mnuGuardar_Click(sender As Object, e As EventArgs)
        GuardarDocumento(False)
    End Sub

    Private Sub mnuGuardarComo_Click(sender As Object, e As EventArgs)
        GuardarDocumento(True)
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    ' Deshacer / Rehacer: los elementos de menú no estaban presentes en el diseñador,
    ' por lo que estos manejadores se omiten para evitar errores de compilación.

    Private Sub mnuCortar_Click(sender As Object, e As EventArgs)
        rtbDocumento.Cut()
    End Sub

    Private Sub mnuCopiar_Click(sender As Object, e As EventArgs)
        rtbDocumento.Copy()
    End Sub

    Private Sub mnuDeshacer_Click(sender As Object, e As EventArgs)
        If rtbDocumento.CanUndo Then
            rtbDocumento.Undo()
            documentoModificado = True
            ActualizarBarraEstado()
        End If
    End Sub

    Private Sub mnuRehacer_Click(sender As Object, e As EventArgs)
        If rtbDocumento.CanRedo Then
            rtbDocumento.Redo()
            documentoModificado = True
            ActualizarBarraEstado()
        End If
    End Sub

    Private Sub mnuPegar_Click(sender As Object, e As EventArgs)
        rtbDocumento.Paste()
    End Sub

    Private Sub mnuSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles SeleccionatTodoToolStripMenuItem.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub mnuFuente_Click(sender As Object, e As EventArgs) Handles FuentesToolStripMenuItem.Click
        ' Usar el diálogo de fuentes definido en el diseñador (digFuente)
        digFuente.Font = rtbDocumento.SelectionFont
        If digFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = digFuente.Font
        End If
    End Sub

    ' El elemento de menú para cambiar el color de texto no existe en el diseñador;
    ' si se necesita, añadir el control correspondiente y asignar un manejador.

    Private Sub mnuAjusteLinea_Click(sender As Object, e As EventArgs)
        ' mnuAjusteLinea no existe en el diseñador actual; alternar ajuste de línea manualmente
        rtbDocumento.WordWrap = Not rtbDocumento.WordWrap
    End Sub

    Private Sub mnuZoomMas_Click(sender As Object, e As EventArgs)
        If rtbDocumento.ZoomFactor < 4.0F Then rtbDocumento.ZoomFactor += 0.1F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuZoomMenos_Click(sender As Object, e As EventArgs)
        If rtbDocumento.ZoomFactor > 0.3F Then rtbDocumento.ZoomFactor -= 0.1F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuZoomRestablecer_Click(sender As Object, e As EventArgs)
        rtbDocumento.ZoomFactor = 1.0F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Bloc de Notas VB.NET" & vbCrLf & "Ejemplo académico - MenuStrip/ToolStrip/StatusStrip",
                         "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub tsbAbrir_Click(sender As Object, e As EventArgs) Handles tsbAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        GuardarDocumento(False)
    End Sub



    Private Sub tsbNegrita_Click(sender As Object, e As EventArgs) Handles tsbNegrita.Click
        AplicarEstiloFuente(FontStyle.Bold)
    End Sub

    Private Sub tsbCursiva_Click(sender As Object, e As EventArgs) Handles tsbCursiva.Click
        AplicarEstiloFuente(FontStyle.Italic)
    End Sub

    Private Sub tsbSubrayado_Click(sender As Object, e As EventArgs) Handles tsbSubrayado.Click
        AplicarEstiloFuente(FontStyle.Underline)
    End Sub

    Private Sub tscbFuente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbFuente.SelectedIndexChanged
        Dim tamano As Single = rtbDocumento.SelectionFont.Size
        rtbDocumento.SelectionFont = New Font(tscbFuente.Text, tamano, rtbDocumento.SelectionFont.Style)
    End Sub

    Private Sub tscbTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbTamaño.SelectedIndexChanged
        Dim tam As Single = Convert.ToSingle(tscbTamaño.Text)
        rtbDocumento.SelectionFont = New Font(rtbDocumento.SelectionFont.FontFamily, tam, rtbDocumento.SelectionFont.Style)
    End Sub

    ' Combina o quita un estilo de fuente sobre el texto seleccionado
    Private Sub AplicarEstiloFuente(estilo As FontStyle)
        Dim fuenteActual As Font = rtbDocumento.SelectionFont
        If fuenteActual Is Nothing Then Exit Sub
        Dim nuevoEstilo As FontStyle
        If fuenteActual.Style.HasFlag(estilo) Then
            nuevoEstilo = fuenteActual.Style And Not estilo
        Else
            nuevoEstilo = fuenteActual.Style Or estilo
        End If
        rtbDocumento.SelectionFont = New Font(fuenteActual, nuevoEstilo)
    End Sub

    ' Manejo del menú contextual (cmsTexto)
    Private Sub cmsTexto_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsTexto.Opening
        ' Habilita/deshabilita opciones según haya texto seleccionado
        Dim haySeleccion As Boolean = rtbDocumento.SelectionLength > 0
        CortarToolStripMenuItem.Enabled = haySeleccion
        CopiarToolStripMenuItem.Enabled = haySeleccion
        PegarToolStripMenuItem.Enabled = Clipboard.ContainsText()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub SelecionarTodoToolStripMenuItem_Click_Context(sender As Object, e As EventArgs) Handles SeleccionatTodoToolStripMenuItem.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub FuentesToolStripMenuItem_Click_Context(sender As Object, e As EventArgs) Handles FuentesToolStripMenuItem.Click
        digFuente.Font = rtbDocumento.SelectionFont
        If digFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = digFuente.Font
        End If
    End Sub
    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        stsFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss")
    End Sub

    Private Sub frmBlocNotas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If documentoModificado Then

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show(
                "El documento ha sido modificado. ¿Desea guardar los cambios?",
                "Guardar cambios",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then

                GuardarDocumento(False)
                documentoModificado = False

            ElseIf respuesta = DialogResult.Cancel Then

                e.Cancel = True

            End If

        End If
    End Sub

    Private Sub mnuBuscar_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim textoBuscado As String = InputBox("Escriba el texto que desea buscar:", "Buscar")

        If textoBuscado <> "" Then
            Dim posicion As Integer = rtbDocumento.Find(textoBuscado)
            If posicion >= 0 Then
                rtbDocumento.Select(posicion, textoBuscado.Length)
                rtbDocumento.Focus()
            End If

            If posicion = -1 Then
                MessageBox.Show("Texto no encontrado.", "Buscar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub mnuColordetexto_Click(sender As Object, e As EventArgs) Handles mnuColordetexto.Click
        If rtbDocumento.SelectionLength > 0 Then
            If digColor.ShowDialog() = DialogResult.OK Then
                rtbDocumento.SelectionColor = digColor.Color
            End If
        Else
            MessageBox.Show("Seleccione el texto al que desea cambiar el color.",
                            "Color del texto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ContarPalabras()
        Dim texto As String = rtbDocumento.Text.Trim()

        If texto = "" Then
            MessageBox.Show("El documento no contiene palabras.", "Contar palabras",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim palabras() As String = texto.Split(
            New Char() {" "c, ChrW(10), ChrW(13), ChrW(9)},
            StringSplitOptions.RemoveEmptyEntries)

        MessageBox.Show("Cantidad de palabras: " & palabras.Length,
                        "Contar palabras",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub mnuContarPalabras_Click(sender As Object, e As EventArgs)
        ContarPalabras()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click

        MessageBox.Show(
            "Bloc de Notas VB.NET" & vbCrLf &
            "Editor de texto desarrollado en VB.NET." & vbCrLf &
            "Proyecto de Programación.",
            "Acerca de...",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub
End Class