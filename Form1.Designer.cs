
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ran_obs = new System.Windows.Forms.Button();
            this.btn_ran_maze = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btn_pause = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_step = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AlgorithmsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_map_reset = new System.Windows.Forms.Button();
            this.btn_path_reset = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 611);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btn_setting);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(976, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 611);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btn_ran_obs);
            this.panel5.Controls.Add(this.btn_ran_maze);
            this.panel5.Location = new System.Drawing.Point(3, 291);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(226, 101);
            this.panel5.TabIndex = 24;
            // 
            // btn_ran_obs
            // 
            this.btn_ran_obs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_ran_obs.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ran_obs.Location = new System.Drawing.Point(120, 3);
            this.btn_ran_obs.Name = "btn_ran_obs";
            this.btn_ran_obs.Size = new System.Drawing.Size(99, 91);
            this.btn_ran_obs.TabIndex = 1;
            this.btn_ran_obs.Text = "RANDOM OBSTACLE GENERATOR";
            this.btn_ran_obs.UseVisualStyleBackColor = false;
            this.btn_ran_obs.Click += new System.EventHandler(this.btn_ran_obs_Click);
            // 
            // btn_ran_maze
            // 
            this.btn_ran_maze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ran_maze.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ran_maze.Location = new System.Drawing.Point(3, 3);
            this.btn_ran_maze.Name = "btn_ran_maze";
            this.btn_ran_maze.Size = new System.Drawing.Size(99, 91);
            this.btn_ran_maze.TabIndex = 0;
            this.btn_ran_maze.Text = "MAZE GENERATOR";
            this.btn_ran_maze.UseVisualStyleBackColor = false;
            this.btn_ran_maze.Click += new System.EventHandler(this.btn_ran_maze_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("UTM Showcard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(4, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 46);
            this.label5.TabIndex = 22;
            this.label5.Text = "PATH FINDER";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btn_stop);
            this.panel4.Controls.Add(this.btn_start);
            this.panel4.Controls.Add(this.numericUpDown2);
            this.panel4.Controls.Add(this.btn_pause);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lb_step);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.AlgorithmsComboBox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lb_time);
            this.panel4.Location = new System.Drawing.Point(3, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 196);
            this.panel4.TabIndex = 23;
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_stop.Font = new System.Drawing.Font("UTM Daxline Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(158, 160);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(60, 33);
            this.btn_stop.TabIndex = 13;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            this.btn_stop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_start.Font = new System.Drawing.Font("UTM Daxline Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(3, 160);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(68, 33);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(94, 103);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_pause.Font = new System.Drawing.Font("UTM Daxline Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.Location = new System.Drawing.Point(77, 160);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 33);
            this.btn_pause.TabIndex = 12;
            this.btn_pause.Text = "PAUSE";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            this.btn_pause.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Cookies", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "DELAY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Cookies", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ALGORITHM";
            // 
            // lb_step
            // 
            this.lb_step.AutoSize = true;
            this.lb_step.Font = new System.Drawing.Font("UTM Cookies", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_step.Location = new System.Drawing.Point(133, 42);
            this.lb_step.Name = "lb_step";
            this.lb_step.Size = new System.Drawing.Size(24, 25);
            this.lb_step.TabIndex = 21;
            this.lb_step.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Cookies", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "STEP";
            // 
            // AlgorithmsComboBox
            // 
            this.AlgorithmsComboBox.FormattingEnabled = true;
            this.AlgorithmsComboBox.Location = new System.Drawing.Point(93, 131);
            this.AlgorithmsComboBox.Name = "AlgorithmsComboBox";
            this.AlgorithmsComboBox.Size = new System.Drawing.Size(121, 21);
            this.AlgorithmsComboBox.TabIndex = 9;
            this.AlgorithmsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Cookies", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "TIME";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("UTM Cookies", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(41, 42);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(52, 25);
            this.lb_time.TabIndex = 19;
            this.lb_time.Text = "0 ms";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.groupBox1.Controls.Add(this.btn_map_reset);
            this.groupBox1.Controls.Add(this.btn_path_reset);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 55);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESET";
            // 
            // btn_map_reset
            // 
            this.btn_map_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_map_reset.Font = new System.Drawing.Font("UTM Daxline Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_map_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_map_reset.Location = new System.Drawing.Point(122, 19);
            this.btn_map_reset.Name = "btn_map_reset";
            this.btn_map_reset.Size = new System.Drawing.Size(98, 28);
            this.btn_map_reset.TabIndex = 15;
            this.btn_map_reset.Text = "MAP RESET";
            this.toolTip1.SetToolTip(this.btn_map_reset, "Clear all map");
            this.btn_map_reset.UseVisualStyleBackColor = false;
            this.btn_map_reset.Click += new System.EventHandler(this.btn_map_reset_Click);
            this.btn_map_reset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // btn_path_reset
            // 
            this.btn_path_reset.BackColor = System.Drawing.Color.Red;
            this.btn_path_reset.Font = new System.Drawing.Font("UTM Daxline Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_path_reset.Location = new System.Drawing.Point(6, 19);
            this.btn_path_reset.Name = "btn_path_reset";
            this.btn_path_reset.Size = new System.Drawing.Size(98, 28);
            this.btn_path_reset.TabIndex = 14;
            this.btn_path_reset.Text = "PATH RESET";
            this.toolTip1.SetToolTip(this.btn_path_reset, "Clear the path found by the current algorithm");
            this.btn_path_reset.UseVisualStyleBackColor = false;
            this.btn_path_reset.Click += new System.EventHandler(this.btn_path_reset_Click);
            this.btn_path_reset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_setting.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.Location = new System.Drawing.Point(3, 552);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(226, 31);
            this.btn_setting.TabIndex = 10;
            this.btn_setting.Text = "SETTING";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            this.btn_setting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(3, 398);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 87);
            this.panel3.TabIndex = 7;
            this.toolTip1.SetToolTip(this.panel3, "PEN INFO");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Cookies", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "TYPE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Cookies", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "PEN";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(93, 55);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Cookies", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "WEIGHT";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.DimGray;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(3, 589);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 19);
            this.progressBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1220, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PATH FINDER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AlgorithmsComboBox;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_path_reset;
        private System.Windows.Forms.Button btn_map_reset;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_time;
        public System.Windows.Forms.Label lb_step;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_ran_maze;
        private System.Windows.Forms.Button btn_ran_obs;
    }

   
}

