Public Class Form1
    Dim a, b, pb, bp As PictureBox
    Dim c, d As Color
    Dim nbgr, paire, valeur, wh, carte As Byte


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = False
        Dim couleur As Byte
        Dim face As Color
        Dim rpaire, bpaire, gpaire, ypaire, ppaire, opaire As Byte


        rpaire = 2
        bpaire = 2
        gpaire = 2
        ypaire = 2
        opaire = 2
        ppaire = 2

        Dim pics() As PictureBox =
        {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12}

        For i As Integer = 0 To pics.Length - 1
            pics(i).Visible = True
        Next i

        wh = 1
        While wh <= 12

            Randomize()
            couleur = CInt(Math.Floor((6 - 1 + 1) * Rnd())) + 1

            If couleur = 1 And rpaire > 0 Then
                face = Color.Red
                rpaire = rpaire - 1
                wh = wh + 1
            ElseIf couleur = 2 And bpaire > 0 Then
                face = Color.Blue
                bpaire = bpaire - 1
                wh = wh + 1
            ElseIf couleur = 3 And gpaire > 0 Then
                face = Color.Green
                gpaire = gpaire - 1
                wh = wh + 1
            ElseIf couleur = 4 And ypaire > 0 Then
                face = Color.Yellow
                ypaire = ypaire - 1
                wh = wh + 1
            ElseIf couleur = 5 And ppaire > 0 Then
                face = Color.Purple
                ppaire = ppaire - 1
                wh = wh + 1
            ElseIf couleur = 6 And opaire > 0 Then
                face = Color.Orange
                opaire = opaire - 1
                wh = wh + 1
            End If


            If wh = 2 Then
                PictureBox2.BackColor = face
            ElseIf wh = 3 Then
                PictureBox3.BackColor = face
            ElseIf wh = 4 Then
                PictureBox4.BackColor = face
            ElseIf wh = 5 Then
                PictureBox5.BackColor = face
            ElseIf wh = 6 Then
                PictureBox6.BackColor = face
            ElseIf wh = 7 Then
                PictureBox7.BackColor = face
            ElseIf wh = 8 Then
                PictureBox8.BackColor = face
            ElseIf wh = 9 Then
                PictureBox9.BackColor = face
            ElseIf wh = 10 Then
                PictureBox10.BackColor = face
            ElseIf wh = 11 Then
                PictureBox11.BackColor = face
            ElseIf wh = 12
                PictureBox12.BackColor = face
            Else
                PictureBox1.BackColor = face
            End If

        End While

        Button1.Enabled = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox9.Click, PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox12.Click, PictureBox11.Click, PictureBox10.Click
        pb = sender
        ClickCard()
    End Sub


    Sub aa()

        Label8.Text = Label8.Text + 1
        Dim pics() As PictureBox =
        {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12}

        For i As Integer = 0 To pics.Length - 1

            pics(i).BackgroundImage = System.Drawing.Image.FromFile("C:\Users\gratga1\Documents\GitHub\4Memoire\images\carte.png")

        Next i

        a = Nothing
        b = Nothing
        c = Nothing
        d = Nothing
        pb = Nothing
        valeur = 0
        paire = 0

    End Sub
    Sub completition()

        If c = d And Not (c = Nothing And d = Nothing) Then
            MsgBox("bravo")
            b.Enabled = False
            a.Enabled = False
            b.Visible = False
            a.Visible = False
            aa()
            Label5.Text = Val(Label5.Text) + 1

            If Label5.Text = 6 Then
                nbgr = nbgr + 1
                MsgBox("Vous avez réussi le jeu avec " & nbgr & Space(1) & "victoire et " & Label8.Text & Space(1) & "coups")
                Button2.Enabled = True
            End If

        End If
    End Sub
    Sub ClickCard()

        If paire < 2 Then
            pb.BackgroundImage = Nothing
            paire = paire + 1

            If valeur = 0 Then
                a = pb
                c = pb.BackColor
                valeur = valeur + 1
            Else
                b = pb
                d = pb.BackColor
                valeur = valeur + 1
            End If


            completition()

        Else
            aa()

        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button1.Enabled = True
        Button1.PerformClick()

        Label5.Text = 0
        Label8.Text = 0

        Dim pics() As PictureBox =
        {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12}

        For i As Integer = 0 To pics.Length - 1
            pics(i).Visible = True
            pics(i).Enabled = True
        Next i

    End Sub


End Class
