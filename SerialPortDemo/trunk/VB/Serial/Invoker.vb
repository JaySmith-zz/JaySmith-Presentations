Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text

Public Class Invoker

    Public Shared Sub Invoke(ByVal delegateToCall As [Delegate], ByVal argsOfDelegateToCall As Object())

        Dim del As [Delegate]

        For Each del In delegateToCall.GetInvocationList()

            Dim si As ISynchronizeInvoke = CType(del.Target.Target, ISynchronizeInvoke)

            If si IsNot Nothing AndAlso si.InvokeRequired Then
                si.Invoke(del, argsOfDelegateToCall)
            Else
                del.DynamicInvoke(argsOfDelegateToCall)
            End If

        Next

    End Sub

End Class

