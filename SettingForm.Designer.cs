
namespace WindowsFormsApp1
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_color_start = new System.Windows.Forms.Button();
            this.cbtn_shw_inf = new System.Windows.Forms.CheckBox();
            this.toolTip_ShowInf = new System.Windows.Forms.ToolTip(this.components);
            this.btn_color_end = new System.Windows.Forms.Button();
            this.btn_color_block = new System.Windows.Forms.Button();
            this.cbtn_usepthW = new System.Windows.Forms.CheckBox();
            this.cbx_IgnoreDelay = new System.Windows.Forms.CheckBox();
            this.btn_color_way = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_maz_gen_PRIM = new System.Windows.Forms.RadioButton();
            this.rbtn_maz_gen_DFS = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Akashi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "SETTING";
            // 
            // btn_color_start
            // 
            this.btn_color_start.Location = new System.Drawing.Point(6, 19);
            this.btn_color_start.Name = "btn_color_start";
            this.btn_color_start.Size = new System.Drawing.Size(40, 40);
            this.btn_color_start.TabIndex = 2;
            this.toolTip_ShowInf.SetToolTip(this.btn_color_start, "Chose the color of Start Node");
            this.btn_color_start.UseVisualStyleBackColor = true;
            this.btn_color_start.Click += new System.EventHandler(this.btn_color_start_Click);
            // 
            // cbtn_shw_inf
            // 
            this.cbtn_shw_inf.AutoSize = true;
            this.cbtn_shw_inf.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtn_shw_inf.Location = new System.Drawing.Point(3, 29);
            this.cbtn_shw_inf.Name = "cbtn_shw_inf";
            this.cbtn_shw_inf.Size = new System.Drawing.Size(156, 20);
            this.cbtn_shw_inf.TabIndex = 3;
            this.cbtn_shw_inf.Text = "Show Node Infomation";
            this.toolTip_ShowInf.SetToolTip(this.cbtn_shw_inf, "Select if you want to show node information every time you hover over that node");
            this.cbtn_shw_inf.UseVisualStyleBackColor = true;
            this.cbtn_shw_inf.CheckedChanged += new System.EventHandler(this.cbtn_shw_inf_CheckedChanged);
            // 
            // toolTip_ShowInf
            // 
            this.toolTip_ShowInf.ForeColor = System.Drawing.Color.SkyBlue;
            this.toolTip_ShowInf.IsBalloon = true;
            this.toolTip_ShowInf.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btn_color_end
            // 
            this.btn_color_end.Location = new System.Drawing.Point(52, 19);
            this.btn_color_end.Name = "btn_color_end";
            this.btn_color_end.Size = new System.Drawing.Size(40, 40);
            this.btn_color_end.TabIndex = 4;
            this.toolTip_ShowInf.SetToolTip(this.btn_color_end, "Chose the color of End Node");
            this.btn_color_end.UseVisualStyleBackColor = true;
            this.btn_color_end.Click += new System.EventHandler(this.btn_color_end_Click);
            // 
            // btn_color_block
            // 
            this.btn_color_block.Location = new System.Drawing.Point(100, 19);
            this.btn_color_block.Name = "btn_color_block";
            this.btn_color_block.Size = new System.Drawing.Size(40, 40);
            this.btn_color_block.TabIndex = 5;
            this.toolTip_ShowInf.SetToolTip(this.btn_color_block, "Chose the color of Block Node");
            this.btn_color_block.UseVisualStyleBackColor = true;
            this.btn_color_block.Click += new System.EventHandler(this.btn_color_block_Click);
            // 
            // cbtn_usepthW
            // 
            this.cbtn_usepthW.AutoSize = true;
            this.cbtn_usepthW.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtn_usepthW.Location = new System.Drawing.Point(3, 52);
            this.cbtn_usepthW.Name = "cbtn_usepthW";
            this.cbtn_usepthW.Size = new System.Drawing.Size(122, 20);
            this.cbtn_usepthW.TabIndex = 10;
            this.cbtn_usepthW.Text = "Use Path Weight";
            this.toolTip_ShowInf.SetToolTip(this.cbtn_usepthW, "Select if you want to use weight value (if not, the default value is 1)");
            this.cbtn_usepthW.UseVisualStyleBackColor = true;
            this.cbtn_usepthW.CheckedChanged += new System.EventHandler(this.cbtn_usepthW_CheckedChanged);
            // 
            // cbx_IgnoreDelay
            // 
            this.cbx_IgnoreDelay.AutoSize = true;
            this.cbx_IgnoreDelay.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_IgnoreDelay.Location = new System.Drawing.Point(10, 150);
            this.cbx_IgnoreDelay.Name = "cbx_IgnoreDelay";
            this.cbx_IgnoreDelay.Size = new System.Drawing.Size(128, 20);
            this.cbx_IgnoreDelay.TabIndex = 15;
            this.cbx_IgnoreDelay.Text = "Ignore delay time";
            this.toolTip_ShowInf.SetToolTip(this.cbx_IgnoreDelay, "Click if you don\'t want to see the generation process (still have program delay t" +
        "imes)");
            this.cbx_IgnoreDelay.UseVisualStyleBackColor = true;
            this.cbx_IgnoreDelay.CheckedChanged += new System.EventHandler(this.cbx_IgnoreDelay_CheckedChanged);
            // 
            // btn_color_way
            // 
            this.btn_color_way.Location = new System.Drawing.Point(146, 19);
            this.btn_color_way.Name = "btn_color_way";
            this.btn_color_way.Size = new System.Drawing.Size(40, 40);
            this.btn_color_way.TabIndex = 6;
            this.toolTip_ShowInf.SetToolTip(this.btn_color_way, "Chose the color of Way Node");
            this.btn_color_way.UseVisualStyleBackColor = true;
            this.btn_color_way.Click += new System.EventHandler(this.btn_color_way_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.AnyColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "CONFIRM CHANGE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(304, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_color_way);
            this.groupBox1.Controls.Add(this.btn_color_start);
            this.groupBox1.Controls.Add(this.btn_color_end);
            this.groupBox1.Controls.Add(this.btn_color_block);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Picker";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbtn_shw_inf);
            this.panel1.Controls.Add(this.cbtn_usepthW);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 255);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "PATH FINDER";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.cbx_IgnoreDelay);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(292, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 255);
            this.panel2.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_maz_gen_PRIM);
            this.groupBox2.Controls.Add(this.rbtn_maz_gen_DFS);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 112);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maze Generation Algorithms";
            // 
            // rbtn_maz_gen_PRIM
            // 
            this.rbtn_maz_gen_PRIM.AutoSize = true;
            this.rbtn_maz_gen_PRIM.Location = new System.Drawing.Point(6, 42);
            this.rbtn_maz_gen_PRIM.Name = "rbtn_maz_gen_PRIM";
            this.rbtn_maz_gen_PRIM.Size = new System.Drawing.Size(52, 20);
            this.rbtn_maz_gen_PRIM.TabIndex = 14;
            this.rbtn_maz_gen_PRIM.Text = "Prim";
            this.rbtn_maz_gen_PRIM.UseVisualStyleBackColor = true;
            this.rbtn_maz_gen_PRIM.CheckedChanged += new System.EventHandler(this.cbx_IgnoreDelay_CheckedChanged);
            // 
            // rbtn_maz_gen_DFS
            // 
            this.rbtn_maz_gen_DFS.AutoSize = true;
            this.rbtn_maz_gen_DFS.Checked = true;
            this.rbtn_maz_gen_DFS.Location = new System.Drawing.Point(6, 19);
            this.rbtn_maz_gen_DFS.Name = "rbtn_maz_gen_DFS";
            this.rbtn_maz_gen_DFS.Size = new System.Drawing.Size(49, 20);
            this.rbtn_maz_gen_DFS.TabIndex = 13;
            this.rbtn_maz_gen_DFS.TabStop = true;
            this.rbtn_maz_gen_DFS.Text = "DFS";
            this.rbtn_maz_gen_DFS.UseVisualStyleBackColor = true;
            this.rbtn_maz_gen_DFS.CheckedChanged += new System.EventHandler(this.cbx_IgnoreDelay_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "MAZE GENERATOR";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 395);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(589, 434);
            this.MinimumSize = new System.Drawing.Size(589, 434);
            this.Name = "SettingForm";
            this.Text = "SETTING";
            this.Deactivate += new System.EventHandler(this.SettingForm_Deactivate);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_color_start;
        private System.Windows.Forms.CheckBox cbtn_shw_inf;
        private System.Windows.Forms.ToolTip toolTip_ShowInf;
        private System.Windows.Forms.Button btn_color_end;
        private System.Windows.Forms.Button btn_color_block;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbtn_usepthW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_maz_gen_PRIM;
        private System.Windows.Forms.RadioButton rbtn_maz_gen_DFS;
        private System.Windows.Forms.CheckBox cbx_IgnoreDelay;
        private System.Windows.Forms.Button btn_color_way;
    }
}