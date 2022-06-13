using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApp1
{
    class DFS_MazeGen
    {
        private Random _rnd = new Random();
        private Random _rnd_direction; 
        private NODE[,] MAP = new NODE[PROGRAM_STATIC_VARS.main_H, PROGRAM_STATIC_VARS.main_W];
        private Stack<NODE> DFS_Stack = new Stack<NODE>();
        private int _x;
        private int _y;
        public DFS_MazeGen(NODE[,] MAP1)
        {
            this.MAP = MAP1;
            _x = _rnd.Next(0,PROGRAM_STATIC_VARS.main_H-1);
            _y = _rnd.Next(0,PROGRAM_STATIC_VARS.main_W-1);
            _rnd_direction = new Random(Convert.ToInt32(DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond));
            /// DIRECTION ORDER
            //      ______________
            //     |    |  0 |    |
            //     |____|____|____|
            //     |  3 |    |  1 |
            //     |____|____|____|
            //     |    |  2 |    |
            //     |____|____|____|
        }
        public string EXEC()
        {
            SetAllMapToBlock();

            SetToPath(MAP[_x, _y]);
            DFS_Stack.Push(MAP[_x, _y]);
            PROGRAM_STATIC_VARS.Set_DrawPointer(DFS_Stack.Peek());

            while (DFS_Stack.Count != 0)
            {
                if (SetRandomOrderListAndAdd(this.DFS_Stack)) //Co lien ket moi
                {
                    //Ignore
                }
                else //K co lien ket moi
                {
                    DFS_Stack.Pop();
                    if (DFS_Stack.Count != 0)
                    {
                        PROGRAM_STATIC_VARS.Set_DrawPointer(DFS_Stack.Peek());
                    }
                }
            }
            return "OK";
        }

        public bool SetRandomOrderListAndAdd(Stack<NODE> DFS_Stack) //Get all Node connection of the top stack Node
        {
            List<int> tmp_orderDirec_List = new List<int>();
            NODE tmp_node = DFS_Stack.Peek(); // top stack
            
            int X = tmp_node.index_X;
            int Y = tmp_node.index_Y;

            while (tmp_orderDirec_List.Count < 4)
            {
                int tmp_ranNum = _rnd_direction.Next(0, 4);
                if(!tmp_orderDirec_List.Contains(tmp_ranNum))
                {
                    tmp_orderDirec_List.Add(tmp_ranNum); 
                    CheckAndAdd(X, Y, tmp_ranNum, DFS_Stack); //Kiem tra va add vao Stack
                    //////
                    PROGRAM_STATIC_THREAD.PauseAndResumeThread();
                    /////
                }
            }
            if(tmp_node == DFS_Stack.Peek()) //Không còn liên kết nào khác từ Top Stack
            {
                return false;
            }
            return true;
        }

        public void CheckAndAdd(int Curent_x,int Curent_y, int Direction, Stack<NODE> DFS_Stack) //Current là node gốc, Direction là hướng loang ra của nó
        {
            switch (Direction) //Hướng từ node đang xét
            {
                case 0: //TOP
                    {
                        if(Curent_y - 1 >= 0)
                        {
                            if(IsSuitable(Curent_x, Curent_y - 1))
                            {
                                SetToPath(MAP[Curent_x, Curent_y - 1]);
                                DFS_Stack.Push(MAP[Curent_x, Curent_y - 1]);
                            }
                        }
                        break;
                    }
                case 1: //RIGHT
                    {
                        if (Curent_x + 1 < PROGRAM_STATIC_VARS.main_H)
                        {
                            if (IsSuitable(Curent_x + 1, Curent_y))
                            {
                                SetToPath(MAP[Curent_x + 1, Curent_y]);
                                DFS_Stack.Push(MAP[Curent_x + 1, Curent_y]);
                            }
                        }
                        break;
                    }
                case 2: //BOT
                    {
                        if (Curent_y + 1 < PROGRAM_STATIC_VARS.main_W)
                        {
                            if (IsSuitable(Curent_x, Curent_y + 1))
                            {
                                SetToPath(MAP[Curent_x, Curent_y + 1]);
                                DFS_Stack.Push(MAP[Curent_x, Curent_y + 1]);
                            }
                        }
                        break;
                    }
                case 3: //LEFT
                    {
                        if (Curent_x - 1 >= 0)
                        {
                            if (IsSuitable(Curent_x - 1, Curent_y))
                            {
                                SetToPath(MAP[Curent_x - 1, Curent_y]);
                                DFS_Stack.Push(MAP[Curent_x - 1, Curent_y]);
                            }
                        }
                        break;
                    }
            }
            PROGRAM_STATIC_VARS.Set_DrawPointer(DFS_Stack.Peek());
        }

        public bool IsSuitable(int x, int y) //Điều kiện để được chọn
        {
            if(MAP[x, y].FLAG == false) //Chưa xét và phải là Node tường (wall)
            {
                
                if(GetNumberPathAround(x,y) <= _rnd.Next(1, 2) && Check(x,y)) //Xung quanh chỉ được tối đa 1 hoặc 2 block Path Và Chống trùng lặp làm tăng kích thước đường đi
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        /*public bool Check2(int x, int y)
        {
            int Count = 0;

        }*/

        public bool Check(int x, int y) //Chống trùng lặp làm tăng kích thước đường đi
        {
            int Count = 0;
            List<int> List_X = new List<int>();
            List_X.Add(-1);
            List_X.Add(1);
            foreach (int i in List_X)
            {
                foreach (int j in List_X)
                {
                    int tmp1 = x + i;
                    int tmp2 = y + j;
                    if (IsInSide(tmp1, tmp2))
                    {
                        if (MAP[tmp1,tmp2].FLAG == true)
                        {
                            if (i == 1)
                            {
                                if (j == 1) //BOT RIGHT
                                {
                                    if(MAP[tmp1 - 1, tmp2].FLAG == false || MAP[tmp1, tmp2 - 1].FLAG == false)
                                    {
                                        Count++;
                                    }
                                }
                                else // BOT LEFT
                                {
                                    if (MAP[tmp1 - 1, tmp2].FLAG == false || MAP[tmp1, tmp2 + 1].FLAG == false)
                                    {
                                        Count++;
                                    }
                                }
                            }
                            else
                            {
                                if (j == 1) //TOP RIGHT
                                {
                                    if (MAP[tmp1 + 1, tmp2].FLAG == false || MAP[tmp1, tmp2 - 1].FLAG == false)
                                    {
                                        Count++;
                                    }
                                }
                                else // TOP LEFT
                                {
                                    if (MAP[tmp1 + 1, tmp2].FLAG == false || MAP[tmp1, tmp2 + 1].FLAG == false)
                                    {
                                        Count++;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Count++;
                        }
                    }
                    else
                    {
                        Count++;
                    }
                }
            }
            if(Count == 4)
            {
                return true;
            }
            return false;
        }

        public int GetNumberPathAround(int x, int y) //Check số path NODE xung quanh
        {
            int Count = 0;
            for(int i = -1; i <= 1; i++)
            {
                for(int j = -1; j <= 1; j++)
                {
                    if(i != 0 && j != 0)
                    {
                        int tmp1 = x + i;
                        int tmp2 = y + j;
                        if (IsInSide(tmp1,tmp2))
                        {
                            if (MAP[tmp1, tmp2].FLAG == true)
                            {
                                Count++;
                            }
                        }
                        else
                        {
                            Count++;
                        }
                    }
                }
            }
            return Count;
        }
        private bool IsInSide(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < PROGRAM_STATIC_VARS.main_H && y < PROGRAM_STATIC_VARS.main_W)
            {
                return true;
            }
            else
            {
                return false;
            }
        } //Check Tọa độ còn thuộc map hay k


        public void SetToPath(NODE tmp)
        {
            tmp.Cost = 1;
            tmp.Type_N = NODE.Type_Node.PATH_NODE;
            tmp.pictureBox.BackColor = SETTING_STATIC_VARS.PathNode_Color;
            tmp.FLAG = true;
        }

        public void SetAllMapToBlock()
        {
            foreach(NODE x in MAP)
            {
                x.Cost = -1;
                x.Type_N = NODE.Type_Node.BLOCK_NODE;
                x.pictureBox.BackColor = SETTING_STATIC_VARS.BlockNode_Color;
                x.FLAG = false;
            }
        }
    }
}
