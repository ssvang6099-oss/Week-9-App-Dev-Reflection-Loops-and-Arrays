Option Strict On

Module Week9LoopsAndArrays

    Sub Main()
        Dim storyChoices() As String = {
            "Ask Discord for a clue",
            "Read the documentation",
            "Test the code again",
            "Update the README"
        }

        Dim keepPlaying As Boolean = True
        Dim chosenHistory As New List(Of String)

        Do While keepPlaying
            Console.Clear()
            Console.WriteLine("Week 9 Mini Menu")
            Console.WriteLine("----------------")

            ' For...Next is useful when you need the array index.
            For index As Integer = 0 To storyChoices.Length - 1
                Console.WriteLine($"{index + 1}. {storyChoices(index)}")
            Next

            Console.WriteLine("0. Exit")
            Console.WriteLine()
            Console.Write("Choose an option: ")

            Dim userInput As String = Console.ReadLine()
            Dim choiceNumber As Integer

            If Integer.TryParse(userInput, choiceNumber) Then
                If choiceNumber = 0 Then
                    keepPlaying = False
                ElseIf choiceNumber >= 1 AndAlso choiceNumber <= storyChoices.Length Then
                    Dim selectedChoice As String = storyChoices(choiceNumber - 1)
                    chosenHistory.Add(selectedChoice)

                    Console.WriteLine()
                    Console.WriteLine($"You chose: {selectedChoice}")
                    Console.WriteLine("Press ENTER to return to the menu.")
                    Console.ReadLine()
                Else
                    ShowInputError()
                End If
            Else
                ShowInputError()
            End If
        Loop

        ShowHistory(chosenHistory)
    End Sub

    Sub ShowInputError()
        Console.WriteLine()
        Console.WriteLine("That choice is not valid. Press ENTER and try again.")
        Console.ReadLine()
    End Sub

    Sub ShowHistory(history As List(Of String))
        Console.Clear()
        Console.WriteLine("Session Recap")
        Console.WriteLine("-------------")

        If history.Count = 0 Then
            Console.WriteLine("No choices were selected.")
        Else
            ' For Each is useful when you need each item and do not need the index.
            For Each item As String In history
                Console.WriteLine($"- {item}")
            Next
        End If

        Console.WriteLine()
        Console.WriteLine("Press ENTER to close.")
        Console.ReadLine()
    End Sub

End Module
