Public Class Main
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GBCaracteristicas As System.Windows.Forms.GroupBox
    Friend WithEvents LTipo As System.Windows.Forms.Label
    Friend WithEvents LColor As System.Windows.Forms.Label
    Friend WithEvents TBcolor As System.Windows.Forms.TextBox
    Friend WithEvents TBtipo As System.Windows.Forms.TextBox
    Friend WithEvents Basignar As System.Windows.Forms.Button
    Friend WithEvents Barrancar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Main))
        Me.GBCaracteristicas = New System.Windows.Forms.GroupBox
        Me.TBcolor = New System.Windows.Forms.TextBox
        Me.TBtipo = New System.Windows.Forms.TextBox
        Me.Basignar = New System.Windows.Forms.Button
        Me.LColor = New System.Windows.Forms.Label
        Me.LTipo = New System.Windows.Forms.Label
        Me.Barrancar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GBCaracteristicas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBCaracteristicas
        '
        Me.GBCaracteristicas.Controls.Add(Me.TBcolor)
        Me.GBCaracteristicas.Controls.Add(Me.TBtipo)
        Me.GBCaracteristicas.Controls.Add(Me.Basignar)
        Me.GBCaracteristicas.Controls.Add(Me.LColor)
        Me.GBCaracteristicas.Controls.Add(Me.LTipo)
        Me.GBCaracteristicas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCaracteristicas.Location = New System.Drawing.Point(9, 8)
        Me.GBCaracteristicas.Name = "GBCaracteristicas"
        Me.GBCaracteristicas.Size = New System.Drawing.Size(160, 120)
        Me.GBCaracteristicas.TabIndex = 4
        Me.GBCaracteristicas.TabStop = False
        Me.GBCaracteristicas.Text = "Caracteristicas"
        '
        'TBcolor
        '
        Me.TBcolor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBcolor.Location = New System.Drawing.Point(56, 50)
        Me.TBcolor.Name = "TBcolor"
        Me.TBcolor.Size = New System.Drawing.Size(96, 21)
        Me.TBcolor.TabIndex = 8
        Me.TBcolor.Text = ""
        '
        'TBtipo
        '
        Me.TBtipo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBtipo.Location = New System.Drawing.Point(56, 24)
        Me.TBtipo.Name = "TBtipo"
        Me.TBtipo.Size = New System.Drawing.Size(96, 21)
        Me.TBtipo.TabIndex = 7
        Me.TBtipo.Text = ""
        '
        'Basignar
        '
        Me.Basignar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Basignar.Location = New System.Drawing.Point(20, 88)
        Me.Basignar.Name = "Basignar"
        Me.Basignar.Size = New System.Drawing.Size(120, 23)
        Me.Basignar.TabIndex = 6
        Me.Basignar.Text = "Asignar"
        '
        'LColor
        '
        Me.LColor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LColor.Location = New System.Drawing.Point(16, 48)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(40, 23)
        Me.LColor.TabIndex = 5
        Me.LColor.Text = "Color"
        '
        'LTipo
        '
        Me.LTipo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTipo.Location = New System.Drawing.Point(16, 24)
        Me.LTipo.Name = "LTipo"
        Me.LTipo.Size = New System.Drawing.Size(32, 23)
        Me.LTipo.TabIndex = 4
        Me.LTipo.Text = "Tipo"
        '
        'Barrancar
        '
        Me.Barrancar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barrancar.Location = New System.Drawing.Point(29, 248)
        Me.Barrancar.Name = "Barrancar"
        Me.Barrancar.Size = New System.Drawing.Size(120, 23)
        Me.Barrancar.TabIndex = 9
        Me.Barrancar.Text = "Arrancar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 136)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 96)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(53, Byte), CType(70, Byte), CType(87, Byte))
        Me.ClientSize = New System.Drawing.Size(178, 287)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GBCaracteristicas)
        Me.Controls.Add(Me.Barrancar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoAgenciaVirtual"
        Me.GBCaracteristicas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim vehiculo As New Vehiculo

    Private Sub BasignarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Basignar.Click
        vehiculo.tipo = TBtipo.Text
        vehiculo.color = TBcolor.Text
    End Sub

    Private Sub BarrancarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Barrancar.Click
        vehiculo.Arrancar(True)
    End Sub

    Private Sub LTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LTipo.Click

    End Sub
End Class
