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
        Me.l1 = New System.Windows.Forms.ListBox
        Me.l2 = New System.Windows.Forms.ListBox
        Me.ball = New System.Windows.Forms.Button
        Me.bsingleb = New System.Windows.Forms.Button
        Me.ballb = New System.Windows.Forms.Button
        Me.bmultib = New System.Windows.Forms.Button
        Me.bmulti = New System.Windows.Forms.Button
        Me.bsingle = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'l1
        '
        Me.l1.FormattingEnabled = True
        Me.l1.ItemHeight = 16
        Me.l1.Items.AddRange(New Object() {"ashish ", "manish ", "anish ", "aksash ", "puja ", "radhika", "ram", "maniyo", "manan"})
        Me.l1.Location = New System.Drawing.Point(13, 22)
        Me.l1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.l1.Name = "l1"
        Me.l1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.l1.Size = New System.Drawing.Size(120, 372)
        Me.l1.TabIndex = 0
        '
        'l2
        '
        Me.l2.FormattingEnabled = True
        Me.l2.ItemHeight = 16
        Me.l2.Location = New System.Drawing.Point(248, 25)
        Me.l2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.l2.Name = "l2"
        Me.l2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.l2.Size = New System.Drawing.Size(241, 372)
        Me.l2.TabIndex = 1
        '
        'ball
        '
        Me.ball.Location = New System.Drawing.Point(149, 159)
        Me.ball.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(64, 38)
        Me.ball.TabIndex = 3
        Me.ball.Text = ">>>"
        Me.ball.UseVisualStyleBackColor = True
        '
        'bsingleb
        '
        Me.bsingleb.Location = New System.Drawing.Point(149, 223)
        Me.bsingleb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bsingleb.Name = "bsingleb"
        Me.bsingleb.Size = New System.Drawing.Size(64, 38)
        Me.bsingleb.TabIndex = 4
        Me.bsingleb.Text = "<"
        Me.bsingleb.UseVisualStyleBackColor = True
        '
        'ballb
        '
        Me.ballb.Location = New System.Drawing.Point(149, 341)
        Me.ballb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ballb.Name = "ballb"
        Me.ballb.Size = New System.Drawing.Size(64, 38)
        Me.ballb.TabIndex = 6
        Me.ballb.Text = "<<<"
        Me.ballb.UseVisualStyleBackColor = True
        '
        'bmultib
        '
        Me.bmultib.Location = New System.Drawing.Point(149, 277)
        Me.bmultib.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bmultib.Name = "bmultib"
        Me.bmultib.Size = New System.Drawing.Size(64, 38)
        Me.bmultib.TabIndex = 5
        Me.bmultib.Text = "<<"
        Me.bmultib.UseVisualStyleBackColor = True
        '
        'bmulti
        '
        Me.bmulti.Location = New System.Drawing.Point(149, 102)
        Me.bmulti.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bmulti.Name = "bmulti"
        Me.bmulti.Size = New System.Drawing.Size(64, 37)
        Me.bmulti.TabIndex = 8
        Me.bmulti.Text = ">>"
        Me.bmulti.UseVisualStyleBackColor = True
        '
        'bsingle
        '
        Me.bsingle.Location = New System.Drawing.Point(149, 38)
        Me.bsingle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bsingle.Name = "bsingle"
        Me.bsingle.Size = New System.Drawing.Size(64, 37)
        Me.bsingle.TabIndex = 7
        Me.bsingle.Text = ">"
        Me.bsingle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(529, 410)
        Me.Controls.Add(Me.bmulti)
        Me.Controls.Add(Me.bsingle)
        Me.Controls.Add(Me.ballb)
        Me.Controls.Add(Me.bmultib)
        Me.Controls.Add(Me.bsingleb)
        Me.Controls.Add(Me.ball)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents l1 As System.Windows.Forms.ListBox
    Friend WithEvents l2 As System.Windows.Forms.ListBox
    Friend WithEvents ball As System.Windows.Forms.Button
    Friend WithEvents bsingleb As System.Windows.Forms.Button
    Friend WithEvents ballb As System.Windows.Forms.Button
    Friend WithEvents bmultib As System.Windows.Forms.Button
    Friend WithEvents bmulti As System.Windows.Forms.Button
    Friend WithEvents bsingle As System.Windows.Forms.Button

End Class
