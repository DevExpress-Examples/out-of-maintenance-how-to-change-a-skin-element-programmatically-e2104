using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using WindowsApplication1.Properties;
using DevExpress.LookAndFeel;

namespace WindowsApplication1 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void ChangeSkinElement() {
            SetElementImage(GetCurrentSkin(), Resources.formbuttonhelp);
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }

        private Skin GetCurrentSkin() {
            return FormSkins.GetSkin(defaultLookAndFeel1.LookAndFeel.ActiveLookAndFeel);
        }
        public void SetElementImage(Skin currentSkin, Image image) {
            var element = currentSkin[FormSkins.SkinFormButtonClose];
            element.SetActualImage(image, true);
        }
        private int i;
        private void simpleButton1_Click(object sender, EventArgs e) {
            i++;
            var index = i % SkinManager.Default.Skins.Count;
            defaultLookAndFeel1.LookAndFeel.SkinName = SkinManager.Default.Skins[index].SkinName;
            if (checkEdit1.Checked) {
                ChangeSkinElement();
            }
            Text = defaultLookAndFeel1.LookAndFeel.SkinName;
        }
    }
}
