Module Module1

    Sub Main()
        Dim dates As New System.DateTime(2022, 8, 3, 21, 20, 10)
        Dim otherDate As Date = #3/8/2022 09:05:03#

        Dim dia, diasemana, mes, año, mesString, fechaHoy As String
        dia = Day(Now)
        diasemana = Weekday(Now)
        mes = Month(Now)
        mesString = MonthName(mes)
        año = Year(Now)

        'fechaHoy = Format(Now, "dd/MM/yy")
        fechaHoy = Format(Now, "dd/MM/yyy")
        Dim cadFecha As String = Format(Now(), "General Date")
        cadFecha = Format(Now(), "Long Date")
        Console.WriteLine(cadFecha)
        cadFecha = Format(Now(), "Medium Date")
        Console.WriteLine(cadFecha)
        cadFecha = Format(Now(), "D")
        Console.WriteLine(cadFecha)

        'impresiones
        'Console.WriteLine(fechaHoy)
        'Console.WriteLine(" fecha establecida " & dates & "Otra fecha" & otherDate)
        'Console.WriteLine("**** fechas tomadas deñ sistema****")
        'Console.WriteLine("Dia:{0} y semana: {1} mes: {2}", dia, diasemana, mes)
        'Console.WriteLine(" mes:" & mesString & "Años :" & año)
    End Sub

End Module
