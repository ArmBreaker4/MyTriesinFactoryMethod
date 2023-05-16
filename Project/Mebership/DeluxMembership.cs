using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Mebership
{
    internal class DeluxMembership
    {

        private string DeluxMembershipName;
        private string DeluxMembershipDescription;
        private int DeluxMembershipPrice;

        public DeluxMembership()
        {
            DeluxMembershipName = "Delux Membership";

            DeluxMembershipDescription = "For best people in the whole world, we have the best activities!!!";

            DeluxMembershipPrice = 1000;

        }

        public void GetInfo()
        {
            Console.WriteLine(">Name: " + DeluxMembershipName + "\n");
            Console.WriteLine(">Description: " + DeluxMembershipDescription + "\n");
            Console.WriteLine(">Price: " + DeluxMembershipPrice + "$" + "\n");
        }
    }
}
