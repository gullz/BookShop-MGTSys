<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleReport
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
        Me.rvSimple = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'rvSimple
        '
        Me.rvSimple.ActiveViewIndex = -1
        Me.rvSimple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rvSimple.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvSimple.Location = New System.Drawing.Point(0, 0)
        Me.rvSimple.Name = "rvSimple"
        Me.rvSimple.SelectionFormula = ""
        Me.rvSimple.Size = New System.Drawing.Size(284, 262)
        Me.rvSimple.TabIndex = 0
        Me.rvSimple.ViewTimeSelectionFormula = ""
        '
        'frmSimpleReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.rvSimple)
        Me.Name = "frmSimpleReport"
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvSimple As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
