<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarReservas
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
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.DtPkrFecha = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxEspacio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxSucursal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxHorario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LvwReservas = New System.Windows.Forms.ListView()
        Me.ColHoraDesde = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColHoraHasta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblReservas = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DtPkrHoraDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtPkrHoraHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnReservar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(287, 11)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(66, 18)
        Me.LblFecha.TabIndex = 16
        Me.LblFecha.Text = "Fecha:"
        '
        'DtPkrFecha
        '
        Me.DtPkrFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtPkrFecha.Location = New System.Drawing.Point(373, 12)
        Me.DtPkrFecha.Name = "DtPkrFecha"
        Me.DtPkrFecha.Size = New System.Drawing.Size(136, 20)
        Me.DtPkrFecha.TabIndex = 15
        '
        'ComboBoxEspacio
        '
        Me.ComboBoxEspacio.FormattingEnabled = True
        Me.ComboBoxEspacio.Location = New System.Drawing.Point(106, 60)
        Me.ComboBoxEspacio.Name = "ComboBoxEspacio"
        Me.ComboBoxEspacio.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxEspacio.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Espacio:"
        '
        'ComboBoxSucursal
        '
        Me.ComboBoxSucursal.FormattingEnabled = True
        Me.ComboBoxSucursal.Location = New System.Drawing.Point(106, 12)
        Me.ComboBoxSucursal.Name = "ComboBoxSucursal"
        Me.ComboBoxSucursal.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxSucursal.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Sucursal:"
        '
        'ComboBoxHorario
        '
        Me.ComboBoxHorario.FormattingEnabled = True
        Me.ComboBoxHorario.Location = New System.Drawing.Point(373, 60)
        Me.ComboBoxHorario.Name = "ComboBoxHorario"
        Me.ComboBoxHorario.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxHorario.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Horario:"
        '
        'LvwReservas
        '
        Me.LvwReservas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColHoraDesde, Me.ColHoraHasta, Me.ColEstado})
        Me.LvwReservas.Cursor = System.Windows.Forms.Cursors.Default
        Me.LvwReservas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvwReservas.GridLines = True
        Me.LvwReservas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvwReservas.HideSelection = False
        Me.LvwReservas.Location = New System.Drawing.Point(15, 129)
        Me.LvwReservas.Name = "LvwReservas"
        Me.LvwReservas.Size = New System.Drawing.Size(637, 122)
        Me.LvwReservas.TabIndex = 21
        Me.LvwReservas.UseCompatibleStateImageBehavior = False
        Me.LvwReservas.View = System.Windows.Forms.View.Details
        '
        'ColHoraDesde
        '
        Me.ColHoraDesde.Text = "Desde"
        Me.ColHoraDesde.Width = 223
        '
        'ColHoraHasta
        '
        Me.ColHoraHasta.Text = "Hasta"
        Me.ColHoraHasta.Width = 223
        '
        'ColEstado
        '
        Me.ColEstado.Text = "Estado"
        Me.ColEstado.Width = 223
        '
        'LblReservas
        '
        Me.LblReservas.AutoSize = True
        Me.LblReservas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReservas.Location = New System.Drawing.Point(12, 98)
        Me.LblReservas.Name = "LblReservas"
        Me.LblReservas.Size = New System.Drawing.Size(96, 18)
        Me.LblReservas.TabIndex = 20
        Me.LblReservas.Text = "Reservas:"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(15, 327)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 19
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(664, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DtPkrHoraDesde
        '
        Me.DtPkrHoraDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtPkrHoraDesde.Location = New System.Drawing.Point(135, 269)
        Me.DtPkrHoraDesde.Name = "DtPkrHoraDesde"
        Me.DtPkrHoraDesde.Size = New System.Drawing.Size(131, 20)
        Me.DtPkrHoraDesde.TabIndex = 23
        '
        'DtPkrHoraHasta
        '
        Me.DtPkrHoraHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtPkrHoraHasta.Location = New System.Drawing.Point(400, 269)
        Me.DtPkrHoraHasta.Name = "DtPkrHoraHasta"
        Me.DtPkrHoraHasta.Size = New System.Drawing.Size(131, 20)
        Me.DtPkrHoraHasta.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Hora Desde:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(287, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 18)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Hora Hasta"
        '
        'BtnReservar
        '
        Me.BtnReservar.Location = New System.Drawing.Point(577, 327)
        Me.BtnReservar.Name = "BtnReservar"
        Me.BtnReservar.Size = New System.Drawing.Size(75, 23)
        Me.BtnReservar.TabIndex = 27
        Me.BtnReservar.Text = "Reservar"
        Me.BtnReservar.UseVisualStyleBackColor = True
        '
        'AgregarReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 371)
        Me.Controls.Add(Me.BtnReservar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DtPkrHoraHasta)
        Me.Controls.Add(Me.DtPkrHoraDesde)
        Me.Controls.Add(Me.LvwReservas)
        Me.Controls.Add(Me.LblReservas)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.ComboBoxHorario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.DtPkrFecha)
        Me.Controls.Add(Me.ComboBoxEspacio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxSucursal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AgregarReservas"
        Me.Text = "AgregarReservas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFecha As Label
    Friend WithEvents DtPkrFecha As DateTimePicker
    Friend WithEvents ComboBoxEspacio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxSucursal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxHorario As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LvwReservas As ListView
    Friend WithEvents ColHoraDesde As ColumnHeader
    Friend WithEvents ColHoraHasta As ColumnHeader
    Friend WithEvents ColEstado As ColumnHeader
    Friend WithEvents LblReservas As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DtPkrHoraDesde As DateTimePicker
    Friend WithEvents DtPkrHoraHasta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnReservar As Button
End Class
