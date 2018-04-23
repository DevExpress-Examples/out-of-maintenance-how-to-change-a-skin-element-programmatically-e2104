using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using WindowsApplication1.Properties;
using DevExpress.LookAndFeel;

namespace WindowsApplication1
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ChangeSkinElement()
        {
            SetElementImage(GetCurrentSkin(), Resources.formbuttonhelp);
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }

        Skin GetCurrentSkin()
        {
            return FormSkins.GetSkin(defaultLookAndFeel1.LookAndFeel.ActiveLookAndFeel);
        }

        public void SetElementImage(Skin currentSkin, Image image)
        {
            SkinElement element = currentSkin[FormSkins.SkinFormButtonClose];
            element.Image.Image = image;
        }

        int i;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            i++;
            int index = i % SkinManager.Default.Skins.Count;
            defaultLookAndFeel1.LookAndFeel.SkinName = SkinManager.Default.Skins[index].SkinName;
            if (checkEdit1.Checked)
                ChangeSkinElement();
            Text = defaultLookAndFeel1.LookAndFeel.SkinName;
        }
    }
}