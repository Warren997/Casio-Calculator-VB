Public Class Form1

    Dim sign, textClear As String
    Dim num1, num2, mStore, mPlus, mMinus, nPositive As Double
    Dim isInteger As Integer


    'Font

    'Dim font1 As Font = New Font(Me.Font.FontFamily, Me.FontHeight + 1, FontStyle.Regular) 'Font for syntax error
    'Dim font2 As Font = New Font(Me.Font.FontFamily, Me.FontHeight + 3, FontStyle.Regular) 'Font for syntax error
    '--------------------------------Font Family        Font Size           Font Style



    'Buttons

    'Zero
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    'One
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    'Two
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    'Three
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    'Four
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    'Five
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    'Six
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    'Seven
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    'Eight
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    'Nine
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub


    'Decimal
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click

        If (Integer.TryParse(TextBox1.Text, isInteger)) Then 'Check If Number is Integer // For Decimal // Dont allow many decimal dots
            TextBox1.Text = TextBox1.Text & "."
        Else
            TextBox1.Text = TextBox1.Text & ""
        End If
    End Sub


    'Operations Button


    'Addition
    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click

        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            num1 = TextBox1.Text
            sign = "+"
            TextBox1.Text = ""
        End If
    End Sub


    'Subtraction
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click

        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            num1 = TextBox1.Text
            sign = "-"
            TextBox1.Text = ""
        End If
    End Sub


    'Multiplication
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            num1 = TextBox1.Text
            sign = "x"
            TextBox1.Text = ""
        End If
    End Sub


    'Division
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            num1 = TextBox1.Text
            sign = "/"
            TextBox1.Text = ""
        End If
    End Sub


    'Percentage
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            num1 = TextBox1.Text
            sign = "%"
            TextBox1.Text = ""
        End If
    End Sub



    'Equal
    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click



        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "NaN" Then
            TextBox1.Text = ""
        ElseIf TextBox1.Text = False Then
            TextBox1.Text = ""
        Else
            num2 = TextBox1.Text
        End If


        'Operation Signs
        If sign = "+" Then
            TextBox1.Text = num1 + num2
        ElseIf sign = "-" Then
            TextBox1.Text = num1 - num2
        ElseIf sign = "x" Then
            TextBox1.Text = num1 * num2
        ElseIf sign = "/" Then
            TextBox1.Text = num1 / num2
        ElseIf sign = "%" Then
            TextBox1.Text = (num2 / num1) & "%"
        Else
            TextBox1.Text = ""
        End If
        'End of Operation Sign


    End Sub


    'Clear Button


    'Single Clear
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click

        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            textClear = TextBox1.Text
            TextBox1.Text = textClear.Remove(textClear.Length() - 1) 'Remove The Number with Index Value of The Lengh of TextBox1
        End If
    End Sub


    'Clear All
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        TextBox1.Text = ""
    End Sub


    'Memory Button


    'Memory Store
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            mStore = TextBox1.Text
        End If

    End Sub


    'Memory Clear
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mStore = 0
    End Sub


    'Memory Plus
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            mPlus = TextBox1.Text
            TextBox1.Text = mPlus + mStore
        End If
    End Sub


    'Memory Minus
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            mMinus = TextBox1.Text
            TextBox1.Text = mMinus - mStore
        End If

    End Sub

   
    'Positive/Negative Sign
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        If TextBox1.Text = "" Then
            TextBox1.Text = "-"
        ElseIf TextBox1.Text = "-" Then
            TextBox1.Text = ""
        Else
            nPositive = TextBox1.Text * -1
            TextBox1.Text = nPositive
        End If

    End Sub


    'Square Root
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = ""
        ElseIf Val(TextBox1.Text ^ (1 / 2)) Then
            TextBox1.Text = Val(TextBox1.Text ^ (1 / 2))
        Else
            TextBox1.Text = "Syntax Error"
        End If

    End Sub


    'OFF
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If TextBox1.BackColor = Color.LightCyan Then


            'New Line =  & vbNewLine &


            'Bye Emoji
            'emoji 1
            TextBox1.Text = "Bye Warren!      " & vbNewLine & "(^o^)/            "

            'Delay 
            For i As Integer = 1 To 100 ' <--- 1sec
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next

            'emoji 2
            TextBox1.Text = "Bye Warren       " & vbNewLine & "(^o^)--           "

            'Delay 
            For i As Integer = 1 To 100 ' <--- 1sec
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next

            'emoji 3
            TextBox1.Text = "Bye Warren!      " & vbNewLine & "(^o^)/            "

            'Delay 
            For i As Integer = 1 To 100 ' <--- 1sec
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next

            

            TextBox1.BackColor = Color.Black
            TextBox1.Text = ""


        Else
            TextBox1.BackColor = Color.LightCyan


            'Good Morning
            TextBox1.Text = "Good Morning      " & vbNewLine & " Warren           "

            'Delay 
            For i As Integer = 1 To 100 ' <--- 1sec
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next


            'Wink Emoji
            'emoji 1
            TextBox1.Text = "( ͡° ͜ʖ ͡°)            "

            'Delay 
            For i As Integer = 1 To 100 ' <--- 1sec
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next


            'emoji 2
            TextBox1.Text = "( ͡~ ͜ʖ ͡°)            "

            'Delay 
            For i As Integer = 1 To 100 ' <--- 1sec
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next


            TextBox1.Text = ""

        End If


    End Sub


    'Casio Change Color

    '0.DarkGray
    '1.RosyBrown
    '2.Plum
    '3.CadetBlue
    '4.SteelBlue
    '5.BlueViolet
    '6.GhostWhite
    '7.SlateGray
    '8.Tan
    '9.DarkCyan



    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click


        'Press Number 0-9 and Logo to change color

        If TextBox1.Text = "0" Then
            Me.BackColor = Color.DarkGray
        ElseIf TextBox1.Text = "1" Then
            Me.BackColor = Color.RosyBrown
        ElseIf TextBox1.Text = "2" Then
            Me.BackColor = Color.Plum
        ElseIf TextBox1.Text = "3" Then
            Me.BackColor = Color.CadetBlue
        ElseIf TextBox1.Text = "4" Then
            Me.BackColor = Color.SteelBlue
        ElseIf TextBox1.Text = "5" Then
            Me.BackColor = Color.BlueViolet
        ElseIf TextBox1.Text = "6" Then
            Me.BackColor = Color.GhostWhite
        ElseIf TextBox1.Text = "7" Then
            Me.BackColor = Color.SlateGray
        ElseIf TextBox1.Text = "8" Then
            Me.BackColor = Color.Tan
        ElseIf TextBox1.Text = "9" Then
            Me.BackColor = Color.DarkCyan
        End If
        'End of Color Change

        TextBox1.Text = ""



    End Sub




    'Allow Only Numbers And Decimal

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True

            'TextBox1.Font = font1 'Change Font
            'TextBox1.TextAlign = HorizontalAlignment.Left
            TextBox1.Text = "Syntax Error:            " & vbNewLine & " - Numbers Only       "
            'TextBox1.TextAlign = HorizontalAlignment.Right
        End If
    End Sub

End Class
