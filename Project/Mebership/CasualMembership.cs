namespace Project.Membership
{
    internal class CasualMembership
    {
        private string CasualMembershipName;
        private string CasualMembershipDescription;
        private int CasualMembershipPrice;

        public CasualMembership()
        {
            CasualMembershipName = "Casual Membership";

            CasualMembershipDescription = "Lesser amount of activities, better price";

            CasualMembershipPrice = 100;

        }

        public void GetInfo()
        {
            Console.WriteLine(">Name: " + CasualMembershipName + "\n");
            Console.WriteLine(">Description: " + CasualMembershipDescription + "\n");
            Console.WriteLine(">Price: " + CasualMembershipPrice + "$" + "\n");
        }
    }
}

