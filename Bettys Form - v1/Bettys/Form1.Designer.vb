﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim ToolTip1 As System.Windows.Forms.ToolTip
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.drizzleCakeAmount = New System.Windows.Forms.NumericUpDown()
        Me.cupCakeAmount = New System.Windows.Forms.NumericUpDown()
        Me.smallPlainFlourBox = New System.Windows.Forms.Label()
        Me.smallSugarBox = New System.Windows.Forms.Label()
        Me.smallButterBox = New System.Windows.Forms.Label()
        Me.mediumFlourBox = New System.Windows.Forms.Label()
        Me.mediumButterBox = New System.Windows.Forms.Label()
        Me.mediumSugarBox = New System.Windows.Forms.Label()
        Me.largeSugarBox = New System.Windows.Forms.Label()
        Me.largeFlourBox = New System.Windows.Forms.Label()
        Me.largeButterBox = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.plainFlourAmount = New System.Windows.Forms.Label()
        Me.sugarAmount = New System.Windows.Forms.Label()
        Me.butterAmount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.drizzleCakeAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cupCakeAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'drizzleCakeAmount
        '
        Me.drizzleCakeAmount.Location = New System.Drawing.Point(228, 252)
        Me.drizzleCakeAmount.Name = "drizzleCakeAmount"
        Me.drizzleCakeAmount.Size = New System.Drawing.Size(120, 20)
        Me.drizzleCakeAmount.TabIndex = 0
        ToolTip1.SetToolTip(Me.drizzleCakeAmount, "Please Enter Or Select The Amount Of Cakes You Would Like")
        '
        'cupCakeAmount
        '
        Me.cupCakeAmount.Location = New System.Drawing.Point(228, 214)
        Me.cupCakeAmount.Name = "cupCakeAmount"
        Me.cupCakeAmount.Size = New System.Drawing.Size(120, 20)
        Me.cupCakeAmount.TabIndex = 1
        ToolTip1.SetToolTip(Me.cupCakeAmount, "Please Enter Or Select The Amount Of CupCakes You Would Like")
        '
        'smallPlainFlourBox
        '
        Me.smallPlainFlourBox.AutoSize = True
        Me.smallPlainFlourBox.Location = New System.Drawing.Point(156, 511)
        Me.smallPlainFlourBox.Name = "smallPlainFlourBox"
        Me.smallPlainFlourBox.Size = New System.Drawing.Size(13, 13)
        Me.smallPlainFlourBox.TabIndex = 2
        Me.smallPlainFlourBox.Text = "0"
        '
        'smallSugarBox
        '
        Me.smallSugarBox.AutoSize = True
        Me.smallSugarBox.Location = New System.Drawing.Point(156, 605)
        Me.smallSugarBox.Name = "smallSugarBox"
        Me.smallSugarBox.Size = New System.Drawing.Size(13, 13)
        Me.smallSugarBox.TabIndex = 3
        Me.smallSugarBox.Text = "0"
        '
        'smallButterBox
        '
        Me.smallButterBox.AutoSize = True
        Me.smallButterBox.Location = New System.Drawing.Point(156, 570)
        Me.smallButterBox.Name = "smallButterBox"
        Me.smallButterBox.Size = New System.Drawing.Size(13, 13)
        Me.smallButterBox.TabIndex = 4
        Me.smallButterBox.Text = "0"
        '
        'mediumFlourBox
        '
        Me.mediumFlourBox.AutoSize = True
        Me.mediumFlourBox.Location = New System.Drawing.Point(238, 511)
        Me.mediumFlourBox.Name = "mediumFlourBox"
        Me.mediumFlourBox.Size = New System.Drawing.Size(13, 13)
        Me.mediumFlourBox.TabIndex = 5
        Me.mediumFlourBox.Text = "0"
        '
        'mediumButterBox
        '
        Me.mediumButterBox.AutoSize = True
        Me.mediumButterBox.Location = New System.Drawing.Point(238, 570)
        Me.mediumButterBox.Name = "mediumButterBox"
        Me.mediumButterBox.Size = New System.Drawing.Size(13, 13)
        Me.mediumButterBox.TabIndex = 6
        Me.mediumButterBox.Text = "0"
        '
        'mediumSugarBox
        '
        Me.mediumSugarBox.AutoSize = True
        Me.mediumSugarBox.Location = New System.Drawing.Point(238, 605)
        Me.mediumSugarBox.Name = "mediumSugarBox"
        Me.mediumSugarBox.Size = New System.Drawing.Size(13, 13)
        Me.mediumSugarBox.TabIndex = 7
        Me.mediumSugarBox.Text = "0"
        '
        'largeSugarBox
        '
        Me.largeSugarBox.AutoSize = True
        Me.largeSugarBox.Location = New System.Drawing.Point(321, 605)
        Me.largeSugarBox.Name = "largeSugarBox"
        Me.largeSugarBox.Size = New System.Drawing.Size(13, 13)
        Me.largeSugarBox.TabIndex = 8
        Me.largeSugarBox.Text = "0"
        '
        'largeFlourBox
        '
        Me.largeFlourBox.AutoSize = True
        Me.largeFlourBox.Location = New System.Drawing.Point(321, 511)
        Me.largeFlourBox.Name = "largeFlourBox"
        Me.largeFlourBox.Size = New System.Drawing.Size(13, 13)
        Me.largeFlourBox.TabIndex = 9
        Me.largeFlourBox.Text = "0"
        '
        'largeButterBox
        '
        Me.largeButterBox.AutoSize = True
        Me.largeButterBox.Location = New System.Drawing.Point(321, 570)
        Me.largeButterBox.Name = "largeButterBox"
        Me.largeButterBox.Size = New System.Drawing.Size(13, 13)
        Me.largeButterBox.TabIndex = 10
        Me.largeButterBox.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 36)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Enter"
        ToolTip1.SetToolTip(Me.Button1, "Press (Or key [ENTER]) To Activate The Program")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(12, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 36)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Reset"
        ToolTip1.SetToolTip(Me.Button2, "Press (Or Key [ESC]) To Reset The Program")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'plainFlourAmount
        '
        Me.plainFlourAmount.AutoSize = True
        Me.plainFlourAmount.Location = New System.Drawing.Point(208, 336)
        Me.plainFlourAmount.Name = "plainFlourAmount"
        Me.plainFlourAmount.Size = New System.Drawing.Size(13, 13)
        Me.plainFlourAmount.TabIndex = 13
        Me.plainFlourAmount.Text = "0"
        '
        'sugarAmount
        '
        Me.sugarAmount.AutoSize = True
        Me.sugarAmount.Location = New System.Drawing.Point(208, 431)
        Me.sugarAmount.Name = "sugarAmount"
        Me.sugarAmount.Size = New System.Drawing.Size(13, 13)
        Me.sugarAmount.TabIndex = 14
        Me.sugarAmount.Text = "0"
        '
        'butterAmount
        '
        Me.butterAmount.AutoSize = True
        Me.butterAmount.Location = New System.Drawing.Point(208, 398)
        Me.butterAmount.Name = "butterAmount"
        Me.butterAmount.Size = New System.Drawing.Size(13, 13)
        Me.butterAmount.TabIndex = 15
        Me.butterAmount.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Medium"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(314, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Large"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(149, 490)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Small"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Bettys.My.Resources.Resources.jhlogo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(352, 605)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 36)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'ToolTip1
        '
        ToolTip1.IsBalloon = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(461, 653)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.butterAmount)
        Me.Controls.Add(Me.sugarAmount)
        Me.Controls.Add(Me.plainFlourAmount)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.largeButterBox)
        Me.Controls.Add(Me.largeFlourBox)
        Me.Controls.Add(Me.largeSugarBox)
        Me.Controls.Add(Me.mediumSugarBox)
        Me.Controls.Add(Me.mediumButterBox)
        Me.Controls.Add(Me.mediumFlourBox)
        Me.Controls.Add(Me.smallButterBox)
        Me.Controls.Add(Me.smallSugarBox)
        Me.Controls.Add(Me.smallPlainFlourBox)
        Me.Controls.Add(Me.cupCakeAmount)
        Me.Controls.Add(Me.drizzleCakeAmount)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bettys Best Ever Bakery - v1 Test"
        Me.TopMost = True
        CType(Me.drizzleCakeAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cupCakeAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents drizzleCakeAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents cupCakeAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents smallPlainFlourBox As System.Windows.Forms.Label
    Friend WithEvents smallSugarBox As System.Windows.Forms.Label
    Friend WithEvents smallButterBox As System.Windows.Forms.Label
    Friend WithEvents mediumFlourBox As System.Windows.Forms.Label
    Friend WithEvents mediumButterBox As System.Windows.Forms.Label
    Friend WithEvents mediumSugarBox As System.Windows.Forms.Label
    Friend WithEvents largeSugarBox As System.Windows.Forms.Label
    Friend WithEvents largeFlourBox As System.Windows.Forms.Label
    Friend WithEvents largeButterBox As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents plainFlourAmount As System.Windows.Forms.Label
    Friend WithEvents sugarAmount As System.Windows.Forms.Label
    Friend WithEvents butterAmount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class