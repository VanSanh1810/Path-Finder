using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class A_star
    {
        private NODE[,] MAP = new NODE[PROGRAM_STATIC_VARS.main_H, PROGRAM_STATIC_VARS.main_W];
        private List<OPEN_TYPE> OPEN_List = new List<OPEN_TYPE>();
        public A_star(NODE[,] MAP1)
        {
            this.MAP = MAP1;
            BasicSetup();
        }

        public bool EXEC()
        {
            ///Get i j
            int Name_INT = Convert.ToInt32(PROGRAM_STATIC_VARS.Have_Start.Name);
            int i = Name_INT / PROGRAM_STATIC_VARS.main_W; //Row
            int j = Name_INT % PROGRAM_STATIC_VARS.main_W; //Col
            //////
            OPEN_List.Add(new OPEN_TYPE(MAP[i,j], MAP[i, j].Cost, GetHeuristicVal(MAP[i, j]), new Queue<NODE>())); //Add Start Node

            while (OPEN_List.Count != 0)
            {
                /*foreach (OPEN_TYPE a in OPEN_List)
                {
                    Console.WriteLine(a.Total);
                }
                Console.WriteLine("\n");*/
                if(OPEN_List[0].Current_Node.Type_N == NODE.Type_Node.END_NODE) // Tìm được đường đi
                {
                    return SetSucessPath(OPEN_List[0]);
                }
                GetSuitableConnectNode(OPEN_List[0]); //Có tìm được điểm mới
                OPEN_List = Sort_List(OPEN_List); //Sort Open List
            }
            return false;
        }

        public bool GetSuitableConnectNode(OPEN_TYPE _node)
        {
            int count = 0;
            int I = _node.Current_Node.index_X;
            int J = _node.Current_Node.index_Y;

            
            ///////////////////////////////////////////////////////////
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    PROGRAM_STATIC_THREAD.PauseAndResumeThread();
                    //if ((i != 0 || j != 0) && (Math.Abs(i) != Math.Abs(j))) ///**********************
                    if (i != 0 || j != 0)
                    {
                        if (IsSuitable(I + i,J + j)) //Check xem thỏa điều kiện hay k
                        {
                            int tmp = IsInOPEN(MAP[I + i, J + j]);
                            if (tmp != -1) //Trong OPEN
                            {
                                if(OPEN_List[tmp].Total > _node.Total_Cost + MAP[I + i, J + j].Cost + GetHeuristicVal(MAP[I + i, J + j])) //Old > New => thay thế
                                {
                                    OPEN_List.RemoveAt(tmp);
                                    DrawOPENs(I + i, J + j);
                                    OPEN_List.Add(new OPEN_TYPE(MAP[I + i, J + j],
                                        _node.Total_Cost + MAP[I + i, J + j].Cost,
                                        GetHeuristicVal(MAP[I + i, J + j]),
                                        _node.Way));
                                    count++;
                                }
                            }
                            else //Không thuộc OPEN
                            {
                                DrawOPENs(I + i, J + j);
                                OPEN_List.Add(new OPEN_TYPE(MAP[I + i, J + j],
                                        _node.Total_Cost + MAP[I + i, J + j].Cost,
                                        GetHeuristicVal(MAP[I + i, J + j]),
                                        _node.Way));
                                count++;
                            }
                            
                        }
                    }
                }
            }
            int a = OPEN_List[0].Current_Node.index_X;
            int b = OPEN_List[0].Current_Node.index_Y;
            MAP[a, b].FLAG = true;
            OPEN_List.RemoveAt(0); //POP
            if (count == 0)
            {
                return false;
            }
            return true;
        }

        public double GetHeuristicVal(NODE a)
        {
            int Name_INT = Convert.ToInt32(PROGRAM_STATIC_VARS.Have_End.Name);
            int i = Name_INT / PROGRAM_STATIC_VARS.main_W; //Row
            int j = Name_INT % PROGRAM_STATIC_VARS.main_W; //Col

            double result = Math.Sqrt(Math.Pow(i-a.index_X,2) + Math.Pow(j-a.index_Y,2));
            return Math.Round(result,3);
        }

        public bool IsSuitable(int i, int j)
        {
            if (i >= 0 && i < PROGRAM_STATIC_VARS.main_H && j >= 0 && j < PROGRAM_STATIC_VARS.main_W) //Trong MAP
            {
                if (MAP[i,j].FLAG == false &&
                MAP[i, j].Type_N != NODE.Type_Node.BLOCK_NODE) //Chưa xét và k phải là tường
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public int IsInOPEN(NODE _node)
        {
            for(int i = 0;i< OPEN_List.Count; i++)
            {
                if (OPEN_List[i].Current_Node.Name == _node.Name)
                {
                    return i;
                }
            }
            return -1;
        }

        public List<OPEN_TYPE> Sort_List(List<OPEN_TYPE> OPEN_List)
        {
            return OPEN_List.OrderBy(o => o.Total).ToList();
        }

        public void BasicSetup()
        {
            foreach(NODE a in MAP)
            {
                a.FLAG = false;
            }
        }

        public bool SetSucessPath(OPEN_TYPE oPEN_TYPE_node)
        {
            try
            {
                foreach (NODE a in oPEN_TYPE_node.Way)
                {
                    PROGRAM_STATIC_THREAD.PauseAndResumeThread();
                    if (a.Type_N != NODE.Type_Node.START_NODE && a.Type_N != NODE.Type_Node.END_NODE)
                    {
                        a.pictureBox.BackColor = SETTING_STATIC_VARS.WayNode_Color;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public void DrawOPENs(int x, int y)
        {
            if (MAP[x, y].Type_N != NODE.Type_Node.END_NODE) 
            { 
                MAP[x, y].pictureBox.BackColor = SETTING_STATIC_VARS.DrawPointer_Color;
                MAP[x, y].Type_N = NODE.Type_Node.WAY_NODE;
            }
        }
    }
    class OPEN_TYPE
    {
        public double Total_Cost { get; set; }
        public double Heuristic { get; set; }
        public double Total { get; set; }

        public Queue<NODE> Way = new Queue<NODE>();
        public NODE Current_Node;
        public OPEN_TYPE(NODE Current_Node, double TotalCost,double Heuristic, Queue<NODE> Old)
        {
            this.Total_Cost = TotalCost;
            this.Current_Node = Current_Node;
            this.Heuristic = Heuristic;
            for (int i = 0; i < Old.Count; i++)
            {
                Way.Enqueue(Old.ElementAt(i));
            }
            Way.Enqueue(Current_Node);
            this.Total = Heuristic + TotalCost;
        }
    }
}
