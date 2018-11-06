Imports MySql.Data.MySqlClient

Class MainWindow

    Private Sub btn_close_Click(sender As Object, e As RoutedEventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_sig_Click(sender As Object, e As RoutedEventArgs) Handles bt_sig.Click
        If txt_user.Text = "mod1" And txt_pass.Password = "1234" Then
            Dim Base As New Base
            Base.Show()
            Me.Close()
        ElseIf txt_user.Text = "mod2" And txt_pass.Password = "12345" Then
            Dim Mod2 As New Mod2
            Mod2.Show()
            Me.Close()
        ElseIf txt_user.Text = "mod3" And txt_pass.Password = "123456" Then
            Dim Mod3 As New Mod3
            Mod3.Show()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim bd_conetion As New MySqlConnection("host=127.0.0.1; user=root; database=hnsc")
        Try
            bd_conetion.Open()
            MessageBox.Show("Wenas :v")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
