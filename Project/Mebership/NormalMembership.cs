using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Mebership
{
    internal class NormalMembership
    {

        private string NormalMembershipName;
        private string NormalMembershipDescription;
        private int NormalMembershipPrice;

        public NormalMembership()
        {
            NormalMembershipName = "Normal Membership";

            NormalMembershipDescription = "Normal amount of activities for, normal price. Very simple";

            NormalMembershipPrice = 250;

        }

        public void GetInfo()
        {
            Console.WriteLine(">Name: " + NormalMembershipName + "\n");
            Console.WriteLine(">Description: " + NormalMembershipDescription + "\n");
            Console.WriteLine(">Price: " + NormalMembershipPrice + "$" + "\n");
        }
    }
}
