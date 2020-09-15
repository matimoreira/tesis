Imports Entidades
Module ServicioAdicionalTest

    Sub Main()
        Dim listaServicios As New ArrayList

        Dim servicio1 As New ServicioAdicional()
        Dim servicio2 As New ServicioAdicional("ducha")
        Dim servicio3 As New ServicioAdicional(1, "agua caliente")
        listaServicios.Add(servicio1)
        listaServicios.Add(servicio2)
        listaServicios.Add(servicio3)

        For Each servicio In listaServicios
            Console.WriteLine(servicio.ToString())
        Next

        Console.ReadKey()
    End Sub

End Module
