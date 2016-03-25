using Newtonsoft.Json;
using System;

namespace SetupModels
{
    public static class SetupInfoFactory<T>
       where T : ISetupInfo
    {     
        public static string GetSerializedSetup()
        {
            ISkModifiedSetupInfo setupInfo = new SkModifiedSetupInfo();
            setupInfo.Chassis.Front.CrossWeight = 73.3F;
            setupInfo.Tires.LeftFront.ColdPSI = 18F;
            setupInfo.Tires.RightFront.ColdPSI = 15.2F;
            setupInfo.Tires.LeftRear.ColdPSI = 19F;
            setupInfo.Tires.RightRear.ColdPSI = 18.8F;
            setupInfo.Chassis.LeftFront.SpringRate  = 450;
            setupInfo.Chassis.RightFront.SpringRate = 500;
            setupInfo.Chassis.LeftRear.SpringRate = 175;
            setupInfo.Chassis.RightRear.SpringRate = 175;

            var json =JsonConvert.SerializeObject(setupInfo);
            Console.WriteLine(json);
            return json;
        }
        public static T GetSetupInfo(string json)
        {
            if (typeof(T) == typeof(ISkModifiedSetupInfo))
            {
                ISkModifiedSetupInfo setupInfo = new SkModifiedSetupInfo();
                return (T)setupInfo;
            }
            else if (typeof(T) == typeof(ILateModelSetupInfo))
            {
                ILateModelSetupInfo setupInfo = new LateModelSetupInfo();
                return (T)setupInfo;
            }
            else if (typeof(T) == typeof(ISuperLateModelSetupInfo))
            {
                ISuperLateModelSetupInfo setupInfo = new SuperLateModelSetupInfo();
                return (T)setupInfo;
            }
            else if (typeof(T) == typeof(ILegendsSetupInfo))
            {
                //ILegendsSetupInfo setupInfo = new LegendsSetupInfo();
                //return (T)setupInfo;
                return (T)JsonConvert.DeserializeObject(json); 
            }
            else if (typeof(T) == typeof(ITourModifiedSetupInfo))
            {
                //ITourModifiedSetupInfo setupInfo = new TourModifiedSetupInfo();
                //return (T)setupInfo;
                var setupInfo = JsonConvert.DeserializeObject(json);
                return (T)(ITourModifiedSetupInfo)new TourModifiedSetupInfo();
            }
            else
            {
                throw new ArgumentException("T");
            }
            
        }
    }

 
}
