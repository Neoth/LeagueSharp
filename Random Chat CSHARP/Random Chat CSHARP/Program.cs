using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using System.Threading;
using System.Timers;

namespace Random_Chat_CSHARP
{
    class Program
    {
/* MESSAGES: I did not write this. I told a friend who wrote what he wanted. WRITE WHAT YOU WANT */
        private static string[] early = new string[] { "Let's win this guys :)", "lol", "Sorry I'm lagging :c", "lmao", "XD", "We can do it!", ":)" };
       private static string[] mid = new string[] { "lol", "/all Well Played", "Good Job! :D", "Push please :)", "We can beat them ^^", "Try to win next fight :)", "We can do it!", "Don't worry, we got this", "Don't forget teamplay ^^", };
       private static string[] late = new string[] {"Try to push guys :D", "/all Well Played", "Good Job! :D", "Focus their carries and we win !", "Let's play as a team! :)", "ok", "xD", ":)", };
      
        private static List<int> r_early = new List<int>();
        private static List<int> r_mid = new List<int>();
        private static List<int> r_late = new List<int>();

        private static int Segundos = 0;
       private static Random rnd = new Random();
        static System.Timers.Timer timer = new System.Timers.Timer(1000);


        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
            
          
        }


        public static void Game_OnGameLoad(EventArgs args)
        {
           
            Game.PrintChat("KOPTS RANDOM CHAT ");


          


            for (int i = 0; i < 5; i++)   /* 10 means the number messages that will write in each phase of the game. Modify at your own. In this case,33.*/
            {
               
               
                r_early.Add(rnd.Next(100, 600));
                r_mid.Add(rnd.Next(620, 1140));
                r_late.Add(rnd.Next(1200, 2100));
               
            }

           

            timer.Elapsed += Tick;
            timer.Start();
        }

         private static void Tick(object sender, ElapsedEventArgs e)
        {
            

            if (Segundos == 9000 )
            {
                Game.Say("/f");
            }
                                        /*Will try to surrender */
            if (Segundos == 9000)
            {
                Game.Say("/f");
            }

            if (Segundos == 9000)
            {
                Game.Say("/f");
            }

            for (int i = 0; i < r_early.Count(); i++)
            {
                if (Segundos==r_early[i])
                {
                   

                    Game.Say(early[rnd.Next(0, early.Count())].ToString());
                }

            
            }



            for (int i = 0; i < r_mid.Count(); i++)
            {
             

                if (Segundos == r_mid[i])
                {

                    Game.Say(mid[rnd.Next(0, mid.Count())].ToString());
                }

              
            }


            for (int i = 0; i < r_late.Count(); i++)
            {
             

                if (Segundos == r_late[i])
                {

                    Game.Say(late[rnd.Next(0, late.Count())].ToString());
                }
            }
            
          
            Segundos += 1;
        }
      
    }
}
