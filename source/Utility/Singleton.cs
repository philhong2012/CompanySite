using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    /// <summary>
    /// double check
    /// </summary>
    sealed class Singleton
    {
        private static object _syn = new object();
        private static Singleton _instance = null;
        private Singleton()
        { 
            
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_syn)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    //return _instance;
                }
            }
            return _instance;
        }
    }

    /// <summary>
    /// static initialize
    /// </summary>
    sealed class Singleton2
    {
        private static object _syn = new object();
        private static readonly Singleton2 _instance = new Singleton2();
        private Singleton2()
        {

        }

        public Singleton2 Instance
        {
            get
            {
                return _instance;
            }
        }
    }

}
