<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewerInvoice = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInvoice = New MotorSales.DSInvoice()
        Me.tblOrderInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblInvoiceTableAdapter = New MotorSales.DSInvoiceTableAdapters.tblInvoiceTableAdapter()
        Me.tblOrderInvoiceTableAdapter = New MotorSales.DSInvoiceTableAdapters.tblOrderInvoiceTableAdapter()
        CType(Me.tblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblOrderInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewerInvoice
        '
        Me.ReportViewerInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSSInvoice"
        ReportDataSource1.Value = Me.tblInvoiceBindingSource
        ReportDataSource2.Name = "DSSCustomer"
        ReportDataSource2.Value = Me.tblOrderInvoiceBindingSource
        Me.ReportViewerInvoice.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerInvoice.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewerInvoice.LocalReport.ReportEmbeddedResource = "MotorSales.rpInvoice.rdlc"
        Me.ReportViewerInvoice.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerInvoice.Name = "ReportViewerInvoice"
        Me.ReportViewerInvoice.ServerReport.BearerToken = Nothing
        Me.ReportViewerInvoice.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewerInvoice.TabIndex = 0
        '
        'tblInvoiceBindingSource
        '
        Me.tblInvoiceBindingSource.DataMember = "tblInvoice"
        Me.tblInvoiceBindingSource.DataSource = Me.DSInvoice
        '
        'DSInvoice
        '
        Me.DSInvoice.DataSetName = "DSInvoice"
        Me.DSInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblOrderInvoiceBindingSource
        '
        Me.tblOrderInvoiceBindingSource.DataMember = "tblOrderInvoice"
        Me.tblOrderInvoiceBindingSource.DataSource = Me.DSInvoice
        '
        'tblInvoiceTableAdapter
        '
        Me.tblInvoiceTableAdapter.ClearBeforeFill = True
        '
        'tblOrderInvoiceTableAdapter
        '
        Me.tblOrderInvoiceTableAdapter.ClearBeforeFill = True
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewerInvoice)
        Me.Name = "Invoice"
        Me.Text = "Invoice"
        CType(Me.tblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblOrderInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerInvoice As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblInvoiceBindingSource As BindingSource
    Friend WithEvents DSInvoice As DSInvoice
    Friend WithEvents tblInvoiceTableAdapter As DSInvoiceTableAdapters.tblInvoiceTableAdapter
    Friend WithEvents tblOrderInvoiceBindingSource As BindingSource
    Friend WithEvents tblOrderInvoiceTableAdapter As DSInvoiceTableAdapters.tblOrderInvoiceTableAdapter
End Class
