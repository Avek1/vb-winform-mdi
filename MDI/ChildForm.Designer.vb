﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChildForm
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
        Me.DocumentTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'DocumentTextBox
        '
        Me.DocumentTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentTextBox.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTextBox.Name = "DocumentTextBox"
        Me.DocumentTextBox.Size = New System.Drawing.Size(552, 296)
        Me.DocumentTextBox.TabIndex = 0
        Me.DocumentTextBox.Text = ""
        '
        'ChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 296)
        Me.Controls.Add(Me.DocumentTextBox)
        Me.Name = "ChildForm"
        Me.Text = "New Document"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DocumentTextBox As RichTextBox
End Class
