namespace SetupModels
{
    internal interface ICompositeSetupInfo
    {
        int Updates { get; set; }
        string Name { get; set; }

        ICompositeSetupTires Tires { get; set; }
        ICompositeSetupChassis Chassis { get; set; }

    }
    internal class CompositeSetupInfo : ICompositeSetupInfo
    {
        public int Updates { get; set; }
        public string Name { get; set; }

        public ICompositeSetupTires Tires { get; set; }
        public ICompositeSetupChassis Chassis { get; set; }

        public CompositeSetupInfo()
        {
            Tires = new CompositeSetupTires();
            Chassis = new CompositeSetupChassis();
        }
    }

    internal interface ICompositeSetupTires
    {
        ICompositeSetupLeftTire LeftFront { get; set; }
        ICompositeSetupRightTire RightFront { get; set; }
        ICompositeSetupLeftTire LeftRear { get; set; }
        ICompositeSetupRightTire RightRear { get; set; }
    }
    internal class CompositeSetupTires : ICompositeSetupTires
    {
        public ICompositeSetupLeftTire LeftFront { get; set; }
        public ICompositeSetupRightTire RightFront { get; set; }
        public ICompositeSetupLeftTire LeftRear { get; set; }
        public ICompositeSetupRightTire RightRear { get; set; }

        public CompositeSetupTires()
        {
            LeftFront = new CompositeSetupLeftTire();
            RightFront = new CompositeSetupRightTire();
            LeftRear = new CompositeSetupLeftTire();
            RightRear = new CompositeSetupRightTire();
        }
    }

    internal interface ICompositeSetupLeftTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
    }
    internal class CompositeSetupLeftTire : ICompositeSetupLeftTire
    {
        public float LastHotPSI { get; set; }
        public float ColdPSI { get; set; }
        public float[] Temps { get; set; }
        public float[] Wear { get; set; }
    }

    internal interface ICompositeSetupRightTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
        float Stagger { get; set; }
    }
    internal class CompositeSetupRightTire : ICompositeSetupRightTire
    {
        public float LastHotPSI { get; set; }
        public float ColdPSI { get; set; }
        public float[] Temps { get; set; }
        public float[] Wear { get; set; }
        public float Stagger { get; set; }
    }

    internal interface ICompositeSetupChassis
    {
        ICompositeSetupChassisFront Front { get; set; }
        ICompositeSetupChassisRear Rear { get; set; }
        ICompositeSetupChassisFrontARB FrontARB { get; set; }
        ICompositeSetupChassisLeftFront LeftFront { get; set; }
        ICompositeSetupChassisRightFront RightFront { get; set; }
        ICompositeSetupChassisLeftRear LeftRear { get; set; }
        ICompositeSetupChassisRightRear RightRear { get; set; }
    }
    internal class CompositeSetupChassis 
        : ICompositeSetupChassis
    {
        public virtual ICompositeSetupChassisFront Front { get; set; }
        public virtual ICompositeSetupChassisRear Rear { get; set; }
        public virtual ICompositeSetupChassisFrontARB FrontARB { get; set; }
        public virtual ICompositeSetupChassisLeftFront LeftFront { get; set; }
        public virtual ICompositeSetupChassisRightFront RightFront { get; set; }
        public virtual ICompositeSetupChassisLeftRear LeftRear { get; set; }
        public virtual ICompositeSetupChassisRightRear RightRear { get; set; }

        public CompositeSetupChassis()
        {
            LeftFront = new CompositeSetupChassisLeftFront();
            RightFront = new CompositeSetupChassisRightFront();
            LeftRear = new CompositeSetupChassisLeftRear();
            RightRear = new CompositeSetupChassisRightRear();
            
            FrontARB = new CompositeSetupChassisFrontARB();
            Front = new CompositeSetupChassisFront();
            Rear = new CompositeSetupChassisRear();
        }
    }

    internal interface ICompositeSetupChassisFront
    {
        float CrossWeight { get; set; }
    }
    internal class CompositeSetupChassisFront 
        : ICompositeSetupChassisFront
        , ISkModifiedSetupChassisFront
    {
        public float CrossWeight { get; set; }
    }

    internal interface ICompositeSetupChassisRear
    {
        int RearGear { get; set; }
    }
    internal class CompositeSetupChassisRear 
        : ICompositeSetupChassisRear
        , ISkModifiedSetupChassisRear
    {
        public int RearGear { get; set; }
    }

    internal interface ICompositeSetupChassisFrontARB
    {
        float SwayBarSize { get; set; }
        int SwayBarArmLength { get; set; }
    }
    internal class CompositeSetupChassisFrontARB 
        : ICompositeSetupChassisFrontARB
    {
        public float SwayBarSize { get; set; }
        public int SwayBarArmLength { get; set; }
    }

    internal interface ICompositeSetupChassisLeftFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }
    internal class CompositeSetupChassisLeftFront 
        : ICompositeSetupChassisLeftFront
        , ISkModifiedSetupChassisLeftFront
    {
        public int SpringRate { get; set; }
        public float ShockCollarHeight { get; set; }
    }

    internal interface ICompositeSetupChassisLeftRear
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }
    internal class CompositeSetupChassisLeftRear 
        : ICompositeSetupChassisLeftRear
        , ISkModifiedSetupChassisLeftRear
    {
        public int SpringRate { get; set; }
        public float ShockCollarHeight { get; set; }
        public float TrackBarHeight { get; set; }
    }

    internal interface ICompositeSetupChassisRightFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }
    internal class CompositeSetupChassisRightFront 
        : ICompositeSetupChassisRightFront
        , ISkModifiedSetupChassisRightFront
    {
        public int SpringRate { get; set; }
        public float ShockCollarHeight { get; set; }
    }

    internal interface ICompositeSetupChassisRightRear
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }
    internal class CompositeSetupChassisRightRear 
        : ICompositeSetupChassisRightRear
        , ISkModifiedSetupChassisRightRear
    {
        public int SpringRate { get; set; }
        public float ShockCollarHeight { get; set; }
        public float TrackBarHeight { get; set; }
    }
}
