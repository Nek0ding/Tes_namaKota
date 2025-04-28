<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        input_kota = New TextBox()
        list_kota = New ListBox()
        btn_tambah = New Button()
        btn_hapus = New Button()
        btn_bersih = New Button()
        btn_jumlah = New Button()
        output_jumlah = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama nama Kota"
        ' 
        ' input_kota
        ' 
        input_kota.Location = New Point(346, 56)
        input_kota.Name = "input_kota"
        input_kota.Size = New Size(169, 31)
        input_kota.TabIndex = 1
        ' 
        ' list_kota
        ' 
        list_kota.FormattingEnabled = True
        list_kota.ItemHeight = 25
        list_kota.Location = New Point(98, 138)
        list_kota.Name = "list_kota"
        list_kota.Size = New Size(267, 229)
        list_kota.TabIndex = 2
        ' 
        ' btn_tambah
        ' 
        btn_tambah.Location = New Point(438, 137)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(198, 61)
        btn_tambah.TabIndex = 3
        btn_tambah.Text = "Tambah"
        btn_tambah.UseVisualStyleBackColor = True
        ' 
        ' btn_hapus
        ' 
        btn_hapus.Location = New Point(438, 220)
        btn_hapus.Name = "btn_hapus"
        btn_hapus.Size = New Size(198, 61)
        btn_hapus.TabIndex = 4
        btn_hapus.Text = "Hapus"
        btn_hapus.UseVisualStyleBackColor = True
        ' 
        ' btn_bersih
        ' 
        btn_bersih.Location = New Point(438, 306)
        btn_bersih.Name = "btn_bersih"
        btn_bersih.Size = New Size(198, 61)
        btn_bersih.TabIndex = 5
        btn_bersih.Text = "Bersih"
        btn_bersih.UseVisualStyleBackColor = True
        ' 
        ' btn_jumlah
        ' 
        btn_jumlah.Location = New Point(98, 382)
        btn_jumlah.Name = "btn_jumlah"
        btn_jumlah.Size = New Size(149, 46)
        btn_jumlah.TabIndex = 6
        btn_jumlah.Text = "Jumlah"
        btn_jumlah.UseVisualStyleBackColor = True
        ' 
        ' output_jumlah
        ' 
        output_jumlah.Location = New Point(269, 390)
        output_jumlah.Name = "output_jumlah"
        output_jumlah.ReadOnly = True
        output_jumlah.Size = New Size(96, 31)
        output_jumlah.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(output_jumlah)
        Controls.Add(btn_jumlah)
        Controls.Add(btn_bersih)
        Controls.Add(btn_hapus)
        Controls.Add(btn_tambah)
        Controls.Add(list_kota)
        Controls.Add(input_kota)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents input_kota As TextBox
    Friend WithEvents list_kota As ListBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_bersih As Button
    Friend WithEvents btn_jumlah As Button
    Friend WithEvents output_jumlah As TextBox

End Class
