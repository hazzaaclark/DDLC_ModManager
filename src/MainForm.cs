using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DDLC_ModManager
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FORM_LOAD(object sender, EventArgs e)
        {
            var MSM = MaterialSkinManager.Instance;
            MSM.AddFormToManage(this);
            MSM.Theme = MaterialSkinManager.Themes.DARK;
            MSM.ColorScheme = new ColorScheme(Primary.DeepPurple900,
                                              Primary.DeepPurple700,
                                              Primary.DeepPurple400,
                                              Accent.Pink200,
                                              TextShade.WHITE);
        }
    }
}
