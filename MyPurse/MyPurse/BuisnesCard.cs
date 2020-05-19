using System;
using System.Collections.Generic;
using System.Text;

namespace MyPurse
{
    class BuisnesCard
    {
        protected string money;

        public BuisnesCard(string num)
        {
            this.money = num;
        }

        public string info() {
            return this.money;
        }
    }
}
