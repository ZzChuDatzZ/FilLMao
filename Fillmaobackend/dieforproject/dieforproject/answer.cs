using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dieforproject
{
    internal class answer
    {
        private string cautl;
        private string idcautl;
        private string idch;
        public answer(string cautl = "", string idcautl = "", string idch = "")
        {
            this.cautl = cautl;
            this.idcautl = idcautl;
            this.idch = idch;
        }
        public string Cautl
        {
            get { return this.cautl;}
            set { this.cautl = value;}
        }
        public string Idcautl
        {
            get { return this.idcautl;}
            set { this.idcautl = value;}
        }
        public string Idch
        {
            get { return this.idch;}
            set
            {
                this.idch = value;
            }
        }
    }
}
