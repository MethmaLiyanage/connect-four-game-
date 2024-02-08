Imports System.IO
Public Class Form1

    Dim c1(7) As String
    Dim c2(7) As String
    Dim c3(7) As String
    Dim c4(7) As String
    Dim c5(7) As String
    Dim c6(7) As String
    Dim c7(7) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.ForeColor = Color.Green
        Label4.ForeColor = Color.Green
        Label5.ForeColor = Color.Green
        Label6.ForeColor = Color.Green
        Label7.ForeColor = Color.Green
        Label8.ForeColor = Color.Green
        Label9.ForeColor = Color.Green


        If TextBox50.Text = "1" Then
            Label3.ForeColor = Color.Red
            For i = 0 To 6
                If c1(i) = 0 Then
                    c1(i) = 1
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 2 Then
            Label4.ForeColor = Color.Red
            For ii = 0 To 6
                If c2(ii) = 0 Then
                    c2(ii) = 1
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 3 Then
            Label5.ForeColor = Color.Red
            For iii = 0 To 6
                If c3(iii) = 0 Then
                    c3(iii) = 1
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 4 Then
            Label6.ForeColor = Color.Red
            For iv = 0 To 6
                If c4(iv) = 0 Then
                    c4(iv) = 1
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 5 Then
            Label7.ForeColor = Color.Red
            For v = 0 To 6
                If c5(v) = 0 Then
                    c5(v) = 1
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 6 Then
            Label8.ForeColor = Color.Red
            For vi = 0 To 6
                If c6(vi) = 0 Then
                    c6(vi) = 1
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 7 Then
            Label9.ForeColor = Color.Red
            For vii = 0 To 6
                If c7(vii) = 0 Then
                    c7(vii) = 1
                    Exit For
                End If
            Next
        End If

        'Assign textboxes
        TextBox7.Text = c1(0)
        TextBox6.Text = c1(1)
        TextBox5.Text = c1(2)
        TextBox4.Text = c1(3)
        TextBox3.Text = c1(4)
        TextBox2.Text = c1(5)
        TextBox1.Text = c1(6)

        TextBox14.Text = c2(0)
        TextBox13.Text = c2(1)
        TextBox12.Text = c2(2)
        TextBox11.Text = c2(3)
        TextBox10.Text = c2(4)
        TextBox9.Text = c2(5)
        TextBox8.Text = c2(6)

        TextBox21.Text = c3(0)
        TextBox20.Text = c3(1)
        TextBox19.Text = c3(2)
        TextBox18.Text = c3(3)
        TextBox17.Text = c3(4)
        TextBox16.Text = c3(5)
        TextBox15.Text = c3(6)

        TextBox28.Text = c4(0)
        TextBox27.Text = c4(1)
        TextBox26.Text = c4(2)
        TextBox25.Text = c4(3)
        TextBox24.Text = c4(4)
        TextBox23.Text = c4(5)
        TextBox22.Text = c4(6)

        TextBox35.Text = c5(0)
        TextBox34.Text = c5(1)
        TextBox33.Text = c5(2)
        TextBox32.Text = c5(3)
        TextBox31.Text = c5(4)
        TextBox30.Text = c5(5)
        TextBox29.Text = c5(6)

        TextBox42.Text = c6(0)
        TextBox41.Text = c6(1)
        TextBox40.Text = c6(2)
        TextBox39.Text = c6(3)
        TextBox38.Text = c6(4)
        TextBox37.Text = c6(5)
        TextBox36.Text = c6(6)

        TextBox49.Text = c7(0)
        TextBox48.Text = c7(1)
        TextBox47.Text = c7(2)
        TextBox46.Text = c7(3)
        TextBox45.Text = c7(4)
        TextBox44.Text = c7(5)
        TextBox43.Text = c7(6)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.ForeColor = Color.Green
        Label4.ForeColor = Color.Green
        Label5.ForeColor = Color.Green
        Label6.ForeColor = Color.Green
        Label7.ForeColor = Color.Green
        Label8.ForeColor = Color.Green
        Label9.ForeColor = Color.Green


        If TextBox50.Text = 1 Then
            Label3.ForeColor = Color.Red
            For i = 0 To 6
                If c1(i) = 0 Then
                    c1(i) = 2
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 2 Then
            Label4.ForeColor = Color.Red
            For ii = 0 To 6
                If c2(ii) = 0 Then
                    c2(ii) = 2
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 3 Then
            Label5.ForeColor = Color.Red
            For iii = 0 To 6
                If c3(iii) = 0 Then
                    c3(iii) = 2
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 4 Then
            Label6.ForeColor = Color.Red
            For iv = 0 To 6
                If c4(iv) = 0 Then
                    c4(iv) = 2
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 5 Then
            Label7.ForeColor = Color.Red
            For v = 0 To 6
                If c5(v) = 0 Then
                    c5(v) = 2
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 6 Then
            Label8.ForeColor = Color.Red
            For vi = 0 To 6
                If c6(vi) = 0 Then
                    c6(vi) = 2
                    Exit For
                End If
            Next
        ElseIf TextBox50.Text = 7 Then
            Label9.ForeColor = Color.Red
            For vii = 0 To 6
                If c7(vii) = 0 Then
                    c7(vii) = 2
                    Exit For
                End If
            Next
        End If

        'Assign textboxes
        TextBox7.Text = c1(0)
        TextBox6.Text = c1(1)
        TextBox5.Text = c1(2)
        TextBox4.Text = c1(3)
        TextBox3.Text = c1(4)
        TextBox2.Text = c1(5)
        TextBox1.Text = c1(6)

        TextBox14.Text = c2(0)
        TextBox13.Text = c2(1)
        TextBox12.Text = c2(2)
        TextBox11.Text = c2(3)
        TextBox10.Text = c2(4)
        TextBox9.Text = c2(5)
        TextBox8.Text = c2(6)

        TextBox21.Text = c3(0)
        TextBox20.Text = c3(1)
        TextBox19.Text = c3(2)
        TextBox18.Text = c3(3)
        TextBox17.Text = c3(4)
        TextBox16.Text = c3(5)
        TextBox15.Text = c3(6)

        TextBox28.Text = c4(0)
        TextBox27.Text = c4(1)
        TextBox26.Text = c4(2)
        TextBox25.Text = c4(3)
        TextBox24.Text = c4(4)
        TextBox23.Text = c4(5)
        TextBox22.Text = c4(6)

        TextBox35.Text = c5(0)
        TextBox34.Text = c5(1)
        TextBox33.Text = c5(2)
        TextBox32.Text = c5(3)
        TextBox31.Text = c5(4)
        TextBox30.Text = c5(5)
        TextBox29.Text = c5(6)

        TextBox42.Text = c6(0)
        TextBox41.Text = c6(1)
        TextBox40.Text = c6(2)
        TextBox39.Text = c6(3)
        TextBox38.Text = c6(4)
        TextBox37.Text = c6(5)
        TextBox36.Text = c6(6)

        TextBox49.Text = c7(0)
        TextBox48.Text = c7(1)
        TextBox47.Text = c7(2)
        TextBox46.Text = c7(3)
        TextBox45.Text = c7(4)
        TextBox44.Text = c7(5)
        TextBox43.Text = c7(6)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.IO.File.WriteAllLines("C:\Users\Methma Liyanage\Desktop\connect 4 game\game\New folder\c1.txt", c1)
        System.IO.File.WriteAllLines("C:\Users\Methma Liyanage\Desktop\connect 4 game\game\New folder\c2.txt", c2)
        System.IO.File.WriteAllLines("C:\Users\Methma Liyanage\Desktop\connect 4 game\game\New folder\c3.txt", c3)
        System.IO.File.WriteAllLines("C:\Users\Methma Liyanage\Desktop\connect 4 game\game\New folder\c3.txt", c4)
        System.IO.File.WriteAllLines("C:\Users\Methma Liyanage\Desktop\connect 4 game\game\New folder\c3.txt", c5)
        System.IO.File.WriteAllLines("C:\Users\Methma Liyanage\Desktop\connect 4 game\game\New folder\c3.txt", c6)
        System.IO.File.WriteAllLines("C:\Users\Methma Liyanage\Desktop\connect 4 game\game\New folder\c3.txt", c7)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            c1 = File.ReadAllLines("C:\Users\Methma Liyanage\Desktop\ucl\itp\c1.txt")
            For i = 0 To c1.Length - 1 Step 1
                Console.WriteLine(c1(i))
            Next

        Catch ex As FileNotFoundException
            Console.WriteLine("file does not exist")
        End Try

        TextBox7.Text = c1(0)
        TextBox6.Text = c1(1)
        TextBox5.Text = c1(2)
        TextBox4.Text = c1(3)
        TextBox3.Text = c1(4)
        TextBox2.Text = c1(5)
        TextBox1.Text = c1(6)

        Try

            c2 = File.ReadAllLines("C:\Users\Methma Liyanage\Desktop\ucl\itp\c2.txt")
            For i = 0 To c2.Length - 1 Step 1
                Console.WriteLine(c2(i))
            Next

        Catch ex As FileNotFoundException
            Console.WriteLine("file does not exist")
        End Try

        TextBox14.Text = c2(0)
        TextBox13.Text = c2(1)
        TextBox12.Text = c2(2)
        TextBox11.Text = c2(3)
        TextBox10.Text = c2(4)
        TextBox9.Text = c2(5)
        TextBox8.Text = c2(6)

        Try

            c3 = File.ReadAllLines("C:\Users\Methma Liyanage\Desktop\ucl\itp\c3.txt")
            For i = 0 To c3.Length - 1 Step 1
                Console.WriteLine(c3(i))
            Next

        Catch ex As FileNotFoundException
            Console.WriteLine("file does not exist")
        End Try

        TextBox21.Text = c3(0)
        TextBox20.Text = c3(1)
        TextBox19.Text = c3(2)
        TextBox18.Text = c3(3)
        TextBox17.Text = c3(4)
        TextBox16.Text = c3(5)
        TextBox15.Text = c3(6)

        Try

            c4 = File.ReadAllLines("C:\Users\Methma Liyanage\Desktop\ucl\itp\c4.txt")
            For i = 0 To c4.Length - 1 Step 1
                Console.WriteLine(c4(i))
            Next

        Catch ex As FileNotFoundException
            Console.WriteLine("file does not exist")
        End Try

        TextBox28.Text = c4(0)
        TextBox27.Text = c4(1)
        TextBox26.Text = c4(2)
        TextBox25.Text = c4(3)
        TextBox24.Text = c4(4)
        TextBox23.Text = c4(5)
        TextBox22.Text = c4(6)

        Try

            c5 = File.ReadAllLines("C:\Users\Methma Liyanage\Desktop\ucl\itp\c5.txt")
            For i = 0 To c5.Length - 1 Step 1
                Console.WriteLine(c5(i))
            Next

        Catch ex As FileNotFoundException
            Console.WriteLine("file does not exist")
        End Try

        TextBox35.Text = c5(0)
        TextBox34.Text = c5(1)
        TextBox33.Text = c5(2)
        TextBox32.Text = c5(3)
        TextBox31.Text = c5(4)
        TextBox30.Text = c5(5)
        TextBox29.Text = c5(6)

        Try

            c6 = File.ReadAllLines("C:\Users\Methma Liyanage\Desktop\ucl\itp\c6.txt")
            For i = 0 To c6.Length - 1 Step 1
                Console.WriteLine(c6(i))
            Next

        Catch ex As FileNotFoundException
            Console.WriteLine("file does not exist")
        End Try

        TextBox42.Text = c6(0)
        TextBox41.Text = c6(1)
        TextBox40.Text = c6(2)
        TextBox39.Text = c6(3)
        TextBox38.Text = c6(4)
        TextBox37.Text = c6(5)
        TextBox36.Text = c6(6)

        Try

            c7 = File.ReadAllLines("C:\Users\Methma Liyanage\Desktop\ucl\itp\c7.txt")
            For i = 0 To c7.Length - 1 Step 1
                Console.WriteLine(c7(i))
            Next

        Catch ex As FileNotFoundException
            Console.WriteLine("file does not exist")
        End Try

        TextBox49.Text = c7(0)
        TextBox48.Text = c7(1)
        TextBox47.Text = c7(2)
        TextBox46.Text = c7(3)
        TextBox45.Text = c7(4)
        TextBox44.Text = c7(5)
        TextBox43.Text = c7(6)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""

        TextBox14.Text = ""
        TextBox13.Text = ""
        TextBox12.Text = ""
        TextBox11.Text = ""
        TextBox10.Text = ""
        TextBox9.Text = ""
        TextBox8.Text = ""

        TextBox21.Text = ""
        TextBox20.Text = ""
        TextBox19.Text = ""
        TextBox18.Text = ""
        TextBox17.Text = ""
        TextBox16.Text = ""
        TextBox15.Text = ""

        TextBox28.Text = ""
        TextBox27.Text = ""
        TextBox26.Text = ""
        TextBox25.Text = ""
        TextBox24.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""

        TextBox35.Text = ""
        TextBox34.Text = ""
        TextBox33.Text = ""
        TextBox32.Text = ""
        TextBox31.Text = ""
        TextBox30.Text = ""
        TextBox29.Text = ""

        TextBox42.Text = ""
        TextBox41.Text = ""
        TextBox40.Text = ""
        TextBox39.Text = ""
        TextBox38.Text = ""
        TextBox37.Text = ""
        TextBox36.Text = ""

        TextBox49.Text = ""
        TextBox48.Text = ""
        TextBox47.Text = ""
        TextBox46.Text = ""
        TextBox45.Text = ""
        TextBox44.Text = ""
        TextBox43.Text = ""

    End Sub
End Class
