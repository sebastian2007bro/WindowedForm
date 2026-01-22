Imports TouchTest
Imports System.Windows.Forms

Public Class MainClass
    Implements TouchTest.Q_U_U_U_Q_I

    Public Shared WindowController As WindowController

    Public Shared Form1 As Form1
    Public Shared UI As UI

    Public ReadOnly Property Name As String Implements Q_U_U_U_Q_I.Name
        Get
            Return "WindowedForm"
        End Get
    End Property

    Public Sub ExecuteDebug(mainForm As Form1) Implements Q_U_U_U_Q_I.ExecuteDebug
        Form1 = mainForm
        WindowController = New WindowController
    End Sub

    Public Sub ExecuteUISubs(mainForm As UI) Implements Q_U_U_U_Q_I.ExecuteUISubs
        UI = mainForm
        WindowController.StartTimer()
    End Sub


End Class
