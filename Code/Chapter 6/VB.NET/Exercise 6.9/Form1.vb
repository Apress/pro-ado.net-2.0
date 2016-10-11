
Public Class Form1
    Private books As BookDataSet
    Private Sub btnSumScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumScores.Click
        Dim sum As Integer = 0
        Dim Book As BookDataSet.Book
        For Each Book In books.Books
            Dim Review As BookDataSet.BookReview
            For Each Review In Book.Reviews()
                sum += CType(Review.Rating, Integer)
            Next
        Next

        MessageBox.Show(Me, "Score Total: " + sum.ToString())
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        books = New BookDataSet()
        books.ReadXml("Books.xml")
        dgBooks.DataSource = books.Books
    End Sub
End Class
