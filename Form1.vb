Public Class Form1
    Private arrayObj As ArrayClass
    Private functions As FunctionsClass

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(650, 180)
        pnlSetArraySize.BringToFront()
    End Sub

    Private Sub btnInitializeArray_Click(sender As Object, e As EventArgs) Handles btnInitializeArray.Click
        Dim size As Integer
        If Integer.TryParse(txtArraySize.Text, size) AndAlso size > 0 Then
            arrayObj = New ArrayClass(size)
            functions = New FunctionsClass(arrayObj)

            Me.Size = New Size(650, 750)
            pnlSetArraySize.Visible = False

            ' Enable controls for array operations
            EnableArrayControls(True)

            ' Clear the listbox
            lbxValues.Items.Clear()
        Else
            MessageBox.Show("Please enter a valid positive integer for array size.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EnableArrayControls(enable As Boolean)
        txtAdd.Enabled = enable
        btnAdd.Enabled = enable
        txtFind.Enabled = enable
        btnFind.Enabled = False ' Enable only when text is entered
        btnFindAll.Enabled = False ' Enable only when text is entered
        txtDelete.Enabled = enable
        btnDelete.Enabled = False ' Enable only when text is entered or item selected
        btnDeleteAll.Enabled = False ' Enable only when text is entered or item selected
        btnReset.Enabled = enable
    End Sub

    Private Sub NumericTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArraySize.KeyPress, txtAdd.KeyPress, txtFind.KeyPress, txtDelete.KeyPress
        ' Allow only digits, commas, and control characters
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ","c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        btnFind.Enabled = Not String.IsNullOrEmpty(txtFind.Text)
        btnFindAll.Enabled = Not String.IsNullOrEmpty(txtFind.Text)
    End Sub

    Private Sub txtDelete_TextChanged(sender As Object, e As EventArgs) Handles txtDelete.TextChanged
        btnDelete.Enabled = Not String.IsNullOrEmpty(txtDelete.Text)
        btnDeleteAll.Enabled = Not String.IsNullOrEmpty(txtDelete.Text)
    End Sub

    Private Sub lbxValues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxValues.SelectedIndexChanged
        btnDelete.Enabled = lbxValues.SelectedIndex >= 0
        btnDeleteAll.Enabled = lbxValues.SelectedIndex >= 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not String.IsNullOrEmpty(txtAdd.Text) Then
            Dim addedCount As Integer = functions.Add(txtAdd.Text)

            ' Update the listbox
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

            ' Clear any previous selections
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

            ' Clear any previous selections
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
        ElseIf lbxValues.SelectedIndex >= 0 Then
            Dim index As Integer = lbxValues.SelectedIndex
            Dim value As Integer = CInt(lbxValues.Items(index))

            If functions.Delete(value) Then
                MessageBox.Show($"Element at index {index} deleted successfully.", "Delete Element", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateListBox()
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
        functions.Reset()
        UpdateListBox()

        ' Go back to initial state
        Me.Size = New Size(650, 180)
        pnlSetArraySize.Visible = True
        pnlSetArraySize.BringToFront()

        ' Disable controls for array operations
        EnableArrayControls(False)

        ' Clear all textboxes
        txtArraySize.Clear()
        txtAdd.Clear()
        txtFind.Clear()
        txtDelete.Clear()
    End Sub

    Private Sub UpdateListBox()
        lbxValues.Items.Clear()

        For i As Integer = 0 To arrayObj.Count - 1
            lbxValues.Items.Add(arrayObj.Values(i))
        Next
    End Sub
End Class