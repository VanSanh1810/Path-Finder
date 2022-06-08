using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class SETTING_STATIC_VARS
    {
        public static bool Show_Info { get; set; } = true;
        public static bool Use_PathWeight { get; set; } = true;

        public static bool IgnoreDelay_mazGen { get; set; } = true;
        public static int Delay_Time { get; set; } = 0;
        public static Color StartNode_Color { get; set; } = Color.Green;
        public static Color EndNode_Color { get; set; } = Color.Red;
        public static Color BlockNode_Color { get; set; } = Color.Black;
        public static Color PathNode_Color { get; set; } = Color.DarkGray;//169,169,169
        public static Color WayNode_Color { get; set; } = Color.Blue;

        public static Color DrawPointer_Color { get; set; } = Color.Aqua;
        public enum MAZE_GEN_ALG
        {
            DFS = 0,
            PRIM = 1
        }
        public static MAZE_GEN_ALG _MAZE_GEN_ALG { get; set; } = MAZE_GEN_ALG.DFS;

        public static Color Pre_Color { get; set; } = Color.DarkGray;

        
    }
}
