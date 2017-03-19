using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;


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

            ///Wait for user input
            Console.Read();

            ///Kill all threads
            drunkMouseThread.Abort();
            drunkKeyboardThread.Abort();
            drunkSoundThread.Abort();
            drunkPopupThread.Abort();

        }

#region Thread Functions
        /// <summary>
        /// This thread will randomly affect the mouse to screw with the end user
        /// </summary>
        public static void DrunkMouseThread()
        {
            Console.WriteLine("DrunkMouseThread started");

            int moveX = 0;
            int moveY = 0;

            while (true)
            {
                ///Console.WriteLine(Cursor.Position.ToString());

                ///Generate random X and Y values
                moveX = _random.Next(20) - 10;
                moveY = _random.Next(20) - 10;

                ///Change to position of the pointer based on the random values
                Cursor.Position = new Point(
                    Cursor.Position.X + moveX, 
                    Cursor.Position.Y + moveY);

                Thread.Sleep(50);
            }

        }

        /// <summary>
        /// This thread will genete random keyboard utput to screw with the user
        /// </summary>
        public static void DrunkKeyboardThread()
        {
            ///Console.WriteLine("DrunkKeyboardThread started");

            while (true)
            {
                char key = (char)(_random.Next(25)+65);
                SendKeys.SendWait(key.ToString());
                Thread.Sleep(500);
            }

        }

        /// <summary>
        /// This thread will play system sounds at random
        /// </summary>
        public static void DrunkSoundThread()
        {
            Console.WriteLine("DrunkSoundThread started");

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
            Console.WriteLine("DrunkPopupThread started");

            while (true)
            {
                
                Thread.Sleep(500);
            }

        }
#endregion
    }
}
