using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_assignment
{
    public class AreaMaster
    {

        
        public enum areaType { Country_Master, State_Master, City_Master, District_Master };

        protected static List<AreaMaster> AreaCollection = new List<AreaMaster>();

        public int AreaID { get; set; }
        public int ID { get; set ;  }
        public string code { get;  set ;}
        public string name { get ;  set ; }
        public string description { get ;  set ;  }
        public virtual areaType type { get; set; }
      
        public AreaMaster(int ID, string code, string name, string description, areaType type,int AreaID)
        {
            this.ID = ID;
            this.code = code;
            this.name = name;
            this.description = description;
            this.type = type;
            this.AreaID = AreaID;

            AreaCollection.Add(this);
        }
       
        public AreaMaster getAreamasterByState(string state)
        {
            foreach (AreaMaster data in AreaCollection.Where(area => area.type == areaType.State_Master))

            {
                Console.WriteLine("state");
                if (string.Equals(state, data.name))
                {
                    Console.WriteLine("state is" + state);
                    return data;
                }
                else
                {
                    Console.WriteLine("no such state exists");
                }
                
            }
            return null;
        }
        public AreaMaster getAreamasterBycountry(string country)
        {
            foreach (AreaMaster data in AreaCollection.Where(area => area.type == areaType.Country_Master))

            {
                
                if (string.Equals(country, data.name))
                {
                    Console.WriteLine("country is" + country);
                    return data;
                }
                else
                {
                    Console.WriteLine("no such country exists");
                }

            }
            return null;
        }
        public AreaMaster getareamasterById(int id)
        {
            foreach (AreaMaster data in AreaCollection)

            {
               
                if (id==data.ID)
                {
                    
                    return data;
                }
               

            }
            return null;


        }
        public AreaMaster getAreamasterByCity(string city)
        {
            Console.WriteLine("inside");
            foreach (AreaMaster data in AreaCollection.Where(area => area.type == areaType.City_Master))

            {
                Console.WriteLine("city");
                if (string.Equals(city, data.name))
                {
                    Console.WriteLine("city is" + city);
                    return data;
                }
                else
                {
                    Console.WriteLine("no such city exists");
                }

            }
            return null;
        }
        public AreaMaster getAreamasterByDistrict(string district)
        {
            foreach (AreaMaster data in AreaCollection.Where(area => area.type == areaType.District_Master))

            {
                Console.WriteLine("district");
                if (string.Equals(district, data.name))
                {
                    Console.WriteLine("district is" + district);
                    return data;
                }
                else
                {
                    Console.WriteLine("no such district exists");
                }

            }
            return null;
        }

    }
    class CountryMaster : AreaMaster
    {
        public CountryMaster(int ID, string code, string name, string description, areaType type,int AreaID) : base(ID, code, name, description, type,AreaID)
        {

        }
        //public override areaType areaType
        //{
        //    get
        //    {
        //        return areaType.Country_Master;
        //    }

        //    set
        //    {
        //        areaType = areaType.Country_Master;
        //    }
        //}
       
    }
    class StateMaster : AreaMaster
    {
        public StateMaster(int ID, string code, string name, string description, areaType type,int AreaID) : base(ID, code, name, description, type, AreaID)
        {

        }
        //public override areaType areaType
        //{
        //    get
        //    {
        //        return areaType.State_Master;
        //    }

        //    set
        //    {
        //        areaType = areaType.State_Master;
        //    }
        //}
        
    }
    class CityMaster : AreaMaster
    {
        public CityMaster(int ID, string code, string name, string description, areaType type,int AreaID) : base(ID, code, name, description, type, AreaID)
        {

        }
        //public override areaType areaType
        //{
        //    get
        //    {
        //        return areaType.City_Master;
        //    }

        //    set
        //    {
        //        areaType = areaType.City_Master;
        //    }
        //}
       
    }
    class DistrictMaster : AreaMaster
    {
        public DistrictMaster(int ID, string code, string name, string description, areaType type,int AreaID) : base(ID, code, name, description, type, AreaID)
        {

        }
        //public override areaType areaType_prop
        //{
        //    get
        //    {
        //        return areaType.District_Master;
        //    }

        //    set
        //    {
        //        areaType_prop = areaType.District_Master;
        //    }
        //}

    }
}
