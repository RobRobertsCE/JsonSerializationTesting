namespace SetupModels
{
    #region // LMSC //
    public interface ILateModelSetupInfo : ISetupInfo
    {
        int Updates { get; set; }
        string Name { get; set; }

        ILateModelSetupTires Tires { get; set; }
        ILateModelSetupChassis Chassis { get; set; }
    }
    internal class LateModelSetupInfo : CompositeSetupInfo, ILateModelSetupInfo
    {
        ILateModelSetupChassis ILateModelSetupInfo.Chassis
        {
            get
            {
                return (ILateModelSetupChassis)base.Chassis;
            }

            set
            {
                base.Chassis = (ICompositeSetupChassis)value;
            }
        }

        ILateModelSetupTires ILateModelSetupInfo.Tires
        {
            get
            {
                return (ILateModelSetupTires)base.Tires;
            }

            set
            {
                base.Tires = (ICompositeSetupTires)value;
            }
        }
    }

    public interface ILateModelSetupTires
    {
        ILateModelSetupLeftTire LeftFront { get; set; }
        ILateModelSetupRightTire RightFront { get; set; }
        ILateModelSetupLeftTire LeftRear { get; set; }
        ILateModelSetupRightTire RightRear { get; set; }
    }

    public interface ILateModelSetupLeftTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
    }

    public interface ILateModelSetupRightTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
        float Stagger { get; set; }
    }

    public interface ILateModelSetupChassis
    {
        ILateModelSetupChassisFront Front { get; set; }
        ILateModelSetupChassisRear Rear { get; set; }
        ILateModelSetupChassisLeftFront LeftFront { get; set; }
        ILateModelSetupChassisRightFront RightFront { get; set; }
        ILateModelSetupChassisLeftRear LeftRear { get; set; }
        ILateModelSetupChassisRightRear RightRear { get; set; }
    }
    internal class LateModelSetupChassis : CompositeSetupChassis, ILateModelSetupChassis
    {
        public override ICompositeSetupChassisFront Front { get; set; }
        public override ICompositeSetupChassisRear Rear { get; set; }
        public override ICompositeSetupChassisLeftFront LeftFront { get; set; }
        public override ICompositeSetupChassisRightFront RightFront { get; set; }
        public override ICompositeSetupChassisLeftRear LeftRear { get; set; }
        public override ICompositeSetupChassisRightRear RightRear { get; set; }

        ILateModelSetupChassisFront ILateModelSetupChassis.Front
        {
            get
            {
                return (ILateModelSetupChassisFront)Front;
            }

            set
            {
                Front = (ICompositeSetupChassisFront)value;
            }
        }
        ILateModelSetupChassisRear ILateModelSetupChassis.Rear
        {
            get
            {
                return (ILateModelSetupChassisRear)Rear;
            }

            set
            {
                Rear = (ICompositeSetupChassisRear)value;
            }
        }
        ILateModelSetupChassisLeftFront ILateModelSetupChassis.LeftFront
        {
            get
            {
                return (ILateModelSetupChassisLeftFront)LeftFront;
            }

            set
            {
                LeftFront = (ICompositeSetupChassisLeftFront)value;
            }
        }
        ILateModelSetupChassisRightFront ILateModelSetupChassis.RightFront
        {
            get
            {
                return (ILateModelSetupChassisRightFront)RightFront;
            }

            set
            {
                RightFront = (ICompositeSetupChassisRightFront)value;
            }
        }
        ILateModelSetupChassisLeftRear ILateModelSetupChassis.LeftRear
        {
            get
            {
                return (ILateModelSetupChassisLeftRear)LeftRear;
            }

            set
            {
                LeftRear = (ICompositeSetupChassisLeftRear)value;
            }
        }
        ILateModelSetupChassisRightRear ILateModelSetupChassis.RightRear
        {
            get
            {
                return (ILateModelSetupChassisRightRear)RightRear;
            }

            set
            {
                RightRear = (ICompositeSetupChassisRightRear)value;
            }
        }
    }
    public interface ILateModelSetupChassisFront
    {
        float CrossWeight { get; set; }
    }

    public interface ILateModelSetupChassisRear
    {
        int RearGear { get; set; }
    }

    public interface ILateModelSetupChassisLeftFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }

    public interface ILateModelSetupChassisLeftRear
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }

    public interface ILateModelSetupChassisRightFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }

    public interface ILateModelSetupChassisRightRear
    {
        int SpringRate { get; set; }
        //float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }
    #endregion
}
