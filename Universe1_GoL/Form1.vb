Public Class Form1
    Const MAX_SIZE As Integer = 300
    Dim generation As Integer = 0
    Dim numbOfCellsInRow As Integer
    Dim numbOfCellsInCol As Integer
    Dim cell(MAX_SIZE, MAX_SIZE) As Cells
    Dim isRunning As Boolean
    Dim background As Rectangle
    Dim cellRectangle(MAX_SIZE, MAX_SIZE) As Rectangle
    Const TOP_BORDER As Integer = 30
    Const RIGHT_BORDER As Integer = 95
    Public cellSize As Integer = 20
    Dim gridWidth As Integer 'this number is the number of pixels the grid is wide
    Dim gridHeight As Integer 'this number is the number of pixels the grid is tall
    Dim extraWidthPixels As Integer 'This number will store the number of cells we need to make one pixel wider to make the grid fit
    Dim extraHeightPixels As Integer 'This number will store the number of cells we need to make one pixel taller to make the grid fit
    Dim states(100, MAX_SIZE, MAX_SIZE) As Boolean

    Public Function modulus(ByVal x As Integer, ByVal y As Integer) As Integer
        If (x = 0) Then
            Return y
        ElseIf (x > y) Then
            Return 1
        Else : Return x
        End If
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i = 1 To MAX_SIZE
            For j = 1 To MAX_SIZE
                cell(i, j) = New Cells
                cellRectangle(i, j) = New Rectangle
            Next
        Next
        Call createGrid()
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If (e.X > 0 And e.X < gridWidth - TOP_BORDER And e.Y > TOP_BORDER And e.Y < (TOP_BORDER + gridHeight)) Then
            Dim Col, Row As Integer
            If e.X > (cellSize + 1) * extraWidthPixels Then
                Col = Int((CInt(e.X) - (cellSize + 1) * extraWidthPixels) / cellSize) + extraWidthPixels + 1
            Else
                Col = Int(CInt(Int(e.X / (cellSize + 1)))) + 1
            End If
            If e.Y > (cellSize + 1) * extraHeightPixels + TOP_BORDER Then
                Row = Int((CInt(e.Y - TOP_BORDER) - (cellSize + 1) * extraHeightPixels) / cellSize) + extraHeightPixels + 1
            Else
                Row = CInt(Int((e.Y - TOP_BORDER) / (cellSize + 1))) + 1
            End If
            Try
                cell(Row, Col).Alive = Not cell(Row, Col).Alive
            Catch ex As Exception
            End Try
            Invalidate()
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If (e.X > 0 And e.X < gridWidth And e.Y > TOP_BORDER And e.Y < (TOP_BORDER + gridHeight)) Then
            Dim Col, Row As Integer
            If e.X > (cellSize + 1) * extraWidthPixels Then
                Col = Int((CInt(e.X) - (cellSize + 1) * extraWidthPixels) / cellSize) + extraWidthPixels + 1
            Else
                Col = Int(CInt(Int(e.X / (cellSize + 1)))) + 1
            End If
            If e.Y > (cellSize + 1) * extraHeightPixels + TOP_BORDER Then
                Row = Int((CInt(e.Y - TOP_BORDER) - (cellSize + 1) * extraHeightPixels) / cellSize) + extraHeightPixels + 1
            Else
                Row = CInt(Int((e.Y - TOP_BORDER) / (cellSize + 1))) + 1
            End If
            If e.Button = Windows.Forms.MouseButtons.Left Then
                cell(Row, Col).Alive = True
            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                cell(Row, Col).Alive = False
            End If
            Invalidate()
        End If
    End Sub

    Private Sub btnOnOff_Click(sender As System.Object, e As System.EventArgs) Handles btnOnOff.Click
        isRunning = Not isRunning
        If isRunning = True Then
            btnOnOff.Text = "Pause"
            Timer.Start()
        Else
            btnOnOff.Text = "Go"
            Timer.Stop()
        End If
    End Sub

    Private Sub btnStep_Click(sender As System.Object, e As System.EventArgs) Handles btnStep.Click
        Call Tick()
    End Sub

    Private Sub btnClearGrid_Click(sender As System.Object, e As System.EventArgs) Handles btnClearGrid.Click
        For i = 1 To MAX_SIZE
            For j = 1 To MAX_SIZE
                cell(i, j).Alive = False
            Next
        Next
        For h = 0 To 100
            For i = 0 To MAX_SIZE
                For j = 0 To MAX_SIZE
                    states(h, i, j) = False
                Next
            Next
        Next
        generation = 0
        lblGeneration.Text = generation.ToString()
        Invalidate()
        isRunning = False
        btnOnOff.Text = "Go"
        Timer.Stop()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles scrollBarSpeed.Scroll
        Timer.Interval = CInt(5000 / CDec(scrollBarSpeed.Value))
        If scrollBarSpeed.Value < 2 Then
            Timer.Stop()
        Else
            If isRunning = True Then Timer.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        Tick()
    End Sub

    Sub Tick()
        For i = 1 To numbOfCellsInCol
            For j = 1 To numbOfCellsInRow
                Try
                    states(CInt(generation Mod 100), i, j) = cell(i, j).Alive
                Catch ex As Exception
                End Try
            Next
        Next 'captures previous state and saves before overwriting
        Dim count As Integer
        Dim Row, Col As Integer
        Dim counterVert As Integer
        Dim counterHorz As Integer
        For i = 1 To numbOfCellsInCol
            For j = 1 To numbOfCellsInRow
                count = 0
                If cell(i, j).Alive = True Then
                    count -= 1
                    For counterVert = -1 To 1
                        Col = modulus((i + counterVert), numbOfCellsInCol)
                        For counterHorz = -1 To 1
                            Row = modulus((j + counterHorz), numbOfCellsInRow)
                            If cell(Col, Row).Alive = True Then
                                count += 1
                            End If
                        Next
                    Next
                    If count = 0 Then
                        If stayAlive0.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 1 Then
                        If stayAlive1.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 2 Then
                        If StayAlive2.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 3 Then
                        If stayAlive3.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 4 Then
                        If stayAlive4.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 5 Then
                        If stayAlive5.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 6 Then
                        If stayAlive6.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 7 Then
                        If stayAlive7.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 8 Then
                        If stayAlive8.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                Else
                    For counterVert = -1 To 1
                        Col = modulus((i + counterVert), numbOfCellsInCol)
                        For counterHorz = -1 To 1
                            Row = modulus((j + counterHorz), numbOfCellsInRow)
                            If cell(Col, Row).Alive = True Then
                                count += 1
                            End If
                        Next
                    Next
                    If count = 1 Then
                        If TurnOn1.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 2 Then
                        If TurnOn2.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 3 Then
                        If TurnOn3.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 4 Then
                        If TurnOn4.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 5 Then
                        If TurnOn5.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 6 Then
                        If TurnOn6.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 7 Then
                        If TurnOn7.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                    If count = 8 Then
                        If TurnOn8.Checked = True Then
                            cell(i, j).tempAlive = True
                        Else
                            cell(i, j).tempAlive = False
                        End If
                    End If
                End If
            Next
        Next
        For i = 1 To numbOfCellsInCol
            For j = 1 To numbOfCellsInRow
                cell(i, j).Alive = cell(i, j).tempAlive
                cell(i, j).tempAlive = False
            Next
        Next
        'MessageBox.Show((CInt(generation Mod 100)).ToString())
        generation += 1
        lblGeneration.Text = generation.ToString()
        Invalidate() 'causes redraw
    End Sub

    Sub createGrid() 'creates grid of rectangles
        Dim X, Y As Double
        X = 1 : Y = TOP_BORDER
        gridWidth = Me.Width - RIGHT_BORDER - 9
        gridHeight = Me.Height - TOP_BORDER - 19 - 9
        background = New Rectangle(-1, TOP_BORDER - 1, gridWidth + 2, gridHeight + 1)
        numbOfCellsInRow = Int(gridWidth / cellSize)
        extraWidthPixels = (gridWidth - cellSize * numbOfCellsInRow)
        numbOfCellsInCol = Int(gridHeight / cellSize)
        extraHeightPixels = gridHeight - cellSize * numbOfCellsInCol
        For i = 1 To extraHeightPixels
            For j = 1 To extraWidthPixels
                cellRectangle(i, j) = New Rectangle(CInt(X), CInt(Y), cellSize, cellSize)
                X += (cellSize + 1)
            Next
            For j = extraWidthPixels + 1 To numbOfCellsInRow
                cellRectangle(i, j) = New Rectangle(CInt(X), CInt(Y), cellSize - 1, cellSize)
                X += cellSize
            Next
            X = 1
            Y += (cellSize + 1)
        Next
        For i = extraHeightPixels + 1 To numbOfCellsInCol
            For j = 1 To extraWidthPixels
                cellRectangle(i, j) = New Rectangle(CInt(X), CInt(Y), cellSize, cellSize - 1)
                X += (cellSize + 1)
            Next
            For j = extraWidthPixels + 1 To numbOfCellsInRow
                cellRectangle(i, j) = New Rectangle(CInt(X), CInt(Y), cellSize - 1, cellSize - 1)
                X += cellSize
            Next
            X = 1
            Y += (cellSize)
        Next
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.FillRectangle(Brushes.DimGray, background)
        For i = 1 To numbOfCellsInCol
            For j = 1 To numbOfCellsInRow
                If cell(i, j).Alive = True Then
                    e.Graphics.FillRectangle(Brushes.Black, cellRectangle(i, j)) 'paints living cells
                Else
                    e.Graphics.FillRectangle(Brushes.White, cellRectangle(i, j)) 'paints dead cells
                End If
            Next
        Next
    End Sub

    Private Sub Size_ValueChanged(sender As Object, e As EventArgs) Handles scrollCellSize.ValueChanged
        cellSize = CInt(CUShort(scrollCellSize.Value))
        Call createGrid()
        Invalidate()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Invalidate()
        createGrid()
    End Sub

    Private Sub btnStepBack_Click(sender As Object, e As EventArgs) Handles btnStepBack.Click
        'MessageBox.Show((CInt(generation Mod 100 - 1)).ToString())
        Try
            For i = 1 To numbOfCellsInCol
                For j = 1 To numbOfCellsInRow
                    cell(i, j).Alive = states(CInt((generation - 1) Mod 100), i, j)
                Next
            Next
            Invalidate()
            generation -= 1
            lblGeneration.Text = generation.ToString()
        Catch ex As Exception

        End Try
    End Sub
End Class

Class Cells
    Public Property Alive As Boolean
    Public Property tempAlive As Boolean
End Class

