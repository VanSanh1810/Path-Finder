using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class PROGRAM_STATIC_THREAD
    {
        /// <summary>
        /// Curent Thread
        /// </summary>
        public static Thread Current_Thread { get;private set; }
        public static void StopCurrentAndRun(Thread Run)
        {
            if (Current_Thread != null)
            {
                Current_Thread.Abort();
            }
            Current_Thread = Run;
            Current_Thread.Start();
        }
        public static bool ThreadPause_Curent { get; set; } = false; //Pause or resume
        /// <summary>
        /// Random obs on map
        /// </summary>
        public static Thread Thrd_Random_Obs_Map { get; private set; }
        public static void Set_Thrd_Random_Obs_Map(ThreadStart threadStart, bool _IsBackGround)
        {
            Thrd_Random_Obs_Map = new Thread(threadStart);
            Thrd_Random_Obs_Map.IsBackground = _IsBackGround;
        }
        public static bool ThreadPause_Random_Obs_Map { get; set; } = false;


        /// <summary>
        /// Clear all map
        /// </summary>
        public static Thread Thrd_ClearMap { get; private set; }
        public static void Set_Thrd_ClearMap(ThreadStart threadStart, bool _IsBackGround)
        {
            Thrd_ClearMap = new Thread(threadStart);
            Thrd_ClearMap.IsBackground = _IsBackGround;
        }
        public static bool ThreadPause_ClearMap { get; set; } = false;


        /// <summary>
        /// Clear all path
        /// </summary>
        public static Thread Thrd_ClearPath { get; private set; }
        public static void Set_Thrd_ClearPath(ThreadStart threadStart, bool _IsBackGround)
        {
            Thrd_ClearPath = new Thread(threadStart);
            Thrd_ClearPath.IsBackground = _IsBackGround;
        }
        public static bool ThreadPause_ClearPath { get; set; } = false;

        /// <summary>
        /// DFS Maze Gen
        /// </summary>
        public static Thread Thrd_DFS_MazeGen { get; private set; }
        public static void Set_Thrd_DFS_MazeGen(ThreadStart threadStart, bool _IsBackGround)
        {
            Thrd_DFS_MazeGen = new Thread(threadStart);
            Thrd_DFS_MazeGen.IsBackground = _IsBackGround;
        }
        public static bool ThreadPause_Thrd_DFS_MazeGen { get; set; } = false;
    }
}
