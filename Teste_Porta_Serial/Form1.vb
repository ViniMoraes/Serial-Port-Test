Imports System.IO.Ports
Public Class Form1




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each PortaCOM As String In SerialPort.GetPortNames()
            ListBox1.Items.Add(PortaCOM)
        Next
        If ListBox1.Items IsNot Nothing Then
            Button7.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SerialPort1.PortName = (ListBox1.SelectedItem.ToString)
        SerialPort1.Open()
        Button4.Enabled = False
        Button5.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Enabled = False
        TextBox1.Text = ""
        SerialPort1.Close()
        Button4.Enabled = True
        Button5.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SerialPort1.WriteLine(TextBox2.Text)
        TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Button2.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ValorLido As String = ""
        ValorLido = SerialPort1.ReadExisting
        TextBox1.Text += ValorLido
    End Sub

End Class
