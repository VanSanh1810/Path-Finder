using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            
            cbtn_shw_inf.Checked = SETTING_STATIC_VARS.Show_Info;
            btn_color_start.BackColor = SETTING_STATIC_VARS.StartNode_Color;
            btn_color_end.BackColor = SETTING_STATIC_VARS.EndNode_Color;
            btn_color_block.BackColor = SETTING_STATIC_VARS.BlockNode_Color;
            btn_color_way.BackColor = SETTING_STATIC_VARS.WayNode_Color;
            cbtn_usepthW.Checked = SETTING_STATIC_VARS.Use_PathWeight;
            cbx_IgnoreDelay.Checked = SETTING_STATIC_VARS.IgnoreDelay_mazGen;
            switch ((int)SETTING_STATIC_VARS._MAZE_GEN_ALG)
            {
                case 0: //DFS
                    {
                        rbtn_maz_gen_DFS.Checked = true;
                        rbtn_maz_gen_PRIM.Checked = false;
                        break;
                    }
                case 1: //PRIM
                    {
                        rbtn_maz_gen_DFS.Checked = false;
                        rbtn_maz_gen_PRIM.Checked = true;
                        break;
                    }
            }
            button1.Enabled = false;
        }

        private void btn_color_start_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = true;
                btn_color_start.BackColor = colorDialog1.Color;
            }
        }

        private void btn_color_end_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = true;
                btn_color_end.BackColor = colorDialog1.Color;
            }
        }

        private void btn_color_block_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = true;
                btn_color_block.BackColor = colorDialog1.Color;
            }
        }

        private void cbtn_shw_inf_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"SUCCESS","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            SETTING_STATIC_VARS.StartNode_Color = btn_color_start.BackColor;
            SETTING_STATIC_VARS.BlockNode_Color = btn_color_block.BackColor;
            SETTING_STATIC_VARS.EndNode_Color = btn_color_end.BackColor;
            SETTING_STATIC_VARS.WayNode_Color = btn_color_way.BackColor;
            SETTING_STATIC_VARS.Show_Info = cbtn_shw_inf.Checked;
            SETTING_STATIC_VARS.Use_PathWeight = cbtn_usepthW.Checked;
            SETTING_STATIC_VARS.IgnoreDelay_mazGen = cbx_IgnoreDelay.Checked;
            if (rbtn_maz_gen_DFS.Checked)
            {
                SETTING_STATIC_VARS._MAZE_GEN_ALG = SETTING_STATIC_VARS.MAZE_GEN_ALG.DFS;
            }
            else
            {
                SETTING_STATIC_VARS._MAZE_GEN_ALG = SETTING_STATIC_VARS.MAZE_GEN_ALG.PRIM;
            }
            Button tmp = (Button)sender;
            tmp.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbtn_usepthW_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void SettingForm_Deactivate(object sender, EventArgs e)
        {
            //this.Activate();
            this.Focus();
        }

        private void cbx_IgnoreDelay_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void btn_color_way_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = true;
                btn_color_way.BackColor = colorDialog1.Color;
            }
        }
    }
}
