using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


///Applicaion Name: Drunk PC
///Description: Application that generates erratic muse and keyboard movement
///Topics:
///  1) Threads
///  2) System.Windows.Forms namespaces and assemblies
///  3) Hidden application
///

namespace DrunkPC
{
    class Program
    {
        public static Random _random = new Random();

        /// <summary>
        /// Entry point for prank application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Drunk PC Prank Application by Steve Drew");

            ///Create all threads
            Thread drunkMouseThread = new Thread(new ThreadStart(DrunkMouseThread));
            Thread drunkKeyboardThread = new Thread(new ThreadStart(DrunkKeyboardThread));
            Thread drunkSoundThread = new Thread(new ThreadStart(DrunkSoundThread));
            Thread drunkPopupThread = new Thread(new ThreadStart(DrunkPopupThread));

            drunkMouseThread.Start();
            drunkKeyboardThread.Start();
            drunkSoundThread.Start();
            drunkPopupThread.Start();

        }

#region Thread Functions
        /// <summary>
        /// This thread will randomly affect the mouse to screw with the end user
        /// </summary>
        public static void DrunkMouseThread()
        {
            while(true)
            {
                Thread.Sleep(500);
            }

        }

        /// <summary>
        /// This thread will genete randm keyboard utput to screw with the user
        /// </summary>
        public static void DrunkKeyboardThread()
        {
            while (true)
            {
                Thread.Sleep(500);
            }

        }

        /// <summary>
        /// This thread will play system sounds at random
        /// </summary>
        public static void DrunkSoundThread()
        {
            while (true)
            {
                Thread.Sleep(500);
            }

        }

        /// <summary>
        /// This thread will generate popup messages at random
        /// </summary>
        public static void DrunkPopupThread()
        {
            while (true)
            {
                Thread.Sleep(500);
            }

        }
#endregion
    }
}
