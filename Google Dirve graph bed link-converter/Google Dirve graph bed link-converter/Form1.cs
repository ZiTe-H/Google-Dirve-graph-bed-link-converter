using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Dirve_graph_bed_link_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Defaulf link type
            rbtn_ImportLinkType1.Checked = true;
            rbtn_ExportLinkType1.Checked = true;
        }

        private void rbtn_LinkType1_CheckedChanged(object sender, EventArgs e)
        {
            lb_LinkExample.Text = @"結果範例：https://drive.google.com/uc?export=view&id=FILEID";
        }

        private void rbtn_LinkType2_CheckedChanged(object sender, EventArgs e)
        {
            lb_LinkExample.Text = @"結果範例：https://drive.google.com/uc?export=download&id=FILEID";
        }

        private void btn_Convent_Click(object sender, EventArgs e)
        {
            string ConvertedLink = tb_LinkImport.Text;

            /*
             * Import link example:
             * https://drive.google.com/file/d/1FLHQhNBsVat2K2Tyvn_RPZe7Zm5J2-sg/view?usp=sharing
             * https://drive.google.com/open?id=1FLHQhNBsVat2K2Tyvn_RPZe7Zm5J2-sg
            */

            // Import link type
            if (rbtn_ImportLinkType2.Checked == true)
            {
                ConvertedLink = ConvertedLink.Replace("/view?usp=sharing", "");
                ConvertedLink = ConvertedLink.Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?export=[EXPORTLINKTYPE]&id=");
            }
            else
            {
                ConvertedLink = ConvertedLink.Replace("https://drive.google.com/open?id=", "https://drive.google.com/uc?export=[EXPORTLINKTYPE]&id=");
            }

            // Export link type
            if (rbtn_ExportLinkType2.Checked == true)   // Link type:download
            {
                ConvertedLink = ConvertedLink.Replace("[EXPORTLINKTYPE]", "download");
            }
            else                                        // Link type:view
            {
                ConvertedLink = ConvertedLink.Replace("[EXPORTLINKTYPE]", "view");
            }

            // Print
            tb_LinkExport.Text = ConvertedLink;
        }
    }
}
