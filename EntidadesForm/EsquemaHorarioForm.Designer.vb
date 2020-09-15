<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EsquemaHorarioForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSucursal = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxEspacio = New System.Windows.Forms.ComboBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.DtPkrFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblReservas = New System.Windows.Forms.Label()
        Me.LvwReservas = New System.Windows.Forms.ListView()
        Me.ColUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColImporte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColHoraDesde = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColHoraHasta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sucursal:"
        '
        'ComboBoxSucursal
        '
        Me.ComboBoxSucursal.FormattingEnabled = True
        Me.ComboBoxSucursal.Location = New System.Drawing.Point(106, 21)
        Me.ComboBoxSucursal.Name = "ComboBoxSucursal"
        Me.ComboBoxSucursal.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxSucursal.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Espacio:"
        '
        'ComboBoxEspacio
        '
        Me.ComboBoxEspacio.FormattingEnabled = True
        Me.ComboBoxEspacio.Location = New System.Drawing.Point(106, 69)
        Me.ComboBoxEspacio.Name = "ComboBoxEspacio"
        Me.ComboBoxEspacio.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxEspacio.TabIndex = 7
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(15, 336)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 8
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'DtPkrFecha
        '
        Me.DtPkrFecha.Location = New System.Drawing.Point(425, 22)
        Me.DtPkrFecha.Name = "DtPkrFecha"
        Me.DtPkrFecha.Size = New System.Drawing.Size(227, 20)
        Me.DtPkrFecha.TabIndex = 9
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(353, 20)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(66, 18)
        Me.LblFecha.TabIndex = 10
        Me.LblFecha.Text = "Fecha:"
        '
        'LblReservas
        '
        Me.LblReservas.AutoSize = True
        Me.LblReservas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReservas.Location = New System.Drawing.Point(146, 117)
        Me.LblReservas.Name = "LblReservas"
        Me.LblReservas.Size = New System.Drawing.Size(96, 18)
        Me.LblReservas.TabIndex = 11
        Me.LblReservas.Text = "Reservas:"
        '
        'LvwReservas
        '
        Me.LvwReservas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColUsuario, Me.ColImporte, Me.ColHoraDesde, Me.ColHoraHasta, Me.ColEstado})
        Me.LvwReservas.Cursor = System.Windows.Forms.Cursors.Default
        Me.LvwReservas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvwReservas.GridLines = True
        Me.LvwReservas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvwReservas.Location = New System.Drawing.Point(15, 138)
        Me.LvwReservas.Name = "LvwReservas"
        Me.LvwReservas.Size = New System.Drawing.Size(637, 192)
        Me.LvwReservas.TabIndex = 13
        Me.LvwReservas.UseCompatibleStateImageBehavior = False
        Me.LvwReservas.View = System.Windows.Forms.View.Details
        '
        'ColUsuario
        '
        Me.ColUsuario.Text = "Usuario"
        Me.ColUsuario.Width = 162
        '
        'ColImporte
        '
        Me.ColImporte.Text = "Importe"
        Me.ColImporte.Width = 109
        '
        'ColHoraDesde
        '
        Me.ColHoraDesde.Text = "Desde"
        Me.ColHoraDesde.Width = 89
        '
        'ColHoraHasta
        '
        Me.ColHoraHasta.Text = "Hasta"
        Me.ColHoraHasta.Width = 79
        '
        'ColEstado
        '
        Me.ColEstado.Text = "Estado"
        Me.ColEstado.Width = 178
        '
        'EsquemaHorarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 371)
        Me.Controls.Add(Me.LvwReservas)
        Me.Controls.Add(Me.LblReservas)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.DtPkrFecha)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.ComboBoxEspacio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxSucursal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EsquemaHorarioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Esquema de Horarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxSucursal As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxEspacio As ComboBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents DtPkrFecha As DateTimePicker
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblReservas As Label
    Friend WithEvents LvwReservas As ListView
    Friend WithEvents ColUsuario As ColumnHeader
    Friend WithEvents ColImporte As ColumnHeader
    Friend WithEvents ColHoraDesde As ColumnHeader
    Friend WithEvents ColHoraHasta As ColumnHeader
    Friend WithEvents ColEstado As ColumnHeader
End Class
