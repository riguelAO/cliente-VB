Public Class Form1

    Dim servicio As New ServiceReference1.WebService1SoapClient

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim Nro1, Nro2, Suma As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Suma = servicio.Sumar(Nro1, Nro2)
        MessageBox.Show("La suma de los numeros es: " + Suma.ToString)
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim Nro1, Nro2, resta As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        resta = servicio.Resta(Nro1, Nro2)
        MessageBox.Show("La resta de los numeros es: " + resta.ToString)
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim Nro1, Nro2, multi As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        multi = servicio.Multiplicacion(Nro1, Nro2)
        MessageBox.Show("La multiplicacion de los numeros es: " + multi.ToString)
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim Nro1, Nro2, divi As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        divi = servicio.Division(Nro1, Nro2)
        MessageBox.Show("La division de los numeros es: " + divi.ToString)
    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        Dim Nro1, fact As Double
        Nro1 = txtNro1.Text
        fact = servicio.Fact(Nro1)
        MessageBox.Show("El factorial del numero 1 es: " + fact.ToString)
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        Dim Nro1, Nro2, pot As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        pot = servicio.Potencia(Nro1, Nro2)
        MessageBox.Show("Lapotencia es: " + pot.ToString)
    End Sub

    Private Sub btnSeno_Click(sender As Object, e As EventArgs) Handles btnSeno.Click
        Dim Nro1, ang As Double
        Nro1 = txtNro1.Text
        ang = servicio.Seno(Nro1)
        MessageBox.Show("El seno del angulo es: " + ang.ToString)
    End Sub

    Private Sub btnTangente_Click(sender As Object, e As EventArgs) Handles btnTangente.Click
        Dim Nro1, angt As Double
        Nro1 = txtNro1.Text
        angt = servicio.Tangente(Nro1)
        MessageBox.Show("La tangente del angulo es: " + angt.ToString)
    End Sub

    Private Sub btnRaizCua_Click(sender As Object, e As EventArgs) Handles btnRaizCua.Click
        Dim Nro1, raizc As Double
        Nro1 = Double.Parse(txtNro1.Text)
        raizc = servicio.raiz_cuadrada(Nro1)
        MessageBox.Show("La raiz cuadrada del numero es: " + raizc.ToString)
    End Sub

    Private Sub btnRaizN_Click(sender As Object, e As EventArgs) Handles btnRaizN.Click
        Dim Nro1, Nro2, raizn As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        raizn = servicio.raiz_n_esima(Nro1, Nro2)
        MessageBox.Show("la raiz n esima es: " + raizn.ToString)
    End Sub
End Class
