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
        /// Random obs on map
        /// </summary>



        ////////////////////////////////Thread Control////////////////////////////////////////////////////
        /// <summary>
        /// /// <summary>
        /// Curent Thread
        /// </summary>
        #region Thread Control
        public delegate void ProcessStateHandler(bool State);

        public static event ProcessStateHandler ChangeProcessState;
        
        public static bool In_Process
        {
            get { return PROGRAM_STATIC_THREAD.In_Process; }
            set
            {
                //this.In_Process = value; //Cause Stack over flow ???

                ChangeProcessState?.Invoke(value);
            }
        }

        

        public static Thread Current_Thread { get; private set; }
        public static void StopCurrentAndRun(Thread Run)
        {
            if (Current_Thread != null)
            {
                Current_Thread.Abort();
            }
            Current_Thread = Run;
            Current_Thread.IsBackground = true;
            Current_Thread.Start();
        }

        public static void AbortCurrent()
        {
            if (PROGRAM_STATIC_THREAD.Current_Thread != null)
            {
                PROGRAM_STATIC_THREAD.Current_Thread.Abort();
            }
            PROGRAM_STATIC_THREAD.In_Process = false;
        }


        public static bool ThreadPause_Curent { get; set; } = false; //Pause or resume

        public static void PauseAndResumeThread()
        {
            if (!SETTING_STATIC_VARS.IgnoreDelay_mazGen)
            {
                Thread.Sleep(SETTING_STATIC_VARS.Delay_Time); //Delay time
            }
            while (PROGRAM_STATIC_THREAD.ThreadPause_Curent)
            {
                //Pause and resume thread
            }
        }
        #endregion
    }
}
