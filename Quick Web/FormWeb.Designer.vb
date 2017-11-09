<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormWeb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormWeb))
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.TxtWeb = New MetroFramework.Controls.MetroTextBox()
        Me.CmdHome = New MetroFramework.Controls.MetroButton()
        Me.CmdForward = New MetroFramework.Controls.MetroButton()
        Me.CmdBack = New MetroFramework.Controls.MetroButton()
        Me.Web = New System.Windows.Forms.WebBrowser()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.TxtWeb)
        Me.MetroPanel1.Controls.Add(Me.CmdHome)
        Me.MetroPanel1.Controls.Add(Me.CmdForward)
        Me.MetroPanel1.Controls.Add(Me.CmdBack)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(784, 47)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'TxtWeb
        '
        Me.TxtWeb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TxtWeb.CustomButton.Image = Nothing
        Me.TxtWeb.CustomButton.Location = New System.Drawing.Point(561, 1)
        Me.TxtWeb.CustomButton.Name = ""
        Me.TxtWeb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.TxtWeb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtWeb.CustomButton.TabIndex = 1
        Me.TxtWeb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtWeb.CustomButton.UseSelectable = True
        Me.TxtWeb.CustomButton.Visible = False
        Me.TxtWeb.Lines = New String() {"https://www.google.co.in/"}
        Me.TxtWeb.Location = New System.Drawing.Point(154, 12)
        Me.TxtWeb.MaxLength = 32767
        Me.TxtWeb.Name = "TxtWeb"
        Me.TxtWeb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtWeb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtWeb.SelectedText = ""
        Me.TxtWeb.SelectionLength = 0
        Me.TxtWeb.SelectionStart = 0
        Me.TxtWeb.ShortcutsEnabled = True
        Me.TxtWeb.Size = New System.Drawing.Size(583, 23)
        Me.TxtWeb.TabIndex = 5
        Me.TxtWeb.Text = "https://www.google.co.in/"
        Me.TxtWeb.UseSelectable = True
        Me.TxtWeb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtWeb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CmdHome
        '
        Me.CmdHome.BackColor = System.Drawing.SystemColors.Control
        Me.CmdHome.BackgroundImage = Global.Quick_Web.My.Resources.Resources.home
        Me.CmdHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdHome.Location = New System.Drawing.Point(105, 12)
        Me.CmdHome.Name = "CmdHome"
        Me.CmdHome.Size = New System.Drawing.Size(43, 23)
        Me.CmdHome.TabIndex = 4
        Me.CmdHome.UseSelectable = True
        '
        'CmdForward
        '
        Me.CmdForward.BackColor = System.Drawing.Color.Transparent
        Me.CmdForward.BackgroundImage = CType(resources.GetObject("CmdForward.BackgroundImage"), System.Drawing.Image)
        Me.CmdForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdForward.Location = New System.Drawing.Point(55, 12)
        Me.CmdForward.Name = "CmdForward"
        Me.CmdForward.Size = New System.Drawing.Size(43, 23)
        Me.CmdForward.TabIndex = 3
        Me.CmdForward.UseSelectable = True
        '
        'CmdBack
        '
        Me.CmdBack.BackColor = System.Drawing.Color.Transparent
        Me.CmdBack.BackgroundImage = Global.Quick_Web.My.Resources.Resources.back
        Me.CmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdBack.Location = New System.Drawing.Point(12, 12)
        Me.CmdBack.Name = "CmdBack"
        Me.CmdBack.Size = New System.Drawing.Size(43, 23)
        Me.CmdBack.TabIndex = 2
        Me.CmdBack.UseSelectable = True
        '
        'Web
        '
        Me.Web.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Web.Location = New System.Drawing.Point(0, 47)
        Me.Web.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web.Name = "Web"
        Me.Web.Size = New System.Drawing.Size(784, 515)
        Me.Web.TabIndex = 1
        '
        'FormWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Web)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "FormWeb"
        Me.Text = "Quick Web"
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Web As WebBrowser
    Friend WithEvents CmdBack As MetroFramework.Controls.MetroButton
    Friend WithEvents CmdForward As MetroFramework.Controls.MetroButton
    Friend WithEvents CmdHome As MetroFramework.Controls.MetroButton
    Friend WithEvents TxtWeb As MetroFramework.Controls.MetroTextBox
End Class
