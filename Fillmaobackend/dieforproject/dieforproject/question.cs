using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dieforproject
{
    internal class question
    {
        private string ch;
        private string id;

        public question(string ch = "", string id = "")
        {
            this.ch = ch;
            this.id = id;
        }
        public string Ch
        {
            get { return this.ch; }
            set { this.ch = value; }
        }
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
