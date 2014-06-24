using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class WordCount
    {
        private string wordname;
        private int wordCounter;

        public WordCount()
        {
            
        }
        public string Name
        {
            get
            {
                return this.wordname;
            }
            set
            {
                this.wordname = value;
            }
        }
        public int Count
        {
            get
            {
                return this.wordCounter;
            }
            set
            {
                this.wordCounter = value;
            }
        }
    }

