Public Class MedicalReport
    Public id As Integer
    Public patient_id As Integer
    Public patient_name As String
    Public visit_id As Integer
    Public disease As String
    Public d_date As Date
    Public diagnosis_date As Date
    Public time As Date
    Public note As String
    Public other As String
    Public treatment As String
    Public lang As String
    Sub New()
        Me.id = 0
    End Sub
End Class
