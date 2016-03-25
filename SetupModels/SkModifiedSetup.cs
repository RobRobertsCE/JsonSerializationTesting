namespace SetupModels
{
    #region // SkModified //
    public interface ISkModifiedSetupInfo : ISetupInfo
    {
        int Updates { get; set; }
        string Name { get; set; }

        ISkModifiedSetupTires Tires { get; set; }
        ISkModifiedSetupChassis Chassis { get; set; }
    }
    internal class SkModifiedSetupInfo : CompositeSetupInfo, ISkModifiedSetupInfo
    {
        ISkModifiedSetupChassis ISkModifiedSetupInfo.Chassis
        {
            get
            {
                return (ISkModifiedSetupChassis)base.Chassis;
            }

            set
            {
                base.Chassis = (ICompositeSetupChassis)value;
            }
        }

        ISkModifiedSetupTires ISkModifiedSetupInfo.Tires
        {
            get
            {
                return (ISkModifiedSetupTires)base.Tires;
            }

            set
            {
                base.Tires = (ICompositeSetupTires)value;
            }
        }
    }

    public interface ISkModifiedSetupTires
    {
        ISkModifiedSetupLeftTire LeftFront { get; set; }
        ISkModifiedSetupRightTire RightFront { get; set; }
        ISkModifiedSetupLeftTire LeftRear { get; set; }
        ISkModifiedSetupRightTire RightRear { get; set; }
    }

    public interface ISkModifiedSetupLeftTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
    }

    public interface ISkModifiedSetupRightTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
        float Stagger { get; set; }
    }

    public interface ISkModifiedSetupChassis
    {
        ISkModifiedSetupChassisFront Front { get; set; }
        ISkModifiedSetupChassisRear Rear { get; set; }
        ISkModifiedSetupChassisLeftFront LeftFront { get; set; }
        ISkModifiedSetupChassisRightFront RightFront { get; set; }
        ISkModifiedSetupChassisLeftRear LeftRear { get; set; }
        ISkModifiedSetupChassisRightRear RightRear { get; set; }
    }
    internal class SkModifiedSetupChassis : CompositeSetupChassis, ISkModifiedSetupChassis
    {
        public override ICompositeSetupChassisFront Front { get; set; }
        public override ICompositeSetupChassisRear Rear { get; set; }
        public override ICompositeSetupChassisLeftFront LeftFront { get; set; }
        public override ICompositeSetupChassisRightFront RightFront { get; set; }
        public override ICompositeSetupChassisLeftRear LeftRear { get; set; }
        public override ICompositeSetupChassisRightRear RightRear { get; set; }

        ISkModifiedSetupChassisFront ISkModifiedSetupChassis.Front
        {
            get
            {
                return (ISkModifiedSetupChassisFront)Front;
            }

            set
            {
                Front = (ICompositeSetupChassisFront)value;
            }
        }
        ISkModifiedSetupChassisRear ISkModifiedSetupChassis.Rear
        {
            get
            {
                return (ISkModifiedSetupChassisRear)Rear;
            }

            set
            {
                Rear = (ICompositeSetupChassisRear)value;
            }
        }
        ISkModifiedSetupChassisLeftFront ISkModifiedSetupChassis.LeftFront
        {
            get
            {
                return (ISkModifiedSetupChassisLeftFront)LeftFront;
            }

            set
            {
                LeftFront = (ICompositeSetupChassisLeftFront)value;
            }
        }
        ISkModifiedSetupChassisRightFront ISkModifiedSetupChassis.RightFront
        {
            get
            {
                return (ISkModifiedSetupChassisRightFront)RightFront;
            }

            set
            {
                RightFront = (ICompositeSetupChassisRightFront)value;
            }
        }
        ISkModifiedSetupChassisLeftRear ISkModifiedSetupChassis.LeftRear
        {
            get
            {
                return (ISkModifiedSetupChassisLeftRear)LeftRear;
            }

            set
            {
                LeftRear = (ICompositeSetupChassisLeftRear)value;
            }
        }
        ISkModifiedSetupChassisRightRear ISkModifiedSetupChassis.RightRear
        {
            get
            {
                return (ISkModifiedSetupChassisRightRear)RightRear;
            }

            set
            {
                RightRear = (ICompositeSetupChassisRightRear)value;
            }
        }
    }
    public interface ISkModifiedSetupChassisFront
    {
        float CrossWeight { get; set; }
    }

    public interface ISkModifiedSetupChassisRear
    {
        int RearGear { get; set; }
    }

    public interface ISkModifiedSetupChassisLeftFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }

    public interface ISkModifiedSetupChassisLeftRear
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }

    public interface ISkModifiedSetupChassisRightFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }

    public interface ISkModifiedSetupChassisRightRear
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }
    #endregion
}
