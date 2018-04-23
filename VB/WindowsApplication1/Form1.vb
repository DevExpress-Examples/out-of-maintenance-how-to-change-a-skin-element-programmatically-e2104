Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ChangeSkinElement()
            SetElementImage(GetCurrentSkin(), Global.My.Resources.formbuttonhelp)
			LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
		End Sub

		Private Function GetCurrentSkin() As Skin
			Return FormSkins.GetSkin(defaultLookAndFeel1.LookAndFeel.ActiveLookAndFeel)
		End Function

		Public Sub SetElementImage(ByVal currentSkin As Skin, ByVal image As Image)
			Dim element As SkinElement = currentSkin(FormSkins.SkinFormButtonClose)
			element.Image.Image = image
		End Sub

		Private i As Integer

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			i += 1
			Dim index As Integer = i Mod SkinManager.Default.Skins.Count
			defaultLookAndFeel1.LookAndFeel.SkinName = SkinManager.Default.Skins(index).SkinName
			If checkEdit1.Checked Then
				ChangeSkinElement()
			End If
			Text = defaultLookAndFeel1.LookAndFeel.SkinName
		End Sub
	End Class
End Namespace