Module MDImodulo
    Sub MDIempleado()
        Dim frmpempleado As New Empleado
        frmpempleado.MdiParent = CMprincipal
        frmpempleado.Show()
    End Sub
    Sub MDIpais()
        Dim frmpais As New Pais
        frmpais.MdiParent = CMprincipal
        frmpais.Show()
    End Sub
    Sub MDIprovincia()
        Dim frmprovincia As New Provincia
        frmprovincia.MdiParent = CMprincipal
        frmprovincia.Show()
    End Sub
    Sub MDImunicipio()
        Dim frm As New Municipio
        frm.MdiParent = CMprincipal
        frm.Show()
    End Sub
    Sub MDIsector()
        Dim frm As New Sector
        frm.MdiParent = CMprincipal
        frm.Show()
    End Sub

End Module
