<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmControleToolTipText
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
        Me.dgvTeste = New System.Windows.Forms.DataGridView()
        Me.lblExplicacao = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvTeste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTeste
        '
        Me.dgvTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeste.Location = New System.Drawing.Point(12, 12)
        Me.dgvTeste.Name = "dgvTeste"
        Me.dgvTeste.Size = New System.Drawing.Size(761, 157)
        Me.dgvTeste.TabIndex = 5
        '
        'lblExplicacao
        '
        Me.lblExplicacao.AutoSize = True
        Me.lblExplicacao.Location = New System.Drawing.Point(12, 182)
        Me.lblExplicacao.Name = "lblExplicacao"
        Me.lblExplicacao.Size = New System.Drawing.Size(492, 13)
        Me.lblExplicacao.TabIndex = 6
        Me.lblExplicacao.Text = "ATENÇÃO!!!  A Tooltip só aparece na coluna TOTAL (pare com o cursor em cima da cé" &
    "lula). As linhas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "1 - Tem o tratamento e foi passado originalmente o valor 10;"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(586, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "2 - Tem o tratamento e foi passado originalmente o valor 20. Mas NÃO tem efeito, " &
    "pois o tamanho do texto é menor que 20."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(359, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "3 - Por favor, veja que na linha 3 que NÃO tem tratamento de ToolTipText."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "4 - Tem o tratamento e foi passado originalmente o valor 40."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(289, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "5 - Tem o tratamento e foi passado originalmente o valor 50."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(611, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CURIOSIDADE!!!  O tamanho da quebra NÃO pode ser menor que a última palavra do te" &
    "xto. O tamanho de ""fica."" é igual a ""5""!"
        '
        'frmControleToolTipText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 337)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblExplicacao)
        Me.Controls.Add(Me.dgvTeste)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmControleToolTipText"
        Me.ShowIcon = False
        Me.Text = "Controle do tamanho da ToolTipText na DataGridView"
        CType(Me.dgvTeste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTeste As System.Windows.Forms.DataGridView
    Friend WithEvents lblExplicacao As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
