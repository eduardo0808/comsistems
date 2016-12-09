
Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Municipio
    Dim Nombre, Nota As String
    Dim provincia As Integer
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Public Sub ListaProvincia()
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from municipio", Conex)
            DA.Fill(DT)
            cbprovinciaMc.DataSource = DT
            cbprovinciaMc.DisplayMember = "nombre"
            cbprovinciaMc.ValueMember = "idmunicipio"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnguardarPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarMc.Click
        RecogerVariables()
        MDIempleado()
        Me.Hide()
    End Sub


    Private Sub Municipio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListaProvincia()
    End Sub

    Public Sub RecogerVariables()

        Nombre = txtnombreMc.Text
        Nota = txtnotaMc.Text
        provincia = Val(cbprovinciaMc.Text).ToString
       
        Try
            sql = "insert into municipio(nombre,comentario,idprovincia)value('" & Nombre & "', '" & Nota & "','" & provincia & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            'Datos.DataSource = dt
            MsgBox("Datos almacenados con exito")
        Catch ex As Exception
            MsgBox(ex.Message)

            MsgBox("Los campos estan vacios")
            'MsgBox(Nombre + Apellido)
        End Try
        MDIempleado()
        Me.Hide()
    End Sub
    Private Sub btncancelarMc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarMc.Click
        Me.Close()
        Empleado.Show()
    End Sub
End Class