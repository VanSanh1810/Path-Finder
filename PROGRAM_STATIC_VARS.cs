using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class PROGRAM_STATIC_VARS
    {
        

        //Thuộc tính cơ bản
        public static int main_H { get; set; } = 45; //y 45
        public static int main_W { get; set; } = 68; //x 68
        public static int point_size { get; set; } = 15;
        public static int main_loc { get; set; } = 3; //Vi tri node dau tien (3,3)
        
        //Con trỏ User
        public static int Mouse_State { get; set; } = 0; //1 draw 0 not activate -1 erase
        public enum MOUSE_DRAW_TYPE
        {
            BLOCK,
            PATH,
            WAY
        }
        public static MOUSE_DRAW_TYPE mOUSE_DRAW_TYPE { get; set; } = MOUSE_DRAW_TYPE.PATH;

        //Start And End Node
        public static PictureBox Have_Start { get; set; }
        public static PictureBox Have_End { get; set; }
        

        public static int START_X { get; private set; }
        public static int START_Y { get; private set; }
        public static int END_X { get; private set; }
        public static int END_Y { get; private set; }

        public static void Set_START_LOC(int i, int j)
        {
            START_X = i;
            START_Y = j;
        }

        public static void Set_END_LOC(int i, int j)
        {
            END_X = i;
            END_Y = j;
        }

        //Phần trăm vật cản trên 1 dòng (Random Obs)
        public static double Percentage_of_obstructions { get; private set; } = 0.25;

        //Con trỏ Program
        public static NODE DrawPointer { get; private set; }
        public static void Set_DrawPointer(NODE Pointer)
        {
            if (DrawPointer != null)
            {
                switch ((int)DrawPointer.Type_N)
                {
                    case 0: //START
                        {
                            DrawPointer.pictureBox.BackColor = SETTING_STATIC_VARS.StartNode_Color;
                            break;
                        }
                    case 1: //END
                        {
                            DrawPointer.pictureBox.BackColor = SETTING_STATIC_VARS.EndNode_Color;
                            break;
                        }
                    case 2: //PATH
                        {
                            DrawPointer.pictureBox.BackColor = SETTING_STATIC_VARS.PathNode_Color;
                            break;
                        }
                    case 3: //BLOCK
                        {
                            DrawPointer.pictureBox.BackColor = SETTING_STATIC_VARS.BlockNode_Color;
                            break;
                        }
                    case 4: //WAY
                        {
                            DrawPointer.pictureBox.BackColor = SETTING_STATIC_VARS.WayNode_Color;
                            break;
                        }
                }
            }
            if (Pointer != null)
            {
                DrawPointer = Pointer;
                DrawPointer.pictureBox.BackColor = SETTING_STATIC_VARS.DrawPointer_Color;
            }
            else
            {
                DrawPointer = null;
            }
        }

        //Hàm
        
    }
}
