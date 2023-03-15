<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.toMeterConversion = New System.Windows.Forms.RadioButton()
        Me.toInchConversion = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 213)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Converter App"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 58)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter a value and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose your conversion: "
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Navy
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Items.AddRange(New Object() {"  Convert Measurement "})
        Me.ListBox1.Location = New System.Drawing.Point(425, 207)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(241, 99)
        Me.ListBox1.TabIndex = 4
        '
        'toMeterConversion
        '
        Me.toMeterConversion.AutoSize = True
        Me.toMeterConversion.BackColor = System.Drawing.Color.Navy
        Me.toMeterConversion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.toMeterConversion.Location = New System.Drawing.Point(435, 234)
        Me.toMeterConversion.Name = "toMeterConversion"
        Me.toMeterConversion.Size = New System.Drawing.Size(137, 21)
        Me.toMeterConversion.TabIndex = 5
        Me.toMeterConversion.TabStop = True
        Me.toMeterConversion.Text = "Inches to Meters "
        Me.toMeterConversion.UseVisualStyleBackColor = False
        '
        'toInchConversion
        '
        Me.toInchConversion.AutoSize = True
        Me.toInchConversion.BackColor = System.Drawing.Color.Navy
        Me.toInchConversion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.toInchConversion.Location = New System.Drawing.Point(435, 261)
        Me.toInchConversion.Name = "toInchConversion"
        Me.toInchConversion.Size = New System.Drawing.Size(133, 21)
        Me.toInchConversion.TabIndex = 6
        Me.toInchConversion.TabStop = True
        Me.toInchConversion.Text = "Meters to Inches"
        Me.toInchConversion.UseVisualStyleBackColor = False
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConvert.Location = New System.Drawing.Point(16, 385)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(222, 63)
        Me.btnConvert.TabIndex = 7
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(294, 385)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(222, 63)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(572, 385)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(222, 63)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.Navy
        Me.txtValue.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtValue.Location = New System.Drawing.Point(699, 135)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(144, 22)
        Me.txtValue.TabIndex = 10
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.Navy
        Me.txtOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOutput.Location = New System.Drawing.Point(431, 330)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(342, 22)
        Me.txtOutput.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(863, 450)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.toInchConversion)
        Me.Controls.Add(Me.toMeterConversion)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Building Plan Conversions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents toMeterConversion As RadioButton
    Friend WithEvents toInchConversion As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtValue As TextBox
    Friend WithEvents txtOutput As TextBox
End Class
