'Imports System

'Module Program
'    Sub Main(args As String())
'        Console.WriteLine("Hello World!")
'    End Sub
'End Module

'Create a simple WebApplication In .Net Framework Using VB. 
'Add refernce Of the C# project Then write the following codes 



'/// <summary> Cross language , cross library - Shyed Shahriar Housaini , MCSE 07905536 </summary>
Imports System
Imports ClassLibraryCrossPlatformAPP.Class
Module Program
    Dim obj As New ClassLibraryCrossPlatformAPP.Class
    Sub Main(args As String())
        Console.WriteLine("Cross language, cross library - Shyed Shahriar Housaini , MCSE 07905536")
        Console.WriteLine("Adding")
        Console.WriteLine(obj.Sum(2, 3))
        Console.WriteLine("Subtraction")
        Console.WriteLine(obj.Sub(2, 3))
        Console.WriteLine("Multiplication")
        Console.WriteLine(obj.Multi(2, 3))
        Console.ReadKey()
    End Sub
End Module
'Execute the VB program with C# modules.