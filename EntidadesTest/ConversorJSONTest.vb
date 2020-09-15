Imports Entidades
Module ConversorJSONTest
    Sub main()
        Dim JSON As String
        Dim array As New ArrayList

        array.Add("hola")
        array.Add("adios")
        array.Add(New ServicioAdicional(8, "Servicio Nuevo Creado"))

        JSON = ConversorJSON.ConvertirArray_JSON(array)
        Console.WriteLine(JSON)

        Dim arrConverted As ArrayList
        arrConverted = ConversorJSON.ConvertirJSON_Array(JSON)
        Dim hola As String = arrConverted.Item(0)
        Console.WriteLine(hola)
        Dim servicio As ServicioAdicional
        servicio = arrConverted.Item(2)
        Console.WriteLine(servicio)
        Console.ReadKey()
    End Sub
End Module
