using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupModels
{
    #region // TourModified //
    public interface ITourModifiedSetupInfo : ISetupInfo
    {
        int Updates { get; set; }
        string Name { get; set; }

        ITourModifiedSetupTires Tires { get; set; }
        ITourModifiedSetupChassis Chassis { get; set; }
    }
    internal class TourModifiedSetupInfo : CompositeSetupInfo, ITourModifiedSetupInfo
    {
        ITourModifiedSetupChassis ITourModifiedSetupInfo.Chassis
        {
            get
            {
                return (ITourModifiedSetupChassis)base.Chassis;
            }

            set
            {
                base.Chassis = (ICompositeSetupChassis)value;
            }
        }

        ITourModifiedSetupTires ITourModifiedSetupInfo.Tires
        {
            get
            {
                return (ITourModifiedSetupTires)base.Tires;
            }

            set
            {
                base.Tires = (ICompositeSetupTires)value;
            }
        }
    }

    public interface ITourModifiedSetupTires
    {
        ITourModifiedSetupLeftTire LeftFront { get; set; }
        ITourModifiedSetupRightTire RightFront { get; set; }
        ITourModifiedSetupLeftTire LeftRear { get; set; }
        ITourModifiedSetupRightTire RightRear { get; set; }
    }

    public interface ITourModifiedSetupLeftTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
    }

    public interface ITourModifiedSetupRightTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
        float Stagger { get; set; }
    }

    public interface ITourModifiedSetupChassis
    {
        ITourModifiedSetupChassisFront Front { get; set; }
        ITourModifiedSetupChassisRear Rear { get; set; }
        ITourModifiedSetupChassisLeftFront LeftFront { get; set; }
        ITourModifiedSetupChassisRightFront RightFront { get; set; }
        ITourModifiedSetupChassisLeftRear LeftRear { get; set; }
        ITourModifiedSetupChassisRightRear RightRear { get; set; }
    }
    internal class TourModifiedSetupChassis : CompositeSetupChassis, ITourModifiedSetupChassis
    {
        public override ICompositeSetupChassisFront Front { get; set; }
        public override ICompositeSetupChassisRear Rear { get; set; }
        public override ICompositeSetupChassisLeftFront LeftFront { get; set; }
        public override ICompositeSetupChassisRightFront RightFront { get; set; }
        public override ICompositeSetupChassisLeftRear LeftRear { get; set; }
        public override ICompositeSetupChassisRightRear RightRear { get; set; }

        ITourModifiedSetupChassisFront ITourModifiedSetupChassis.Front
        {
            get
            {
                return (ITourModifiedSetupChassisFront)Front;
            }

            set
            {
                Front = (ICompositeSetupChassisFront)value;
            }
        }
        ITourModifiedSetupChassisRear ITourModifiedSetupChassis.Rear
        {
            get
            {
                return (ITourModifiedSetupChassisRear)Rear;
            }

            set
            {
                Rear = (ICompositeSetupChassisRear)value;
            }
        }
        ITourModifiedSetupChassisLeftFront ITourModifiedSetupChassis.LeftFront
        {
            get
            {
                return (ITourModifiedSetupChassisLeftFront)LeftFront;
            }

            set
            {
                LeftFront = (ICompositeSetupChassisLeftFront)value;
            }
        }
        ITourModifiedSetupChassisRightFront ITourModifiedSetupChassis.RightFront
        {
            get
            {
                return (ITourModifiedSetupChassisRightFront)RightFront;
            }

            set
            {
                RightFront = (ICompositeSetupChassisRightFront)value;
            }
        }
        ITourModifiedSetupChassisLeftRear ITourModifiedSetupChassis.LeftRear
        {
            get
            {
                return (ITourModifiedSetupChassisLeftRear)LeftRear;
            }

            set
            {
                LeftRear = (ICompositeSetupChassisLeftRear)value;
            }
        }
        ITourModifiedSetupChassisRightRear ITourModifiedSetupChassis.RightRear
        {
            get
            {
                return (ITourModifiedSetupChassisRightRear)RightRear;
            }

            set
            {
                RightRear = (ICompositeSetupChassisRightRear)value;
            }
        }
    }
    public interface ITourModifiedSetupChassisFront
    {
        float CrossWeight { get; set; }
    }

    public interface ITourModifiedSetupChassisRear
    {
        int RearGear { get; set; }
    }

    public interface ITourModifiedSetupChassisLeftFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }

    public interface ITourModifiedSetupChassisLeftRear
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }

    public interface ITourModifiedSetupChassisRightFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }

    public interface ITourModifiedSetupChassisRightRear
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }
    #endregion
}
