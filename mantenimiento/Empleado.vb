Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Empleado
    Public Sub Lista()
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New MySqlDataAdapter("select * from pais", Conex)
            DA.Fill(DT)
            cbpaisEm.DataSource = DT
            cbpaisEm.DisplayMember = "nombre"
            cbpaisEm.ValueMember = "idpais"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lista()
    End Sub
End Class