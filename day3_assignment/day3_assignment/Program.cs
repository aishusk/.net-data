using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            AreaMaster area = new AreaMaster(1,"ind","India","anything",AreaMaster.areaType.Country_Master,1);
            AreaMaster area1 = new AreaMaster(2, "mh", "Maharashtra", "anything", AreaMaster.areaType.State_Master, 1);
            AreaMaster area2 = new AreaMaster(3, "pun", "pune", "anything", AreaMaster.areaType.City_Master, 2);
            AreaMaster area3 = new AreaMaster(4, "pd", "pune", "anything", AreaMaster.areaType.District_Master, 3);
            //area1 =area1.getAreamasterByState("pune");
            //AreaMaster tmp = area1.getareamasterById(area.AreaID);
           // area2 = area2.getAreamasterByCity("pune");
          AreaMaster area3= 
            AreaMaster tmp1 = area2.getareamasterById(area1.AreaID);
            AreaMaster tmp2 = area2.getareamasterById(area2.AreaID);
           // Console.WriteLine(  tmp.name);
            Console.WriteLine(tmp1.name); 
            Console.ReadLine();
        }
    }
}
