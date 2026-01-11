Imports TouchTest
Imports System.Windows.Forms

Public Class MainClass
    Implements TouchTest.Q_U_U_U_Q_I

    Public Shared Form1 As Form1
    Public Shared UI As UI

    Public ReadOnly Property Name As String Implements Q_U_U_U_Q_I.Name
        Get
            Return "WindowedForm"
        End Get
    End Property

    Public Sub ExecuteDebug(mainForm As Form1) Implements Q_U_U_U_Q_I.ExecuteDebug
        Form1 = mainForm
    End Sub

    Public Sub ExecuteUISubs(mainForm As UI) Implements Q_U_U_U_Q_I.ExecuteUISubs
        UI = mainForm
    End Sub

    Public WithEvents WindowedFormTimer As New Timer With {.Interval = 1000, .Enabled = True}

    Public Sub WindowedFormTimer_Tick(sender As Object, e As EventArgs) Handles WindowedFormTimer.Tick
        If Form1.currentForm IsNot Nothing Then
            If Form1.currentForm.FormBorderStyle = FormBorderStyle.None Then
                Form1.currentForm.FormBorderStyle = FormBorderStyle.Sizable
            End If
        End If
    End Sub
End Class
