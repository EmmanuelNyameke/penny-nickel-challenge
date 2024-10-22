<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPenNick
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
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        muClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        lblHeading = New Label()
        lblNumberDays = New Label()
        txtNumberDays = New TextBox()
        grpPayAmt = New GroupBox()
        radNickel = New RadioButton()
        radPenny = New RadioButton()
        lblPay = New Label()
        lblMonthlyPay = New Label()
        btnCalcPay = New Button()
        MenuStrip1.SuspendLayout()
        grpPayAmt.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DisplayStyle = ToolStripItemDisplayStyle.Text
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {muClear, mnuExit})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(37, 20)
        mnuFile.Text = "&File"
        ' 
        ' muClear
        ' 
        muClear.DisplayStyle = ToolStripItemDisplayStyle.Text
        muClear.Name = "muClear"
        muClear.Size = New Size(180, 22)
        muClear.Text = "&Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.DisplayStyle = ToolStripItemDisplayStyle.Text
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(180, 22)
        mnuExit.Text = "E&xit"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(181, 24)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(476, 42)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Penny or Nickel Challenge"
        ' 
        ' lblNumberDays
        ' 
        lblNumberDays.AutoSize = True
        lblNumberDays.BackColor = Color.Silver
        lblNumberDays.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberDays.Location = New Point(193, 97)
        lblNumberDays.Name = "lblNumberDays"
        lblNumberDays.Size = New Size(371, 25)
        lblNumberDays.TabIndex = 2
        lblNumberDays.Text = "Number of Days in the Pay Period:"
        ' 
        ' txtNumberDays
        ' 
        txtNumberDays.Font = New Font("Tahoma", 15.75F)
        txtNumberDays.Location = New Point(570, 94)
        txtNumberDays.Name = "txtNumberDays"
        txtNumberDays.Size = New Size(38, 33)
        txtNumberDays.TabIndex = 3
        txtNumberDays.TextAlign = HorizontalAlignment.Center
        ' 
        ' grpPayAmt
        ' 
        grpPayAmt.BackColor = Color.Silver
        grpPayAmt.Controls.Add(radNickel)
        grpPayAmt.Controls.Add(radPenny)
        grpPayAmt.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPayAmt.ForeColor = Color.Gray
        grpPayAmt.Location = New Point(327, 163)
        grpPayAmt.Name = "grpPayAmt"
        grpPayAmt.Size = New Size(147, 95)
        grpPayAmt.TabIndex = 4
        grpPayAmt.TabStop = False
        grpPayAmt.Text = "Pay Amount:"
        ' 
        ' radNickel
        ' 
        radNickel.AutoSize = True
        radNickel.Location = New Point(16, 62)
        radNickel.Name = "radNickel"
        radNickel.Size = New Size(77, 23)
        radNickel.TabIndex = 1
        radNickel.TabStop = True
        radNickel.Text = "Nickel"
        radNickel.UseVisualStyleBackColor = True
        ' 
        ' radPenny
        ' 
        radPenny.AutoSize = True
        radPenny.Location = New Point(16, 21)
        radPenny.Name = "radPenny"
        radPenny.Size = New Size(77, 23)
        radPenny.TabIndex = 0
        radPenny.TabStop = True
        radPenny.Text = "Penny"
        radPenny.UseVisualStyleBackColor = True
        ' 
        ' lblPay
        ' 
        lblPay.AutoSize = True
        lblPay.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        lblPay.Location = New Point(300, 358)
        lblPay.Name = "lblPay"
        lblPay.Size = New Size(135, 23)
        lblPay.TabIndex = 5
        lblPay.Text = "Monthly Pay:"
        ' 
        ' lblMonthlyPay
        ' 
        lblMonthlyPay.AutoSize = True
        lblMonthlyPay.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        lblMonthlyPay.Location = New Point(457, 358)
        lblMonthlyPay.Name = "lblMonthlyPay"
        lblMonthlyPay.Size = New Size(44, 23)
        lblMonthlyPay.TabIndex = 6
        lblMonthlyPay.Text = "Pay"
        lblMonthlyPay.Visible = False
        ' 
        ' btnCalcPay
        ' 
        btnCalcPay.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalcPay.Location = New Point(287, 292)
        btnCalcPay.Name = "btnCalcPay"
        btnCalcPay.Size = New Size(227, 34)
        btnCalcPay.TabIndex = 7
        btnCalcPay.Text = "Display Monthly Pay"
        btnCalcPay.UseVisualStyleBackColor = True
        ' 
        ' frmPenNick
        ' 
        AcceptButton = btnCalcPay
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.Nickel
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 420)
        Controls.Add(btnCalcPay)
        Controls.Add(lblMonthlyPay)
        Controls.Add(lblPay)
        Controls.Add(grpPayAmt)
        Controls.Add(txtNumberDays)
        Controls.Add(lblNumberDays)
        Controls.Add(lblHeading)
        Controls.Add(MenuStrip1)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.DimGray
        MainMenuStrip = MenuStrip1
        Name = "frmPenNick"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Penny or Nickel Challenge"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        grpPayAmt.ResumeLayout(False)
        grpPayAmt.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents muClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblNumberDays As Label
    Friend WithEvents txtNumberDays As TextBox
    Friend WithEvents grpPayAmt As GroupBox
    Friend WithEvents radNickel As RadioButton
    Friend WithEvents radPenny As RadioButton
    Friend WithEvents lblPay As Label
    Friend WithEvents lblMonthlyPay As Label
    Friend WithEvents btnCalcPay As Button

End Class
