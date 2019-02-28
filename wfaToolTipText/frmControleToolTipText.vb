Imports clsDataGridView

Public Class frmControleToolTipText

    Private Sub frmControleToolTipText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populei a grade com alguma coisa...
        PopularGrade()
    End Sub

    ''' <summary>
    ''' Essa Sub (PopularGrade) é somente para carregar algum texto na DataGridView.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PopularGrade()
        Dim lDados1 As New List(Of clsDados)()

        lDados1.Add(New clsDados(False, 1, "Nessa linha o tamanho da quebra original é 10", "Pare com o cursor em cima da célula TOTAL ->", 10))
        lDados1.Add(New clsDados(False, 2, "Não precisa de tratamento (texto menor que o valor passado)", "Pare com o cursor em cima da célula TOTAL ->", 20))
        lDados1.Add(New clsDados(False, 3, "NÃO TEM TRATAMENTO!", "Pare com o cursor em cima da célula TOTAL ->", 30))
        lDados1.Add(New clsDados(False, 4, "Nessa linha o tamanho da quebra original é 40", "Pare com o cursor em cima da célula TOTAL ->", 40))
        lDados1.Add(New clsDados(False, 5, "Nessa linha o tamanho da quebra original é 50", "Experimente trocar 50 para 8 (por exemplo) ->", 50))

        dgvTeste.DataSource = lDados1

        dgvTeste.Columns(0).Width = 70
        dgvTeste.Columns(1).Width = 30
        dgvTeste.Columns(2).Width = 300
        dgvTeste.Columns(3).Width = 250
        dgvTeste.Columns(4).Width = 50
    End Sub

    ''' <summary>
    ''' Esse EVENTO coloca as ToolTipTexts na coluna TOTAL
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvTeste_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTeste.CellFormatting
        Const constTextoPadrao = "Aqui quero escrever um texto longo, mas bem longo nessa célula. Precisamos achar um ponto de quebra adequado, será que funcionou? Com certeza! Veja como fica."

        'O tamanho de "fica." é igual a "5"!
        'Abaixo o "ponto" (.) está separado da última palavra por um espaço!!!
        Const constTextoPadrao2 = "Aqui quero escrever um texto médio. Veja como fica ."
        'Aqui NÃO tem ponto!!!
        Const constTextoPadrao3 = "Aqui quero escrever um texto médio. Veja como fica"

        If e.ColumnIndex = Me.dgvTeste.Columns("total").Index AndAlso (e.Value IsNot Nothing) Then

            With Me.dgvTeste.Rows(e.RowIndex).Cells(e.ColumnIndex)

                If e.Value.Equals(10) Then
                    .ToolTipText = AjustaTamanhoToolTipText(constTextoPadrao, e.Value)
                ElseIf e.Value.Equals(20) Then
                    .ToolTipText = AjustaTamanhoToolTipText("texto curto", e.Value)
                ElseIf e.Value.Equals(30) Then
                    .ToolTipText = constTextoPadrao
                ElseIf e.Value.Equals(3) Then
                    .ToolTipText = AjustaTamanhoToolTipText(constTextoPadrao3, e.Value)
                ElseIf e.Value < 6 Then
                    .ToolTipText = AjustaTamanhoToolTipText(constTextoPadrao2, e.Value)
                Else
                    .ToolTipText = AjustaTamanhoToolTipText(constTextoPadrao, e.Value)
                End If

            End With

        End If

    End Sub

    ''' <summary>
    ''' Essa é função de ajuste de tamanho da TooTipText
    ''' </summary>
    ''' <param name="strTextoOriginal">Recebe o texto original sem tratamento de quebra</param>
    ''' <param name="intValorFixo">Recebe o valor estimado para quebra</param>
    ''' <returns>Retorna o texto com a inserção de pontos de quebra para ser exibido.</returns>
    ''' <remarks>Você precisa informar o texto e onde voc~e quer que quebre...</remarks>
    Public Function AjustaTamanhoToolTipText(strTextoOriginal As String, intValorFixo As Integer) As String
        Dim strTextoFinal As String = ""
        Dim intPosicaoInicial = 0
        Dim intTamanhoTexto = strTextoOriginal.Length()
        Dim intPosicaoEspaco = intValorFixo

        'Se o texto for menor que o tamanho de quebra, somente devolve o texto intacto.
        If intTamanhoTexto <= intValorFixo Then
            strTextoFinal = strTextoOriginal
        Else
            'Se o texto da última PALAVRA for menor que o tamanho de quebra, ajuste a quebra para o tamanho dessa palavra.
            If (strTextoOriginal.Length - strTextoOriginal.LastIndexOf(" ", strTextoOriginal.Length)) > intValorFixo Then intValorFixo = (strTextoOriginal.Length - strTextoOriginal.LastIndexOf(" ", strTextoOriginal.Length))

            While intTamanhoTexto > intValorFixo
                intPosicaoEspaco = strTextoOriginal.IndexOf(" ", intPosicaoEspaco)

                If intPosicaoEspaco <= 0 Then Exit While

                strTextoFinal = strTextoFinal + strTextoOriginal.Substring(intPosicaoInicial, intPosicaoEspaco - intPosicaoInicial).TrimStart() + vbCrLf

                intPosicaoInicial = intPosicaoEspaco
                intTamanhoTexto = strTextoOriginal.Length() - intPosicaoInicial

                If intValorFixo < intTamanhoTexto Then
                    intPosicaoEspaco = intPosicaoEspaco + intValorFixo
                Else
                    strTextoFinal = strTextoFinal + strTextoOriginal.Substring(intPosicaoInicial, intTamanhoTexto).TrimStart()
                End If

            End While

        End If

        Return strTextoFinal
    End Function

End Class
