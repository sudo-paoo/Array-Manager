Public Class FunctionsClass
    Private _arrayObj As ArrayClass

    Public Sub New(arrayObj As ArrayClass)
        _arrayObj = arrayObj
    End Sub

    Public Function Add(value As Integer) As Boolean
        If _arrayObj.Count < _arrayObj.Size Then
            _arrayObj.AddElement(value)
            Return True
        End If
        Return False
    End Function

    Public Function Add(values As String) As Integer
        Dim addedCount As Integer = 0
        Dim valuesToAdd As String() = values.Split(","c)

        For Each valueStr As String In valuesToAdd
            Dim value As Integer
            If Integer.TryParse(valueStr.Trim(), value) Then
                If Add(value) Then
                    addedCount += 1
                End If
            End If
        Next

        Return addedCount
    End Function

    Public Function Find(value As Integer) As Integer
        Return _arrayObj.FindElement(value)
    End Function

    Public Function FindAll(value As Integer) As List(Of Integer)
        Return _arrayObj.FindAllElements(value)
    End Function

    Public Function Delete(value As Integer) As Boolean
        Return _arrayObj.DeleteElement(value)
    End Function

    Public Function DeleteAll(value As Integer) As Integer
        Return _arrayObj.DeleteAllElements(value)
    End Function

    Public Sub Reset()
        _arrayObj.Reset()
    End Sub
End Class