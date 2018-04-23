Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports WindowsApplication1.Properties
Imports DevExpress.LookAndFeel

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ChangeSkinElement()
            SetElementImage(GetCurrentSkin(), Resources.formbuttonhelp)
			LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
		End Sub

		Private Function GetCurrentSkin() As Skin
			Return FormSkins.GetSkin(defaultLookAndFeel1.LookAndFeel.ActiveLookAndFeel)
		End Function
		Public Sub SetElementImage(ByVal currentSkin As Skin, ByVal image As Image)
			Dim element = currentSkin(FormSkins.SkinFormButtonClose)
			element.SetActualImage(image, True)
		End Sub
		Private i As Integer
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			i += 1
			Dim index = i Mod SkinManager.Default.Skins.Count
			defaultLookAndFeel1.LookAndFeel.SkinName = SkinManager.Default.Skins(index).SkinName
			If checkEdit1.Checked Then
				ChangeSkinElement()
			End If
			Text = defaultLookAndFeel1.LookAndFeel.SkinName
		End Sub
	End Class
End Namespace
