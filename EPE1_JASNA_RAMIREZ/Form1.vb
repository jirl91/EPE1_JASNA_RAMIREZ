Imports Microsoft.Office.Interop
Imports Microsoft.VisualBasic.Devices
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1

    'Boton cargar 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCarga.Click
        Try
            Dim rutaArchivo As String = "C:\Users\Prueba jasna\Desktop\Lista.xls" 'Informa donde está la ruta del archivo

            'Instancia de aplicacion Excel

            Dim xlApp As Excel.Application = New Excel.Application()
            Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Open(rutaArchivo)
            Dim xlWorkSheet As Excel.Worksheet = xlWorkBook.Sheets(1)
            Dim xlRange As Excel.Range = xlWorkSheet.UsedRange
            Dim datosCargados As Boolean = False

            'Recorrer filas del archivo 

            For i As Integer = 2 To xlRange.Rows.Count
                Dim nombreProducto As String = xlRange.Cells(i, 1).Value.ToString()
                cmbProductos.Items.Add(nombreProducto)
                datosCargados = True
            Next
            'Verificar si se cargaron datos
            If Not datosCargados Then
                MsgBox("El archivo Excel no contiene datos en las celdas especificadas.")
            Else
                MsgBox("Los datos han sido cargados correctamente")
                btnCarga.Enabled = False
            End If

            'Cerrar Excel

            xlWorkBook.Close()
            xlApp.Quit()

            'Liberar recursos

            ReleaseObject(xlRange)
            ReleaseObject(xlWorkSheet)
            ReleaseObject(xlWorkBook)
            ReleaseObject(xlApp)

            btnCarga.Enabled = False

        Catch ex As Exception
            MsgBox("Ocurrió un error al cargar el archivo Excel: " & ex.Message)
        End Try

    End Sub
    ' Método para liberar recursos de objetos COM utilizados por Excel
    Private Sub ReleaseObject(ByVal obj As Object)

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()

        End Try

    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        Try

            Dim rutaArchivo As String = "C:\Users\Prueba jasna\Desktop\Lista.xls" 'Informa donde está la ruta del archivo


            'Instancia de aplicacion Excel
            Dim xlApp As Excel.Application = New Excel.Application()
            Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Open(rutaArchivo)
            Dim xlWorkSheet As Excel.Worksheet = xlWorkBook.Sheets(1)
            Dim xlRange As Excel.Range = xlWorkSheet.UsedRange

            For i As Integer = 2 To xlRange.Rows.Count
                Dim nombreProducto As String = xlRange.Cells(i, 1).Value.ToString()
                If nombreProducto = cmbProductos.SelectedItem.ToString() Then
                    txtDescripcion.Text = xlRange.Cells(i, 2).Value.ToString()
                    txtPrecio.Text = xlRange.Cells(i, 6).Value.ToString()
                    txtStock.Text = xlRange.Cells(i, 7).Value.ToString()
                    Exit For

                End If

            Next
            'Cerrar Excel

            xlWorkBook.Close()
            xlApp.Quit()

            'Liberar recursos

            ReleaseObject(xlRange)
            ReleaseObject(xlWorkSheet)
            ReleaseObject(xlWorkBook)
            ReleaseObject(xlApp)
            MsgBox("Los datos datos se pueden visualizar correctamente")
            btnCarga.Enabled = False

        Catch ex As Exception
            MsgBox("Ocurrió un error al visualizar los datos: " & ex.Message)
        End Try

    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub
End Class
