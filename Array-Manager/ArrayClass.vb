Public Class ArrayClass
    Private _values As Integer()
    Private _count As Integer = 0

    Public Sub New(size As Integer)
        _values = New Integer(size - 1) {}
    End Sub

    Public ReadOnly Property Values As Integer()
        Get
            Return _values
        End Get
    End Property

    Public ReadOnly Property Count As Integer
        Get
            Return _count
        End Get
    End Property

    Public ReadOnly Property Size As Integer
        Get
            Return _values.Length
        End Get
    End Property

    Public Sub AddElement(value As Integer)
        If _count < _values.Length Then
            _values(_count) = value
            _count += 1
        End If
    End Sub

    Public Function FindElement(value As Integer) As Integer
        For i As Integer = 0 To _count - 1
            If _values(i) = value Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function FindAllElements(value As Integer) As List(Of Integer)
        Dim indices As New List(Of Integer)
        For i As Integer = 0 To _count - 1
            If _values(i) = value Then
                indices.Add(i)
            End If
        Next
        Return indices
    End Function

    Public Function DeleteElement(value As Integer) As Boolean
        Dim index As Integer = FindElement(value)
        If index >= 0 Then
            For i As Integer = index To _count - 2
                _values(i) = _values(i + 1)
            Next
            _count -= 1
            Return True
        End If
        Return False
    End Function

    Public Function DeleteAllElements(value As Integer) As Integer
        Dim deletedCount As Integer = 0
        While DeleteElement(value)
            deletedCount += 1
        End While
        Return deletedCount
    End Function

    Public Sub Reset()
        _count = 0
    End Sub
End Class