<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnLTrim = New Button()
        btnTrim = New Button()
        btnRTrim = New Button()
        btnClose = New Button()
        lblHeading = New Label()
        lblEnterAPhrase = New Label()
        txtPhrase = New TextBox()
        Label1 = New Label()
        txtSelectedTrimResults = New TextBox()
        SuspendLayout()
        ' 
        ' btnLTrim
        ' 
        btnLTrim.Location = New Point(112, 326)
        btnLTrim.Name = "btnLTrim"
        btnLTrim.Size = New Size(138, 29)
        btnLTrim.TabIndex = 0
        btnLTrim.Text = "LTrim"
        btnLTrim.UseVisualStyleBackColor = True
        ' 
        ' btnTrim
        ' 
        btnTrim.Location = New Point(306, 326)
        btnTrim.Name = "btnTrim"
        btnTrim.Size = New Size(138, 29)
        btnTrim.TabIndex = 0
        btnTrim.Text = "Trim"
        btnTrim.UseVisualStyleBackColor = True
        ' 
        ' btnRTrim
        ' 
        btnRTrim.Location = New Point(510, 326)
        btnRTrim.Name = "btnRTrim"
        btnRTrim.Size = New Size(138, 29)
        btnRTrim.TabIndex = 0
        btnRTrim.Text = "RTrim"
        btnRTrim.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(306, 377)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(138, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Snap ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblHeading.ForeColor = Color.Navy
        lblHeading.Location = New Point(240, 36)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(291, 36)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Choose you Trim"
        ' 
        ' lblEnterAPhrase
        ' 
        lblEnterAPhrase.AutoSize = True
        lblEnterAPhrase.Location = New Point(148, 111)
        lblEnterAPhrase.Name = "lblEnterAPhrase"
        lblEnterAPhrase.Size = New Size(102, 20)
        lblEnterAPhrase.TabIndex = 2
        lblEnterAPhrase.Text = "Enter a Phrase"
        ' 
        ' txtPhrase
        ' 
        txtPhrase.Location = New Point(345, 108)
        txtPhrase.Name = "txtPhrase"
        txtPhrase.Size = New Size(275, 27)
        txtPhrase.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(148, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 20)
        Label1.TabIndex = 2
        Label1.Text = "Selected Trim Results"
        ' 
        ' txtSelectedTrimResults
        ' 
        txtSelectedTrimResults.Location = New Point(345, 156)
        txtSelectedTrimResults.Name = "txtSelectedTrimResults"
        txtSelectedTrimResults.Size = New Size(275, 27)
        txtSelectedTrimResults.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtSelectedTrimResults)
        Controls.Add(txtPhrase)
        Controls.Add(Label1)
        Controls.Add(lblEnterAPhrase)
        Controls.Add(lblHeading)
        Controls.Add(btnClose)
        Controls.Add(btnRTrim)
        Controls.Add(btnTrim)
        Controls.Add(btnLTrim)
        Name = "Form1"
        Text = "Trims"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLTrim As Button
    Friend WithEvents btnTrim As Button
    Friend WithEvents btnRTrim As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblEnterAPhrase As Label
    Friend WithEvents txtPhrase As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSelectedTrimResults As TextBox
End Class
