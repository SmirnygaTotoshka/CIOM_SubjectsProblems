Sub ConslidateWorkbooks()
'Created by Sumit Bansal from https://trumpexcel.com
Dim FolderPath As String
Dim Filename As String
Dim Sheet As Worksheet
Application.ScreenUpdating = False
FolderPath = "C:\Users\SmirnygaTotoshka\Desktop\RWorkspace\Results\"
Filename = Dir(FolderPath & "*.xls*")
Do While Filename <> ""
 Workbooks.Open Filename:=FolderPath & Filename, ReadOnly:=True
 For Each Sheet In ActiveWorkbook.Sheets
 Sheet.Copy After:=ThisWorkbook.Sheets(1)
 Next Sheet
 Workbooks(Filename).Close
 Filename = Dir()
Loop
Application.ScreenUpdating = True
End Sub