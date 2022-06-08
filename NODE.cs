using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class NODE
    {
        public enum Type_Node
        {
            START_NODE = 0,
            END_NODE = 1,
            PATH_NODE = 2,
            BLOCK_NODE = 3,
            WAY_NODE = 4
        }
        public Type_Node Type_N { get; set; } = Type_Node.PATH_NODE;
        public int Cost { get; set; } = 1;
        public int loc_X { get; set; }
        public int loc_Y { get; set; }
        public int index_X { get; set; } //Row
        public int index_Y { get; set; } //Col
        public string Name { get; set; }
        public int Name_INT { get; set; }
        public PictureBox pictureBox { get; set; }

        public ToolTip toolTip { get; set; }
        public bool FlagForDFS { get; set; } = false;

    }
}
