Public Class Form1
    Private arrayObj As ArrayClass
    Private functions As FunctionsClass

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(650, 250)
        txtArraySize.Focus()
        Me.CenterToParent()
        pnlSetArraySize.BringToFront()
    End Sub

    Private Sub btnInitializeArray_Click(sender As Object, e As EventArgs) Handles btnInitializeArray.Click
        Dim size As Integer
        If Integer.TryParse(txtArraySize.Text, size) AndAlso size > 0 Then
            arrayObj = New ArrayClass(size)
            functions = New FunctionsClass(arrayObj)

            Me.Size = New Size(650, 750)
            Me.CenterToParent()
            pnlSetArraySize.Visible = False

            EnableArrayControls(True)

            lbxValues.Items.Clear()
            UpdateArraySizeLabel()
        Else
            MessageBox.Show("Please enter a valid positive integer for array size.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EnableArrayControls(enable As Boolean)
        txtAdd.Enabled = enable
        btnAdd.Enabled = enable
        txtFind.Enabled = enable
        btnFind.Enabled = False
        btnFindAll.Enabled = False
        txtDelete.Enabled = enable
        btnDelete.Enabled = False
        btnDeleteAll.Enabled = False
        btnReset.Enabled = enable
    End Sub

    Private Sub NumericTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArraySize.KeyPress, txtAdd.KeyPress, txtFind.KeyPress, txtDelete.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ","c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        btnFind.Enabled = Not String.IsNullOrEmpty(txtFind.Text)
        btnFindAll.Enabled = Not String.IsNullOrEmpty(txtFind.Text)
    End Sub

    Private Sub txtDelete_TextChanged(sender As Object, e As EventArgs) Handles txtDelete.TextChanged
        Dim hasText = Not String.IsNullOrEmpty(txtDelete.Text)
        btnDelete.Enabled = hasText
        btnDeleteAll.Enabled = hasText AndAlso Not txtDelete.Text.Contains(",")
    End Sub

    Private Sub lbxValues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxValues.SelectedIndexChanged
        btnDelete.Enabled = lbxValues.SelectedIndices.Count > 0
        btnDeleteAll.Enabled = lbxValues.SelectedIndices.Count = 1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not String.IsNullOrEmpty(txtAdd.Text) Then
            Dim addedCount As Integer = functions.Add(txtAdd.Text)

            UpdateListBox()

            If addedCount > 0 Then
                MessageBox.Show($"{addedCount} element(s) added successfully.", "Add Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAdd.Clear()
            Else
                MessageBox.Show("Could not add elements. Array might be full.", "Add Elements", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim value As Integer
        If Integer.TryParse(txtFind.Text, value) Then
            Dim index As Integer = functions.Find(value)

            lbxValues.ClearSelected()

            If index >= 0 Then
                lbxValues.SelectedIndex = index
                MessageBox.Show($"Element {value} found at index {index}.", "Find Element", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show($"Element {value} does not exist in the array.", "Find Element", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnFindAll_Click(sender As Object, e As EventArgs) Handles btnFindAll.Click
        Dim value As Integer
        If Integer.TryParse(txtFind.Text, value) Then
            Dim indices As List(Of Integer) = functions.FindAll(value)

            lbxValues.ClearSelected()

            If indices.Count > 0 Then
                For Each index As Integer In indices
                    lbxValues.SetSelected(index, True)
                Next
                MessageBox.Show($"Element {value} found at indices: {String.Join(", ", indices)}", "Find All Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show($"Element {value} does not exist in the array.", "Find All Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not String.IsNullOrEmpty(txtDelete.Text) Then
            If txtDelete.Text.Contains(",") Then
                Dim valuesToDelete As String() = txtDelete.Text.Split(","c)
                Dim deletedCount As Integer = 0

                For Each valueStr As String In valuesToDelete
                    Dim value As Integer
                    If Integer.TryParse(valueStr.Trim(), value) Then
                        If functions.Delete(value) Then
                            deletedCount += 1
                        End If
                    End If
                Next

                If deletedCount > 0 Then
                    MessageBox.Show($"{deletedCount} element(s) deleted successfully.", "Delete Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateListBox()
                    txtDelete.Clear()
                Else
                    MessageBox.Show("None of the specified elements exist in the array.", "Delete Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Dim value As Integer
                If Integer.TryParse(txtDelete.Text, value) Then
                    If functions.Delete(value) Then
                        MessageBox.Show($"Element {value} deleted successfully.", "Delete Element", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        UpdateListBox()
                        txtDelete.Clear()
                    Else
                        MessageBox.Show($"Element {value} does not exist in the array.", "Delete Element", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        ElseIf lbxValues.SelectedIndices.Count > 0 Then
            Dim selectedItems As New List(Of Object)
            For i As Integer = lbxValues.SelectedIndices.Count - 1 To 0 Step -1
                selectedItems.Add(lbxValues.Items(lbxValues.SelectedIndices(i)))
            Next

            Dim deletedCount As Integer = 0

            For Each item In selectedItems
                Dim value As Integer = CInt(item)
                If functions.Delete(value) Then
                    deletedCount += 1
                End If
            Next

            If deletedCount > 0 Then
                MessageBox.Show($"{deletedCount} selected element(s) deleted successfully.", "Delete Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateListBox()
            Else
                MessageBox.Show("Failed to delete selected elements.", "Delete Elements", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        If Not String.IsNullOrEmpty(txtDelete.Text) Then
            Dim value As Integer
            If Integer.TryParse(txtDelete.Text, value) Then
                Dim deletedCount As Integer = functions.DeleteAll(value)

                If deletedCount > 0 Then
                    MessageBox.Show($"{deletedCount} occurrences of element {value} deleted successfully.", "Delete All Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateListBox()
                    txtDelete.Clear()
                Else
                    MessageBox.Show($"Element {value} does not exist in the array.", "Delete All Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        ElseIf lbxValues.SelectedIndices.Count > 0 Then
            Dim selectedValues As New List(Of Integer)

            For Each index As Integer In lbxValues.SelectedIndices
                selectedValues.Add(CInt(lbxValues.Items(index)))
            Next

            Dim deletedCount As Integer = 0
            For Each value As Integer In selectedValues
                deletedCount += functions.DeleteAll(value)
            Next

            If deletedCount > 0 Then
                MessageBox.Show($"{deletedCount} elements deleted successfully.", "Delete All Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateListBox()
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to reset the system? This will clear all array data.", "Confirm Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        ' if the user confirms
        If result = DialogResult.OK Then
            functions.Reset()
            UpdateListBox()

            Me.Size = New Size(650, 250)
            Me.CenterToParent()
            pnlSetArraySize.Visible = True
            pnlSetArraySize.BringToFront()
            pnlSettings.SendToBack()

            EnableArrayControls(False)

            txtArraySize.ResetText()
            txtAdd.Clear()
            txtFind.Clear()
            txtDelete.Clear()

            lblArraySize.Text = "0 / 0"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        ' if the user confirms
        If result = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        pnlSettings.BringToFront()
    End Sub

    Private Sub btnCloseSettings_Click(sender As Object, e As EventArgs) Handles btnCloseSettings.Click
        pnlSettings.SendToBack()
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNone.CheckedChanged, rbtnAscending.CheckedChanged, rbtnDescending.CheckedChanged
        If Not TypeOf sender Is RadioButton Then Return

        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If rb.Checked Then
            pnlSettings.SendToBack()
            UpdateListBoxDisplay()
        End If
    End Sub

    Private Sub UpdateListBoxDisplay()
        lbxValues.Items.Clear()

        Dim displayValues As New List(Of Integer)
        For i As Integer = 0 To arrayObj.Count - 1
            displayValues.Add(arrayObj.Values(i))
        Next

        If rbtnAscending.Checked Then
            displayValues.Sort()
            icnOrder.IconChar = FontAwesome.Sharp.IconChar.ArrowUp
        ElseIf rbtnDescending.Checked Then
            displayValues.Sort()
            displayValues.Reverse()
            icnOrder.IconChar = FontAwesome.Sharp.IconChar.ArrowDown
        ElseIf rbtnNone.Checked Then
            icnOrder.IconChar = FontAwesome.Sharp.IconChar.Slash
        End If

        For Each value As Integer In displayValues
            lbxValues.Items.Add(value)
        Next

        UpdateArraySizeLabel()
    End Sub

    Private Sub UpdateArraySizeLabel()
        If arrayObj IsNot Nothing Then
            lblArraySize.Text = $"{arrayObj.Count} / {arrayObj.Size}"
        Else
            lblArraySize.Text = "0 / 0"
        End If
    End Sub

    Private Sub UpdateListBox()
        UpdateListBoxDisplay()
    End Sub
End Class