using System;
using System.Threading;
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
    public partial class Form1 : Form
    {

        NODE[,] MAP = new NODE[PROGRAM_STATIC_VARS.main_H, PROGRAM_STATIC_VARS.main_W];

        private delegate void StepChangeHandle(int _step);
        private event StepChangeHandle StepChange;
        private int TimerVal = 0;
        public int step
        {
            get { return this.step; }
            set => StepChange?.Invoke(value);
        }
        private int IsTimming = 0; // -1 stop 1 timming 0 pause

        
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            GenarateMap();
            AddItemToComboBox();
            //Basic setup
            label6.Text = "PEN: NONE";
            label7.Text = "TYPE: PATH";
            label7.ForeColor = SETTING_STATIC_VARS.PathNode_Color;
            AlgorithmsComboBox.SelectedIndex = 0;
            btn_start.Enabled = true;
            btn_pause.Enabled = false;
            btn_stop.Enabled = false;
            PROGRAM_STATIC_THREAD.ChangeProcessState += PROGRAM_STATIC_THREAD_ChangeProcessState; //Sự kiện thay đổi biên InProcess
            PROGRAM_STATIC_THREAD.In_Process = false;
            this.StepChange += Form1_StepChange;
            step = 0;
        }

        private void Form1_StepChange(int _step)
        {
            lb_step.Text = _step.ToString();
        }




        #region Setup cơ bản
        public void AddItemToComboBox()
        {
            AlgorithmsComboBox.Items.Add(new ComboBoxItem("A*", 0));
            AlgorithmsComboBox.Items.Add(new ComboBoxItem("UCS", 1));
            AlgorithmsComboBox.Items.Add(new ComboBoxItem("BFS", 2));
            AlgorithmsComboBox.Items.Add(new ComboBoxItem("DFS", 3));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenarateMap()
        {
            for(int i = 0; i < PROGRAM_STATIC_VARS.main_H; i++)
            {
                for (int j = 0; j < PROGRAM_STATIC_VARS.main_W; j++)
                {
                    int tmp = i * PROGRAM_STATIC_VARS.main_W + j; //Name
                    int x = PROGRAM_STATIC_VARS.main_loc + PROGRAM_STATIC_VARS.point_size * j - j; //Location X
                    int y = PROGRAM_STATIC_VARS.main_loc + PROGRAM_STATIC_VARS.point_size * i - i; //Location Y
                    PictureBox tmp_pic = CreatepictureBox(x, y, tmp.ToString());

                    
                    MAP[i, j] = new NODE();
                    MAP[i, j].loc_X = x;
                    MAP[i, j].loc_Y = y;
                    MAP[i, j].index_X = i;
                    MAP[i, j].index_Y = j;
                    MAP[i, j].Name = tmp.ToString();
                    MAP[i, j].Name_INT = tmp;
                    MAP[i, j].pictureBox = tmp_pic;

                    panel1.Controls.Add(tmp_pic);
                }
                progressBar1.Value = 100/ PROGRAM_STATIC_VARS.main_H * i;
            }
            progressBar1.Visible = false;
        }
        PictureBox CreatepictureBox(int x, int y, string name)
        {
            PictureBox p = new PictureBox();
            
            p.Name = name;
            p.Location = new Point(x, y);
            p.Size = new Size(PROGRAM_STATIC_VARS.point_size, PROGRAM_STATIC_VARS.point_size);
            p.BackColor = SETTING_STATIC_VARS.PathNode_Color;
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Cursor = Cursors.Cross;

            #region EVENT
            p.MouseMove += new MouseEventHandler(this.Dinamic_MouseMove);
            p.MouseWheel += new MouseEventHandler(this.Dinamic_MouseWheel);

            p.MouseDoubleClick += new MouseEventHandler(this.Dinamic_MouseDoubleClick);

            p.MouseHover += new EventHandler(this.Dinamic_MouseHover);
            p.MouseLeave += new EventHandler(this.Dinamic_MouseLeave);
            p.MouseEnter += new EventHandler(this.Dinamic_MouseEnter);
            #endregion

            return p;
        }
        #endregion



        #region Hiệu ứng Di chuột vào NODE
        public void Dinamic_MouseHover(object sender, EventArgs e) //Hiển thị thông tin mỗi khi đưa chuột vào NODE
        {

            if (SETTING_STATIC_VARS.Show_Info)
            {
                PictureBox tmp_pic = (PictureBox)sender;

                int Name_INT = Convert.ToInt32(tmp_pic.Name);
                int i = Name_INT / PROGRAM_STATIC_VARS.main_W;
                int j = Name_INT % PROGRAM_STATIC_VARS.main_W;

                string tmp_string = "Name : " + MAP[i, j].Name + "\nType: " + MAP[i, j].Type_N.ToString()
                                    + "\n(" + i + ", " + j + ")"
                                    + "\nCost : " + MAP[i, j].Cost; ;
                if (MAP[i, j].toolTip == null)
                {
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(tmp_pic, tmp_string);
                    toolTip.ToolTipTitle = "INFOMATION";
                    toolTip.ToolTipIcon = ToolTipIcon.Info;
                    MAP[i, j].toolTip = toolTip;
                }
                else
                {
                    MAP[i, j].toolTip.SetToolTip(MAP[i, j].pictureBox, tmp_string);
                    MAP[i, j].toolTip.ToolTipTitle = "INFOMATION";
                    MAP[i, j].toolTip.ToolTipIcon = ToolTipIcon.Info;
                }
            }
        }

        
        public void Dinamic_MouseLeave(object sender, EventArgs e)
        {

            if (PROGRAM_STATIC_VARS.Mouse_State == 0)
            {
                PictureBox tmp_pic = (PictureBox)sender;
                tmp_pic.BackColor = SETTING_STATIC_VARS.Pre_Color;
            }
        }

        public void Dinamic_MouseEnter(object sender, EventArgs e)
        {
            if(PROGRAM_STATIC_VARS.Mouse_State == 0)
            {
                PictureBox tmp_pic = (PictureBox)sender;
                SETTING_STATIC_VARS.Pre_Color = tmp_pic.BackColor;
                tmp_pic.BackColor = ControlPaint.LightLight(tmp_pic.BackColor);
            }
        }
        #endregion


        #region Event Vẽ trên map
        public void Dinamic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(PROGRAM_STATIC_VARS.Mouse_State == -1) //POINT Mouse State
            {
                switch (e.Button)
                {
                    case MouseButtons.Left: //Start Node
                        {
                            if (PROGRAM_STATIC_VARS.Have_Start == null)
                            {
                                PROGRAM_STATIC_VARS.Have_Start = (PictureBox)sender;
                                PROGRAM_STATIC_VARS.Have_Start.BackColor = SETTING_STATIC_VARS.StartNode_Color;
                            }
                            else
                            {
                                ////////////////////////////////////////////////old Start
                                int Name_INT1 = Convert.ToInt32(PROGRAM_STATIC_VARS.Have_Start.Name);
                                int i1 = Name_INT1 / PROGRAM_STATIC_VARS.main_W;
                                int j1 = Name_INT1 % PROGRAM_STATIC_VARS.main_W;
                                MAP[i1, j1].Type_N = NODE.Type_Node.PATH_NODE;
                                MAP[i1, j1].Cost = 1;
                                PROGRAM_STATIC_VARS.Have_Start.BackColor = SETTING_STATIC_VARS.PathNode_Color;

                                ////////////////////////////////////////////////new Start
                                PROGRAM_STATIC_VARS.Have_Start = (PictureBox)sender;
                                PROGRAM_STATIC_VARS.Have_Start.BackColor = SETTING_STATIC_VARS.StartNode_Color;
                            }

                            int Name_INT = Convert.ToInt32(PROGRAM_STATIC_VARS.Have_Start.Name);
                            int i = Name_INT / PROGRAM_STATIC_VARS.main_W;
                            int j = Name_INT % PROGRAM_STATIC_VARS.main_W;
                            MAP[i, j].Type_N = NODE.Type_Node.START_NODE;
                            MAP[i, j].Cost = 0;
                            PROGRAM_STATIC_VARS.Set_START_LOC(i, j);
                            break;
                        }
                    case MouseButtons.Right: //End Node
                        {
                            if (PROGRAM_STATIC_VARS.Have_End == null)
                            {
                                PROGRAM_STATIC_VARS.Have_End = (PictureBox)sender;
                                PROGRAM_STATIC_VARS.Have_End.BackColor = SETTING_STATIC_VARS.EndNode_Color;
                            }
                            else
                            {
                                /////////////////////////////////////////////////old End
                                int Name_INT1 = Convert.ToInt32(PROGRAM_STATIC_VARS.Have_End.Name);
                                int i1 = Name_INT1 / PROGRAM_STATIC_VARS.main_W;
                                int j1 = Name_INT1 % PROGRAM_STATIC_VARS.main_W;
                                MAP[i1, j1].Type_N = NODE.Type_Node.PATH_NODE;
                                PROGRAM_STATIC_VARS.Have_End.BackColor = SETTING_STATIC_VARS.PathNode_Color;
                                ///////////////////////////////////////////////// new End
                                PROGRAM_STATIC_VARS.Have_End = (PictureBox)sender;
                                PROGRAM_STATIC_VARS.Have_End.BackColor = SETTING_STATIC_VARS.EndNode_Color;
                            }

                            int Name_INT = Convert.ToInt32(PROGRAM_STATIC_VARS.Have_End.Name);
                            int i = Name_INT / PROGRAM_STATIC_VARS.main_W;
                            int j = Name_INT % PROGRAM_STATIC_VARS.main_W;
                            MAP[i, j].Type_N = NODE.Type_Node.END_NODE;
                            PROGRAM_STATIC_VARS.Set_END_LOC(i, j);
                            break;
                        }
                }
            }
            
        } //set start end


        public void Dinamic_MouseWheel(object sender, MouseEventArgs e) //Set Mouse state
        {
            PictureBox tmp_pic = (PictureBox)sender;
            if(e.Delta > 0) //UP
            {
                if(PROGRAM_STATIC_VARS.Mouse_State != 1) 
                {
                    PROGRAM_STATIC_VARS.Mouse_State = PROGRAM_STATIC_VARS.Mouse_State + 1;
                }
            }
            else  //DOWN
            {
                if (PROGRAM_STATIC_VARS.Mouse_State != -2)
                {
                    PROGRAM_STATIC_VARS.Mouse_State = PROGRAM_STATIC_VARS.Mouse_State - 1;
                }
            }

            switch (PROGRAM_STATIC_VARS.Mouse_State)
            {
                case 1: //DRAW
                    {
                        TurnOffEffect(tmp_pic);
                        label6.Text = "PEN: DRAW";
                        label6.ForeColor = Color.Red;
                        break;
                    }
                case 0: //NONE
                    {
                        TurnOnEffect(tmp_pic);
                        label6.Text = "PEN: NONE";
                        label6.ForeColor = Color.Black;
                        break;
                    }
                case -1: //POINT
                    {
                        TurnOffEffect(tmp_pic);
                        label6.Text = "PEN: POINT";
                        label6.ForeColor = Color.Blue;
                        break;
                    }
                case -2: //ERASE
                    {
                        label6.Text = "PEN: ERASE";
                        label6.ForeColor = Color.DarkGray;
                        break;
                    }
            }
        }
        public  void TurnOnEffect(PictureBox tmp_pic)
        {
            SETTING_STATIC_VARS.Pre_Color = tmp_pic.BackColor;
            tmp_pic.BackColor = ControlPaint.LightLight(tmp_pic.BackColor);
        }

        public void TurnOffEffect(PictureBox tmp_pic)
        {
            tmp_pic.BackColor = SETTING_STATIC_VARS.Pre_Color;
        }
        public void Dinamic_MouseMove(object sender, MouseEventArgs e) //Di chuột để vẽ theo loại cọ đc chọn
        {
            if (sender.GetType() == typeof(System.Windows.Forms.PictureBox))
            {
                /*int X = e.X;
                int Y = e.Y;
                lb_step.Text = X.ToString();
                lb_time.Text = Y.ToString();
                if(X<0 || X > 13 || Y < 0 || Y > 13)
                {
                    
                }*/
                
                PictureBox p = (PictureBox)sender;
                int Name_INT = Convert.ToInt32(p.Name);
                int i = Name_INT / PROGRAM_STATIC_VARS.main_W;
                int j = Name_INT % PROGRAM_STATIC_VARS.main_W;
                
                switch (PROGRAM_STATIC_VARS.Mouse_State)
                {
                    case 1: //Draw
                        {
                            
                            switch (PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE)
                            {
                                case PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.PATH:
                                    {
                                        MAP[i, j].Type_N = NODE.Type_Node.PATH_NODE;
                                        MAP[i, j].Cost = Convert.ToInt32(numericUpDown1.Value);
                                        p.BackColor = Color.DarkGray;
                                        
                                        break;
                                    }
                                case PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.BLOCK:
                                    {
                                        MAP[i, j].Type_N = NODE.Type_Node.BLOCK_NODE;
                                        MAP[i, j].Cost = -1;
                                        p.BackColor = Color.Black;
                                        
                                        break;
                                    }
                                
                            }

                            
                            break;
                        }
                    case 0: //None
                        {
                            break;
                        }
                    case -1: //Point
                        {
                            break;
                        }
                    case -2: //Erase
                        {
                            if(MAP[i,j].Type_N == NODE.Type_Node.START_NODE)
                            {
                                PROGRAM_STATIC_VARS.Have_Start = null;
                            }
                            if (MAP[i, j].Type_N == NODE.Type_Node.END_NODE)
                            {
                                PROGRAM_STATIC_VARS.Have_End = null;
                            }
                            p.BackColor = SETTING_STATIC_VARS.PathNode_Color;
                            MAP[i, j].Cost = 1;
                            MAP[i, j].Type_N = NODE.Type_Node.PATH_NODE;

                            break;
                        }
                }

            }
            
        }
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "t")
            {
                PROGRAM_STATIC_VARS.Mouse_State = 0;
                switch (PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE)
                {
                    case PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.PATH:
                        {
                            PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE = PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.BLOCK;
                            numericUpDown1.Enabled = false;
                            label7.Text = "TYPE: BLOCK";
                            label7.ForeColor = SETTING_STATIC_VARS.BlockNode_Color;
                            break;
                        }
                    case PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.BLOCK:
                        {
                            PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE = PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.PATH;
                            numericUpDown1.Enabled = true;
                            label7.Text = "TYPE: PATH";
                            label7.ForeColor = SETTING_STATIC_VARS.PathNode_Color;
                            break;
                        }
                }
                label6.Text = "PEN: NONE";
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "t")
            {
                PROGRAM_STATIC_VARS.Mouse_State = 0;
                switch (PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE)
                {
                    case PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.PATH:
                        {
                            PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE = PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.BLOCK;
                            numericUpDown1.Enabled = false;
                            label7.Text = "TYPE: BLOCK";
                            label7.ForeColor = SETTING_STATIC_VARS.BlockNode_Color;
                            break;
                        }
                    case PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.BLOCK:
                        {
                            PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE = PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.PATH;
                            numericUpDown1.Enabled = true;
                            label7.Text = "TYPE: PATH";
                            label7.ForeColor = SETTING_STATIC_VARS.PathNode_Color;
                            break;
                        }
                }
                label6.Text = "PEN: NONE";
            }
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SETTING_STATIC_VARS.Delay_Time = Convert.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!SETTING_STATIC_VARS.Use_PathWeight)
            {
                numericUpDown1.Value = 1;
            }
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "t")
            {
                PROGRAM_STATIC_VARS.Mouse_State = 0;
                switch (PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE)
                {
                    case PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.PATH:
                        {
                            PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE = PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.BLOCK;
                            numericUpDown1.Enabled = false;
                            label7.Text = "TYPE: BLOCK";
                            label7.ForeColor = SETTING_STATIC_VARS.BlockNode_Color;
                            break;
                        }
                    case PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.BLOCK:
                        {
                            PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE = PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.PATH;
                            numericUpDown1.Enabled = true;
                            label7.Text = "TYPE: PATH";
                            label7.ForeColor = SETTING_STATIC_VARS.PathNode_Color;
                            break;
                        }
                }
                label6.Text = "PEN: NONE";
            }
            e.Handled = true;
        }
        #endregion



        #region Event
        
        private void PROGRAM_STATIC_THREAD_ChangeProcessState(bool State)//Sự kiện thay đổi biên InProcess
        {
            if (State)
            {
                btn_start.Enabled = false;
                btn_pause.Enabled = true;
                btn_stop.Enabled = true;
                AlgorithmsComboBox.Enabled = false;
                btn_setting.Enabled = false;
                btn_map_reset.Enabled = false;
                btn_path_reset.Enabled = false;
                btn_ran_maze.Enabled = false;
                btn_ran_obs.Enabled = false;
                numericUpDown1.Enabled = false;
            }
            else
            {
                btn_start.Enabled = true;
                btn_pause.Enabled = false;
                btn_stop.Enabled = false;
                AlgorithmsComboBox.Enabled = true;
                btn_setting.Enabled = true;
                btn_map_reset.Enabled = true;
                btn_path_reset.Enabled = true;
                btn_ran_maze.Enabled = true;
                btn_ran_obs.Enabled = true;
                numericUpDown1.Enabled = true;
                PROGRAM_STATIC_VARS.Set_DrawPointer(null);
            }
        }
        private void btn_setting_Click(object sender, EventArgs e)
        {
            SettingForm a = new SettingForm();
            a.ShowDialog();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (PROGRAM_STATIC_VARS.Have_Start != null && PROGRAM_STATIC_VARS.Have_End != null)
            {
                ComboBoxItem tmp = (ComboBoxItem)AlgorithmsComboBox.SelectedItem;
                switch (tmp.Value)
                {
                    case 0: //A*
                        {
                            A_star a = new A_star(MAP, sender);
                            ThreadStart threadStart = new ThreadStart(() =>
                            {
                                if (a.EXEC())
                                {
                                    IsTimming = -1;
                                    MessageBox.Show("OK");
                                }
                                else
                                {
                                    IsTimming = -1;
                                    MessageBox.Show("FAIL");
                                }
                            });
                            IsTimming = 1;
                            timer1.Start();
                            PROGRAM_STATIC_THREAD.StopCurrentAndRun(new Thread(threadStart) { IsBackground = true});
                            break;
                        }
                    case 1: //UCS
                        {
                            break;
                        }
                    case 2: //BFS
                        {
                            break;
                        }
                    case 3: //DFS
                        {
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Please select Start and End Point","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_path_reset_Click(object sender, EventArgs e)
        {
            PROGRAM_STATIC_THREAD.AbortCurrent();
            if (MessageBox.Show("Are you sure you want to delete the path ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                step = 0;
                ClearWay();
            }
        }

        private void btn_map_reset_Click(object sender, EventArgs e)
        {
            PROGRAM_STATIC_THREAD.AbortCurrent();
            if (MessageBox.Show("Are you sure you want to clear the map ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                step = 0;
                ClearMap();
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if(PROGRAM_STATIC_THREAD.ThreadPause_Curent == false) 
            {
                btn_pause.Text = "RESUME";
                btn_pause.BackColor = Color.Red;
                IsTimming = 0;
                PROGRAM_STATIC_THREAD.ThreadPause_Curent = true; //Dừng
            }
            else
            {
                btn_pause.Text = "PAUSE";
                btn_pause.BackColor = Color.FromArgb(128, 128, 255);
                IsTimming = 1;
                PROGRAM_STATIC_THREAD.ThreadPause_Curent = false; //Chạy
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            IsTimming = -1;
            PROGRAM_STATIC_THREAD.Current_Thread.Abort();
            PROGRAM_STATIC_THREAD.In_Process = false;
            PROGRAM_STATIC_THREAD.ThreadPause_Curent = false;
            PROGRAM_STATIC_VARS.Set_DrawPointer(null);

            btn_pause.Text = "PAUSE";
            btn_pause.BackColor = Color.FromArgb(128, 128, 255);
        }

        private void btn_ran_maze_Click(object sender, EventArgs e) //Tạo mê cung ngẫu nhiên
        {
            if (ClearMap())
            {
                switch ((int)SETTING_STATIC_VARS._MAZE_GEN_ALG)
                {
                    case 0: //DFS
                        {
                            DFS_MazeGen a = new DFS_MazeGen(this.MAP);
                            ThreadStart threadStart = new ThreadStart(() =>
                            {
                                PROGRAM_STATIC_THREAD.In_Process = true;
                                if (a.EXEC() == "OK")
                                {
                                    MessageBox.Show("OK");
                                    btn_pause.Text = "PAUSE";
                                    btn_pause.BackColor = Color.FromArgb(128, 128, 255);
                                }
                                PROGRAM_STATIC_THREAD.In_Process = false;
                            });
                            PROGRAM_STATIC_THREAD.StopCurrentAndRun(new Thread(threadStart) { IsBackground = true });
                            break;
                        }
                    case 1: //PRIM
                        {
                            break;
                        }
                }
            }
        }

        private void btn_ran_obs_Click(object sender, EventArgs e) //Tạo vật cản ngẫu nhiên
        {
            if (ClearMap())
            {
                Random_Obs_Gen a = new Random_Obs_Gen(this.MAP);
                ThreadStart threadStart = new ThreadStart(() =>
                {
                    PROGRAM_STATIC_THREAD.In_Process = true;
                    if (a.EXEC() == "OK")
                    {
                        MessageBox.Show("OK");
                        btn_pause.Text = "PAUSE";
                        btn_pause.BackColor = Color.FromArgb(128, 128, 255);
                    }
                    PROGRAM_STATIC_THREAD.In_Process = false;

                });
                PROGRAM_STATIC_THREAD.StopCurrentAndRun(new Thread(threadStart) { IsBackground = true });
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsTimming == 1) // Running
            {
                TimerVal += 10;
                lb_time.Text = TimerVal + " ms";
            }
        }
        #endregion


        #region Function

        private bool ClearMap()
        {
            try
            {
                PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE = PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.PATH;
                label7.Text = "TYPE: PATH";
                label7.ForeColor = SETTING_STATIC_VARS.PathNode_Color;

                PROGRAM_STATIC_VARS.Mouse_State = 0;
                label6.Text = "PEN: NONE";
                label6.ForeColor = Color.Black;

                PROGRAM_STATIC_VARS.Have_Start = null;
                PROGRAM_STATIC_VARS.Have_End = null;
                foreach (NODE tmp in MAP)
                {
                    tmp.Type_N = NODE.Type_Node.PATH_NODE;
                    tmp.Cost = 1;
                    tmp.pictureBox.BackColor = SETTING_STATIC_VARS.PathNode_Color;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Something Wrong !" + "\n" + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ClearWay()
        {
            try
            {
                PROGRAM_STATIC_VARS.mOUSE_DRAW_TYPE = PROGRAM_STATIC_VARS.MOUSE_DRAW_TYPE.PATH;
                label7.Text = "TYPE: PATH";
                label7.ForeColor = SETTING_STATIC_VARS.PathNode_Color;

                PROGRAM_STATIC_VARS.Mouse_State = 0;
                label6.Text = "PEN: NONE";
                label6.ForeColor = Color.Black;

                foreach (NODE tmp in MAP)
                {
                    if (tmp.Type_N == NODE.Type_Node.WAY_NODE)
                    {
                        tmp.Type_N = NODE.Type_Node.PATH_NODE;
                        tmp.Cost = 1;
                        tmp.pictureBox.BackColor = SETTING_STATIC_VARS.PathNode_Color;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Something Wrong !" + "\n" + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

        
    }
    class ComboBoxItem
    {
        public string Name;
        public int Value;
        public ComboBoxItem(string Name, int Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
        public override string ToString()
        {
            // Generates the text shown in the combo box
            return Name;
        }
    }
}
