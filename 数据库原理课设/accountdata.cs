using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据库原理课设
{
    internal class accountdata
    {
        private string account;
        private string pwd;

        public string Account
        {
            get => account;
            set => account = value;
        }

        public string Pwd
        {
            get => pwd;
            set => pwd = value;
        }
    }
}