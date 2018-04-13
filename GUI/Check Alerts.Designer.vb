<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Check_Alerts
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AdministrationDataSet2 = New projectMsc.administrationDataSet2()
        Me.CustomerDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataTableAdapter = New projectMsc.administrationDataSet2TableAdapters.CustomerDataTableAdapter()
        Me.CustomerDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdministrationDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(12, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(814, 181)
        Me.DataGridView1.TabIndex = 0
        '
        'AdministrationDataSet2
        '
        Me.AdministrationDataSet2.DataSetName = "administrationDataSet2"
        Me.AdministrationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDataBindingSource
        '
        Me.CustomerDataBindingSource.DataMember = "CustomerData"
        Me.CustomerDataBindingSource.DataSource = Me.AdministrationDataSet2
        '
        'CustomerDataTableAdapter
        '
        Me.CustomerDataTableAdapter.ClearBeforeFill = True
        '
        'CustomerDataBindingSource1
        '
        Me.CustomerDataBindingSource1.DataMember = "CustomerData"
        Me.CustomerDataBindingSource1.DataSource = Me.AdministrationDataSet2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(717, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Double Click A User To See Details"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Turquoise
        Me.Panel7.Controls.Add(Me.Label22)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(838, 36)
        Me.Panel7.TabIndex = 77
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(298, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(193, 26)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "CHECK ALERTS"
        '
        'Check_Alerts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 508)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Check_Alerts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check_Alerts"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdministrationDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AdministrationDataSet2 As administrationDataSet2
    Friend WithEvents CustomerDataBindingSource As BindingSource
    Friend WithEvents CustomerDataTableAdapter As administrationDataSet2TableAdapters.CustomerDataTableAdapter
    Friend WithEvents CustomerDataBindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
