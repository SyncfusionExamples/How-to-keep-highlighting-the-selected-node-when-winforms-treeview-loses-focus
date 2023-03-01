Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing
Imports System.Windows.Forms

Namespace TreeViewAdvDemo
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

			Me.treeViewAdv1.SelectionMode = TreeSelectionMode.MultiSelectAll

			' To ensure that the selected node is highlighted always
			Me.treeViewAdv1.HideSelection = False

			' The appearence of selection rectangle can be changed by following property
			' To identify selected node is highlighted or not when TreeViewAdv loses focus           
			' Set custom colors to the selection rectangle
			Me.treeViewAdv1.InactiveSelectedNodeBackground = New BrushInfo(Color.Green)
			Me.treeViewAdv1.InactiveSelectedNodeForeColor = Color.White
		End Sub
	End Class
End Namespace