﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302190044
{
    internal class SayaTubeUser
    {
        private int id;
        private string username;
        List<SayaTubeVideo> uploadedVideos = new List<SayaTubeVideo>();
        public SayaTubeUser Data { get; set; }
        public SayaTubeUser() {
            
           // for (int i = 0;i < id; i++)
           // {
            //    Console.WriteLine(id);
           // }
            this.username = username;
        }
        public int GetTotalVideoPlay()
        {
            return GetTotalVideoPlay();
        }
        public void AddVideo()
        {
            SayaTubeUser ts = new SayaTubeUser();
            ts.GetTotalVideoPlay();
        }
        public void PrintAllVideoPlaycount()
        {

        }
        static double snfx(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }
        public static void Main()
        {
        
            double a = 98, b = 0;
            double result;
            try
            {
                result = snfx(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b,
               result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0");
            }
        }

    }
}
