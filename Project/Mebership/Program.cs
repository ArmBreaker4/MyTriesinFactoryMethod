using Project.Membership;

namespace Project.Mebership
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CasualMembership casualMembership = new CasualMembership();
            casualMembership.GetInfo();

            NormalMembership normalMembership = new NormalMembership();
            normalMembership.GetInfo();
            
            DeluxMembership deliveryMembership = new DeluxMembership();
            deliveryMembership.GetInfo();  

        }
    }
}