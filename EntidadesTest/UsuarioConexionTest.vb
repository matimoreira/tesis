Imports Entidades
Module UsuarioConexionTest
    Sub Main()
        Dim usuario As New Usuario()
        usuario.Email = "sebabenitez1095@gmail.com"
        usuario.Pass = "1234"

        Dim objetoResp As Dictionary(Of String, String)
        objetoResp = ConversorJSON.ConvertirJSON_Dictionary(UsuarioConexion.login(usuario))
        Console.WriteLine(UsuarioConexion.login(usuario))

        Console.WriteLine("====================LOGUEADO==============================")
        Dim conexion As New Conexion
        conexion.URL = "http://tesis/SourceFiles/index.php?controller=Horario&action=horario"
        Console.WriteLine(conexion.RealizarGET())

        Console.WriteLine("======================LOGOUT============================")
        Dim conexion2 As New Conexion
        conexion2.URL = "http://tesis/SourceFiles/index.php?controller=Usuario&action=logout"
        conexion2.Datos = "platform=desktop"
        Console.WriteLine(conexion2.RealizarPOST())

        Console.WriteLine("======================DESLOGUEADO============================")
        Dim conexion3 As New Conexion
        conexion3.URL = "http://tesis/SourceFiles/index.php?controller=Horario&action=horario"
        Console.WriteLine(conexion3.RealizarGET())

        Console.WriteLine("==================================================")
        Console.WriteLine(objetoResp.Item("resultado"))
        Console.WriteLine(objetoResp.Item("id_usuario"))

        Console.ReadKey()
    End Sub
End Module
