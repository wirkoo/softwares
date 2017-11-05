Imports System.IO
Imports itextsharp.text
Imports itextsharp.text.pdf

Public Class main
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        'Select all text code
        RichTextBox.SelectAll()
    End Sub
    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click


        RichTextBox.SelectAll()
        My.Computer.Clipboard.SetText(RichTextBox.Text)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

        My.Computer.Clipboard.SetText(RichTextBox.Text)
        RichTextBox.Clear()

    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click

        sfd.ShowDialog()
    End Sub




    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs)
        'Dim sfd As New SaveFileDialog
        'sfd.Filter = "Text files(*.txt)|*.txt| PDF Files(*.pdf)|*.pdf"
        '
        '


    End Sub

    Private Sub ToolStripLabel6_Click(sender As Object, e As EventArgs) Handles ToolStripLabel6.Click

        If MessageBox.Show("Do you really Want to Save existing File ?", "Wait", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            sfd.ShowDialog()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub sfd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd.FileOk
        Dim SW As StreamWriter
        SW = New StreamWriter(sfd.FileName, False)
        SW.WriteLine(RichTextBox.Text)
        SW.Close()
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged


    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(RichTextBox.Text)
        RichTextBox.Clear()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(RichTextBox.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        If MessageBox.Show("Do you really Want to Save existing File ?", "Wait", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            sfd.ShowDialog()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox.Text = My.Computer.Clipboard.GetText()

    End Sub
End Class
