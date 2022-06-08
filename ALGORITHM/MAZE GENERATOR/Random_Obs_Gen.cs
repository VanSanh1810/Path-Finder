using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Random_Obs_Gen
    {
        private Random _rnd = new Random();
        private NODE[,] MAP = new NODE[PROGRAM_STATIC_VARS.main_H, PROGRAM_STATIC_VARS.main_W];
        public Random_Obs_Gen(NODE[,] MAP1)
        {
            this.MAP = MAP1;
        }
        
        public string EXEC()
        {
            try
            {
                for (int i = 0; i < PROGRAM_STATIC_VARS.main_H; i++)
                {
                    Stack<int> tmp = new Stack<int>();
                    int tmp_count = (int)((double)PROGRAM_STATIC_VARS.main_W * PROGRAM_STATIC_VARS.Percentage_of_obstructions);
                    while (tmp.Count() < tmp_count)
                    {
                        int tmp_int = _rnd.Next(0, PROGRAM_STATIC_VARS.main_W);
                        if (!tmp.Contains(tmp_int))
                        {
                            tmp.Push(tmp_int);
                        }
                    }
                    while (tmp.Count != 0)
                    {
                        ///
                        if (!SETTING_STATIC_VARS.IgnoreDelay_mazGen)
                        {
                            Thread.Sleep(SETTING_STATIC_VARS.Delay_Time); //Delay time
                        }
                        while (PROGRAM_STATIC_THREAD.ThreadPause_Curent)
                        {
                            //Pause and resume thread
                        }
                        ///
                        int j = tmp.Pop();
                        MAP[i, j].Cost = -1;
                        MAP[i, j].Type_N = NODE.Type_Node.BLOCK_NODE;
                        MAP[i, j].pictureBox.BackColor = SETTING_STATIC_VARS.BlockNode_Color;

                        PROGRAM_STATIC_VARS.Set_DrawPointer(MAP[i, j]);
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message; 
            }
            return "OK";
        }

        
    }
}
