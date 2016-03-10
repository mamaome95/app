Imports System.Data.SqlClient
Imports System.Data
Public Class Class1

    Public Function Loadsanpham() As DataSet
        'Dim chuoiketnoi As String = "Data Source=PC243\;Initial Catalog=ANDDPS03332;Integrated Security=True"
        Dim chuoiketnoi As String = "workstation id=final-ps03332.mssql.somee.com;packet size=4096;user id=demops03332_SQLLogin_2;pwd=ico8vh59ew;data source=final-ps03332.mssql.somee.com;persist security info=False;initial catalog=final-ps03332"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select MaSP as 'Mã sản phẩm',TenSP as 'Tên sản phẩm',Soluong as 'Số lượng', Soluong * Dongia as 'Thành Tiền' from SANPHAM1", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
