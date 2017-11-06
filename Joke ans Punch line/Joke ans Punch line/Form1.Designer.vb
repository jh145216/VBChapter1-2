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
        Me.btnJoke = New System.Windows.Forms.Button()
        Me.btnPunchline = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblJoke = New System.Windows.Forms.Label()
        Me.lblPunchline = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnJoke
        '
        Me.btnJoke.Location = New System.Drawing.Point(36, 182)
        Me.btnJoke.Name = "btnJoke"
        Me.btnJoke.Size = New System.Drawing.Size(75, 23)
        Me.btnJoke.TabIndex = 0
        Me.btnJoke.Text = "Joke"
        Me.btnJoke.UseVisualStyleBackColor = True
        '
        'btnPunchline
        '
        Me.btnPunchline.Location = New System.Drawing.Point(477, 182)
        Me.btnPunchline.Name = "btnPunchline"
        Me.btnPunchline.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchline.TabIndex = 1
        Me.btnPunchline.Text = "Punch line"
        Me.btnPunchline.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Click the buttons to display the Joke and Punch line"
        '
        'lblJoke
        '
        Me.lblJoke.AutoSize = True
        Me.lblJoke.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoke.Location = New System.Drawing.Point(3, 68)
        Me.lblJoke.Name = "lblJoke"
        Me.lblJoke.Size = New System.Drawing.Size(392, 17)
        Me.lblJoke.TabIndex = 3
        Me.lblJoke.Text = "How many programmers does it take to change a light bulb"
        Me.lblJoke.Visible = False
        '
        'lblPunchline
        '
        Me.lblPunchline.AutoSize = True
        Me.lblPunchline.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPunchline.Location = New System.Drawing.Point(474, 68)
        Me.lblPunchline.Name = "lblPunchline"
        Me.lblPunchline.Size = New System.Drawing.Size(225, 17)
        Me.lblPunchline.TabIndex = 4
        Me.lblPunchline.Text = "None. That's a hardware problem"
        Me.lblPunchline.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(267, 182)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 245)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPunchline)
        Me.Controls.Add(Me.lblJoke)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPunchline)
        Me.Controls.Add(Me.btnJoke)
        Me.Name = "Form1"
        Me.Text = "Joke and Punch line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnJoke As System.Windows.Forms.Button
    Friend WithEvents btnPunchline As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblJoke As System.Windows.Forms.Label
    Friend WithEvents lblPunchline As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
