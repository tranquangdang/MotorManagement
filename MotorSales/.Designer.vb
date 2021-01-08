<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rpMotor
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rpXe = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblMotorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMotor = New MotorSales.DSMotor()
        Me.tblMotorTableAdapter = New MotorSales.DSMotorTableAdapters.tblMotorTableAdapter()
        CType(Me.tblMotorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMotor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpXe
        '
        Me.rpXe.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSMotor"
        ReportDataSource1.Value = Me.tblMotorBindingSource
        Me.rpXe.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpXe.LocalReport.ReportEmbeddedResource = "MotorSales.rpMotor.rdlc"
        Me.rpXe.Location = New System.Drawing.Point(0, 0)
        Me.rpXe.Name = "rpXe"
        Me.rpXe.ServerReport.BearerToken = Nothing
        Me.rpXe.Size = New System.Drawing.Size(800, 450)
        Me.rpXe.TabIndex = 0
        '
        'tblMotorBindingSource
        '
        Me.tblMotorBindingSource.DataMember = "tblMotor"
        Me.tblMotorBindingSource.DataSource = Me.DSMotor
        '
        'DSMotor
        '
        Me.DSMotor.DataSetName = "DSMotor"
        Me.DSMotor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblMotorTableAdapter
        '
        Me.tblMotorTableAdapter.ClearBeforeFill = True
        '
        'rpMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rpXe)
        Me.Name = "rpMotor"
        Me.Text = "Biên bảng kiểm kê"
        CType(Me.tblMotorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMotor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpXe As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblMotorBindingSource As BindingSource
    Friend WithEvents DSMotor As DSMotor
    Friend WithEvents tblMotorTableAdapter As DSMotorTableAdapters.tblMotorTableAdapter
End Class
