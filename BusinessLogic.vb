Public Class BusinessLogic
    Dim db As New administrationEntities3
    Public Sub add()


        Dim ad As New AdminTable

        ad.FirstName = "firstname"
        ad.LastName = "lastname"
        ad.username = "username"
        ad.password = "password"
        db.AdminTables.Add(ad)

        db.SaveChanges()

    End Sub

    Public Sub read()
        Dim ADMIN = db.AdminTables.FirstOrDefault(Function(y) y.FirstName = "firstame")
        ADMIN = db.AdminTables.Find(1)
        Debug.WriteLine(ADMIN.FirstName & "\n" & ADMIN.LastName & "\n")

    End Sub
End Class
