Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label5.Click, Label4.Click, Label6.Click, Label8.Click, Label7.Click, Label9.Click, Label10.Click, Label11.Click, Label13.Click, Label12.Click, Label14.Click, Label15.Click, Label16.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox3.TextChanged, txtFood1.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, txtFood5.TextChanged, txtFood8.TextChanged, txtFood4.TextChanged, txtFood2.TextChanged, TextBox14.TextChanged, TextBox13.TextChanged, TextBox12.TextChanged, txtFood6.TextChanged, TextBox10.TextChanged, txtFood7.TextChanged, txtFood3.TextChanged

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click, PictureBox5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Int total = 0;
        If (txtFood1.Text)! = "" Then)
        {
          total += Convert.ToInt32(txtFood1.Text) * 180;
        }
        If (txtFood2.Text! = "") Then
                        {
            total += Convert.ToInt32(txtFood2.Text) * 70;
        }
        If (txtFood3.Text! = "") Then
                            {
            total += Convert.ToInt32(txtFood3.Text) * 120;
        }
        If (txtFood4.Text! = "") Then
                                {
            total += Convert.ToInt32(txtFood4.Text) * 160;
        }
        If (txtFood5.Text! = "") Then
                                    {
            total += Convert.ToInt32(txtFood5.Text) * 200;
        }
        If (txtFood6.Text! = "") Then
                                        {
            total += Convert.ToInt32(txtFood6.Text) * 100;
        }
        If (txtFood7.Text! = "") Then
                                            {
            total += Convert.ToInt32(txtFood7.Text) * 230;
        }
        If (txtFood8.Text)! = "" Then)
        {
          total += Convert.ToInt32(txtFood8.Text) * 150; 
        }
        IbIPay.text = Total.ToString();
                            End If

    End Sub
End Class
