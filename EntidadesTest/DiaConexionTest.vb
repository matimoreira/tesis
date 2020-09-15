Imports Entidades
Module DiaConexionTest
    Sub Main()
        Dim id_espacio As Integer
        Dim fecha As String
        Dim diaConexion As New DiaConexion
        Dim Respuesta As String
        Dim horarios As List(Of Horario)
        Dim usuario As New Usuario()
        usuario.Email = "matiempleado1@gmail.com"
        usuario.Pass = "1234"

        Dim objetoResp1 As Dictionary(Of String, String)
        objetoResp1 = ConversorJSON.ConvertirJSON_Dictionary(UsuarioConexion.login(usuario))
        Console.WriteLine(UsuarioConexion.login(usuario))



        id_espacio = 2
        fecha = "2019-12-04"
        'Dim r_horarios As ArrayList
        Respuesta = DiaConexion.getTurnoByEspacioFecha(id_espacio, fecha)
        If Respuesta = "	false" Then
            Console.WriteLine("Respuesta false")
        Else
            horarios = ConversorJSON.ConvertirJSON_ListOfHorario(Respuesta)
            For Each horario As Horario In horarios
                Console.WriteLine(horario.Id_Horario)
            Next
        End If
        'Try
        '    horarios = ConversorJSON.ConvertirJSON_ListOfHorario(Respuesta)
        'Catch ex As ArgumentException
        '    Console.WriteLine(ex.Message)
        'Finally
        '    For Each horario As Horario In horarios
        '        Console.WriteLine(horario.Id_Horario)
        '    Next
        'End Try




        'r_horarios = ConversorJSON.ConvertirJSON_Array(objetoResp)

        'For Each horario In r_horarios
        '    Console.WriteLine(horario)
        'Next

        'Console.WriteLine(arrayrespuesta.Item("estado"))
        'For Each horario In objetoResp
        '    Console.WriteLine("1")
        '    Console.WriteLine(horario)
        'Next


        'For Each horario As Dictionary(Of String, String) In objetoResp.Item("turnoByEspacioFecha")
        '    Console.WriteLine(horario)
        'Next
        Console.ReadKey()

    End Sub
End Module
