Class MainWindow

    Dim gamePlay As Boolean = True

    Private Sub btnLoop_Click(sender As Object, e As RoutedEventArgs) Handles btnLoop.Click

        Dim Rnd As New Random
        Dim intRandomNum As Integer = 0

        lstData.Items.Clear()

        ' Do Until intRandomNum = 10
        '     intRandomNum = Rnd.Next(25)
        '     lstData.Items.Add(intRandomNum.ToString())
        'Loop

        Do While intRandomNum < 15

            intRandomNum = Rnd.Next(25)
            lstData.Items.Add(intRandomNum.ToString())

        Loop


    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click

        lstData.Items.Clear()
        txtData.Text = "Good Job"


    End Sub
End Class
