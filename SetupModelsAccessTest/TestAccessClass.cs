using SetupModels;

namespace SetupModelsAccessTest
{
    public class TestAccessClass
    {
        void bar()
        {           
            var sk = SetupInfoFactory<ISkModifiedSetupInfo>.GetSetupInfo( "");
            sk.Chassis.RightFront.ShockCollarHeight = 12.43F;
            var lmsc = SetupInfoFactory<ILateModelSetupInfo>.GetSetupInfo( "");
            // lmsc.Chassis.RightRear.ShockCollarHeight = 12.43F; << error, lmsc does not have this property. Behavior Correct.
            lmsc.Tires.LeftFront.LastHotPSI = 25;
        }
    }
}
