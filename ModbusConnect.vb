Public Class ModbusConnect


    Public modbsclient As New EasyModbus.ModbusClient()
    Public Sub setParameter(comPORT As String, slaveID As Byte, baudRate As Integer)
        modbsclient.SerialPort = comPORT
        modbsclient.UnitIdentifier = slaveID
        modbsclient.Baudrate = baudRate
        modbsclient.Parity = System.IO.Ports.Parity.None
        modbsclient.StopBits = System.IO.Ports.StopBits.One
    End Sub
#Region "Connect Disconnect"
    Public Sub OpenConnectioin()
        Try
            modbsclient.Connect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CloseConnectioin()
        Try
            modbsclient.Disconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Public Function ReadHolregister(ByVal address As Integer, ByVal length As Integer) As Integer()
        Dim RHR As Integer() = modbsclient.ReadHoldingRegisters(address, length)
        Return RHR
    End Function
End Class
