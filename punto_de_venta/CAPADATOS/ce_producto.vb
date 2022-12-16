Public Class ce_producto

    Public Property descuento_activo As String
    Public Property categotia As String
    Public Property ganancia_por_precio_al_pormayor As Decimal
    Public Property itbis As Decimal
    Public Property id_producto As Integer
    Public Property description As String
    Public Property categorias As String
    Public Property codigo_de_barra As String
    Public Property se_vende_por As String
    Public Property precio_de_compra As Decimal
    Public Property precio_de_venta As Decimal
    Public Property precio_mayoreo As Decimal
    Public Property cantidad As Decimal
    Public Property punto_de_reorden As Integer
    Public Property cantida_por_mayoreo As Decimal
    Public Property fecha_de_vencieminto As String
    Public Property precio_con_descuento As Decimal
    Public Property ganancias As Decimal
    Dim imagen() As Byte
    Public Property gimagen
        Set(value)
            imagen = value
        End Set
        Get
            Return imagen

        End Get
    End Property


End Class
