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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.label_title = New System.Windows.Forms.Label()
        Me.label_studentno = New System.Windows.Forms.Label()
        Me.label_firstname = New System.Windows.Forms.Label()
        Me.label_middlename = New System.Windows.Forms.Label()
        Me.label_surname = New System.Windows.Forms.Label()
        Me.textbox_studentno = New System.Windows.Forms.TextBox()
        Me.textbox_firstname = New System.Windows.Forms.TextBox()
        Me.textbox_middlename = New System.Windows.Forms.TextBox()
        Me.textbox_lastname = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(354, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(392, 212)
        Me.DataGridView1.TabIndex = 0
        '
        'label_title
        '
        Me.label_title.AutoSize = True
        Me.label_title.Font = New System.Drawing.Font("Bell MT", 16.0!)
        Me.label_title.Location = New System.Drawing.Point(449, 58)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(182, 30)
        Me.label_title.TabIndex = 1
        Me.label_title.Text = "Student Profile"
        '
        'label_studentno
        '
        Me.label_studentno.AutoSize = True
        Me.label_studentno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.label_studentno.Location = New System.Drawing.Point(47, 121)
        Me.label_studentno.Name = "label_studentno"
        Me.label_studentno.Size = New System.Drawing.Size(86, 18)
        Me.label_studentno.TabIndex = 2
        Me.label_studentno.Text = "Student No."
        '
        'label_firstname
        '
        Me.label_firstname.AutoSize = True
        Me.label_firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.label_firstname.Location = New System.Drawing.Point(47, 191)
        Me.label_firstname.Name = "label_firstname"
        Me.label_firstname.Size = New System.Drawing.Size(81, 18)
        Me.label_firstname.TabIndex = 3
        Me.label_firstname.Text = "First Name"
        '
        'label_middlename
        '
        Me.label_middlename.AutoSize = True
        Me.label_middlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.label_middlename.Location = New System.Drawing.Point(47, 252)
        Me.label_middlename.Name = "label_middlename"
        Me.label_middlename.Size = New System.Drawing.Size(95, 18)
        Me.label_middlename.TabIndex = 4
        Me.label_middlename.Text = "Middle Name"
        '
        'label_surname
        '
        Me.label_surname.AutoSize = True
        Me.label_surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.label_surname.Location = New System.Drawing.Point(47, 316)
        Me.label_surname.Name = "label_surname"
        Me.label_surname.Size = New System.Drawing.Size(68, 18)
        Me.label_surname.TabIndex = 5
        Me.label_surname.Text = "Surname"
        '
        'textbox_studentno
        '
        Me.textbox_studentno.Location = New System.Drawing.Point(167, 121)
        Me.textbox_studentno.Name = "textbox_studentno"
        Me.textbox_studentno.Size = New System.Drawing.Size(152, 22)
        Me.textbox_studentno.TabIndex = 6
        '
        'textbox_firstname
        '
        Me.textbox_firstname.Location = New System.Drawing.Point(167, 190)
        Me.textbox_firstname.Name = "textbox_firstname"
        Me.textbox_firstname.Size = New System.Drawing.Size(152, 22)
        Me.textbox_firstname.TabIndex = 7
        '
        'textbox_middlename
        '
        Me.textbox_middlename.Location = New System.Drawing.Point(167, 251)
        Me.textbox_middlename.Name = "textbox_middlename"
        Me.textbox_middlename.Size = New System.Drawing.Size(152, 22)
        Me.textbox_middlename.TabIndex = 8
        '
        'textbox_lastname
        '
        Me.textbox_lastname.Location = New System.Drawing.Point(167, 315)
        Me.textbox_lastname.Name = "textbox_lastname"
        Me.textbox_lastname.Size = New System.Drawing.Size(152, 22)
        Me.textbox_lastname.TabIndex = 9
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(354, 368)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 10
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(510, 368)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 11
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(671, 368)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.textbox_lastname)
        Me.Controls.Add(Me.textbox_middlename)
        Me.Controls.Add(Me.textbox_firstname)
        Me.Controls.Add(Me.textbox_studentno)
        Me.Controls.Add(Me.label_surname)
        Me.Controls.Add(Me.label_middlename)
        Me.Controls.Add(Me.label_firstname)
        Me.Controls.Add(Me.label_studentno)
        Me.Controls.Add(Me.label_title)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Student Profile"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents label_title As Label
    Friend WithEvents label_studentno As Label
    Friend WithEvents label_firstname As Label
    Friend WithEvents label_middlename As Label
    Friend WithEvents label_surname As Label
    Friend WithEvents textbox_studentno As TextBox
    Friend WithEvents textbox_firstname As TextBox
    Friend WithEvents textbox_middlename As TextBox
    Friend WithEvents textbox_lastname As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
End Class
