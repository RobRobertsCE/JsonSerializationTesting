namespace SetupModels
{
    #region // Legends //
    public interface ILegendsSetupInfo : ISetupInfo
    {
        int Updates { get; set; }
        string Name { get; set; }

        ILegendsSetupTires Tires { get; set; }
        ILegendsSetupChassis Chassis { get; set; }
    }
    internal class LegendsSetupInfo : CompositeSetupInfo, ILegendsSetupInfo
    {
        ILegendsSetupChassis ILegendsSetupInfo.Chassis
        {
            get
            {
                return (ILegendsSetupChassis)base.Chassis;
            }

            set
            {
                base.Chassis = (ICompositeSetupChassis)value;
            }
        }

        ILegendsSetupTires ILegendsSetupInfo.Tires
        {
            get
            {
                return (ILegendsSetupTires)base.Tires;
            }

            set
            {
                base.Tires = (ICompositeSetupTires)value;
            }
        }
    }

    public interface ILegendsSetupTires
    {
        ILegendsSetupLeftTire LeftFront { get; set; }
        ILegendsSetupRightTire RightFront { get; set; }
        ILegendsSetupLeftTire LeftRear { get; set; }
        ILegendsSetupRightTire RightRear { get; set; }
    }

    public interface ILegendsSetupLeftTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
    }

    public interface ILegendsSetupRightTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
    }

    public interface ILegendsSetupChassis
    {
        ILegendsSetupChassisFront Front { get; set; }
        ILegendsSetupChassisRear Rear { get; set; }
        ILegendsSetupChassisLeftFront LeftFront { get; set; }
        ILegendsSetupChassisRightFront RightFront { get; set; }
        ILegendsSetupChassisLeftRear LeftRear { get; set; }
        ILegendsSetupChassisRightRear RightRear { get; set; }
    }
    internal class LegendsSetupChassis : CompositeSetupChassis, ILegendsSetupChassis
    {
        public override ICompositeSetupChassisFront Front { get; set; }
        public override ICompositeSetupChassisRear Rear { get; set; }
        public override ICompositeSetupChassisLeftFront LeftFront { get; set; }
        public override ICompositeSetupChassisRightFront RightFront { get; set; }
        public override ICompositeSetupChassisLeftRear LeftRear { get; set; }
        public override ICompositeSetupChassisRightRear RightRear { get; set; }

        ILegendsSetupChassisFront ILegendsSetupChassis.Front
        {
            get
            {
                return (ILegendsSetupChassisFront)Front;
            }

            set
            {
                Front = (ICompositeSetupChassisFront)value;
            }
        }
        ILegendsSetupChassisRear ILegendsSetupChassis.Rear
        {
            get
            {
                return (ILegendsSetupChassisRear)Rear;
            }

            set
            {
                Rear = (ICompositeSetupChassisRear)value;
            }
        }
        ILegendsSetupChassisLeftFront ILegendsSetupChassis.LeftFront
        {
            get
            {
                return (ILegendsSetupChassisLeftFront)LeftFront;
            }

            set
            {
                LeftFront = (ICompositeSetupChassisLeftFront)value;
            }
        }
        ILegendsSetupChassisRightFront ILegendsSetupChassis.RightFront
        {
            get
            {
                return (ILegendsSetupChassisRightFront)RightFront;
            }

            set
            {
                RightFront = (ICompositeSetupChassisRightFront)value;
            }
        }
        ILegendsSetupChassisLeftRear ILegendsSetupChassis.LeftRear
        {
            get
            {
                return (ILegendsSetupChassisLeftRear)LeftRear;
            }

            set
            {
                LeftRear = (ICompositeSetupChassisLeftRear)value;
            }
        }
        ILegendsSetupChassisRightRear ILegendsSetupChassis.RightRear
        {
            get
            {
                return (ILegendsSetupChassisRightRear)RightRear;
            }

            set
            {
                RightRear = (ICompositeSetupChassisRightRear)value;
            }
        }
    }
    public interface ILegendsSetupChassisFront
    {
        float CrossWeight { get; set; }
    }

    public interface ILegendsSetupChassisRear
    {
        int RearGear { get; set; }
    }

    public interface ILegendsSetupChassisLeftFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }

    public interface ILegendsSetupChassisLeftRear
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }

    public interface ILegendsSetupChassisRightFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }

    public interface ILegendsSetupChassisRightRear
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }
    #endregion
}
