Imports Entidades
Module ReservaConexionTest
    Sub main()
        Dim usuario As New Usuario()

        usuario.Email = "matiempleado1@gmail.com"
        usuario.Pass = "1234"
        Dim objetoResp1 As Dictionary(Of String, String)
        objetoResp1 = ConversorJSON.ConvertirJSON_Dictionary(UsuarioConexion.login(usuario))
        Console.WriteLine("ReservaConexionTest")
        Console.WriteLine(UsuarioConexion.login(usuario))

        Dim espacio As New EspacioRecreativo(2, "Una cancha muy piola")
        Dim espacio2 As New EspacioRecreativo(3, "Una cancha muy piola")
        Dim espacio3 As New EspacioRecreativo(10, "Una cancha de la hostia tio")

        Dim horario1 As New Horario(1, Convert.ToDateTime("2019-12-04 08:00:00"), Convert.ToDateTime("2019-12-04 12:00:00"), 100)
        Dim horario2 As New Horario(2, Convert.ToDateTime("2019-12-04 16:00:00"), Convert.ToDateTime("2019-12-04 20:00:00"), 100)
        Dim horario3 As New Horario(3, Convert.ToDateTime("2019-12-04 08:00:00"), Convert.ToDateTime("2019-12-04 12:00:00"), 400)
        Dim horario4 As New Horario(4, Convert.ToDateTime("2019-12-04 16:00:00"), Convert.ToDateTime("2019-12-04 20:00:00"), 700)
        Dim horario5 As New Horario(5, Convert.ToDateTime("2019-12-04 08:00:00"), Convert.ToDateTime("2019-12-04 12:00:00"), 600)
        Dim horario6 As New Horario(6, Convert.ToDateTime("2019-12-04 16:00:00"), Convert.ToDateTime("2019-12-04 23:00:00"), 800)

        Dim reservasConexion As New ReservaConexion
        Dim reservas As List(Of Reserva)
        Dim Respuesta As String
        Dim fecha As String
        fecha = "2019-01-01"
        Respuesta = ReservaConexion.getReservasTurno(espacio, horario1, fecha)
        If Respuesta = "	false" Then
            Console.WriteLine("Respuesta false")
        Else
            Console.WriteLine("Respuesta true")
            reservas = ConversorJSON.ConvertirJSON_ListOfReserva(Respuesta)
            For Each reserva As Reserva In reservas
                Console.WriteLine(reserva.Id_Reserva)
            Next
        End If

        s
        Dim Respuesta1 As String
        Dim fecha1 As String
        fecha = "2019-12-04"
        Respuesta = ReservaConexion.solicitarReserva(espacio, horario1, fecha, 2000, "08:00", "09:45")
        If Respuesta = "	false" Then
            Console.WriteLine("Respuesta false")
        Else
            Console.WriteLine(Respuesta)
            'reservas = ConversorJSON.ConvertirJSON_ListOfReserva(Respuesta)
            'For Each reserva As Reserva In reservas
            '    Console.WriteLine(reserva.Id_Reserva)
            'Next
        End If
        Console.ReadKey()
    End Sub
End Module
