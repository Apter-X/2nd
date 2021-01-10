using System;
using System.Collections.Generic;
using System.Diagnostics;
using GCB;

namespace GCB.Modules.Consoletop
{
    class Loader
    {
        private readonly Stopwatch Watcher = new Stopwatch();

        private readonly IDictionary<int, dynamic> Method = new Dictionary<int, dynamic>();
        //private readonly IDictionary<int, string[]> Menu = new Dictionary<int, string[]>();

        public Loader()
        {
            Watcher.Start();

            this.Method.Add(0, Navigate.TypeAccount());
            this.Method.Add(1, Navigate.SearchProfile());
            this.Method.Add(3, Navigate.DeleteAccount());
            this.Method.Add(4, Navigate.Exit());
            
            //foreach (var entry in cases)
            //{
            //    this.Case.Add(entry.Key, entry.Value);
            //}

            Watcher.Stop();
            Console.WriteLine("Loading Time {0} ms", Watcher.ElapsedMilliseconds);
        }

        public void Apply(int index)
        {
            this.Method[index]();
        }

        public int Get(int index)
        {
            return index;
        }
    }
}
