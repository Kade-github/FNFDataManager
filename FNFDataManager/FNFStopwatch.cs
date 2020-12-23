using System;

namespace FNFDataManager
{
    public class FNFStopwatch : System.Diagnostics.Stopwatch
    {
        public  FNFStopwatch()
        {
        }

        private double mili = 0.0;
        
        public  FNFStopwatch(double startMiliseconds)
        {
            mili = startMiliseconds;
        }
        
        public double ElapsedMilliseconds => Elapsed.TotalMilliseconds + mili;
    }
}