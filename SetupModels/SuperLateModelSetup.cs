using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupModels
{
    #region // SLM //
    public interface ISuperLateModelSetupInfo : ISetupInfo
    {
        int Updates { get; set; }
        string Name { get; set; }

        ISuperLateModelSetupTires Tires { get; set; }
        ISuperLateModelSetupChassis Chassis { get; set; }
    }
    internal class SuperLateModelSetupInfo : CompositeSetupInfo, ISuperLateModelSetupInfo
    {
        ISuperLateModelSetupChassis ISuperLateModelSetupInfo.Chassis
        {
            get
            {
                return (ISuperLateModelSetupChassis)base.Chassis;
            }

            set
            {
                base.Chassis = (ICompositeSetupChassis)value;
            }
        }

        ISuperLateModelSetupTires ISuperLateModelSetupInfo.Tires
        {
            get
            {
                return (ISuperLateModelSetupTires)base.Tires;
            }

            set
            {
                base.Tires = (ICompositeSetupTires)value;
            }
        }
    }

    public interface ISuperLateModelSetupTires
    {
        ISuperLateModelSetupLeftTire LeftFront { get; set; }
        ISuperLateModelSetupRightTire RightFront { get; set; }
        ISuperLateModelSetupLeftTire LeftRear { get; set; }
        ISuperLateModelSetupRightTire RightRear { get; set; }
    }

    public interface ISuperLateModelSetupLeftTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
    }

    public interface ISuperLateModelSetupRightTire
    {
        float LastHotPSI { get; set; }
        float ColdPSI { get; set; }
        float[] Temps { get; set; }
        float[] Wear { get; set; }
        float Stagger { get; set; }
    }

    public interface ISuperLateModelSetupChassis
    {
        ISuperLateModelSetupChassisFront Front { get; set; }
        ISuperLateModelSetupChassisRear Rear { get; set; }
        ISuperLateModelSetupChassisLeftFront LeftFront { get; set; }
        ISuperLateModelSetupChassisRightFront RightFront { get; set; }
        ISuperLateModelSetupChassisLeftRear LeftRear { get; set; }
        ISuperLateModelSetupChassisRightRear RightRear { get; set; }
    }
    internal class SuperLateModelSetupChassis : CompositeSetupChassis, ISuperLateModelSetupChassis
    {
        public override ICompositeSetupChassisFront Front { get; set; }
        public override ICompositeSetupChassisRear Rear { get; set; }
        public override ICompositeSetupChassisLeftFront LeftFront { get; set; }
        public override ICompositeSetupChassisRightFront RightFront { get; set; }
        public override ICompositeSetupChassisLeftRear LeftRear { get; set; }
        public override ICompositeSetupChassisRightRear RightRear { get; set; }

        ISuperLateModelSetupChassisFront ISuperLateModelSetupChassis.Front
        {
            get
            {
                return (ISuperLateModelSetupChassisFront)Front;
            }

            set
            {
                Front = (ICompositeSetupChassisFront)value;
            }
        }
        ISuperLateModelSetupChassisRear ISuperLateModelSetupChassis.Rear
        {
            get
            {
                return (ISuperLateModelSetupChassisRear)Rear;
            }

            set
            {
                Rear = (ICompositeSetupChassisRear)value;
            }
        }
        ISuperLateModelSetupChassisLeftFront ISuperLateModelSetupChassis.LeftFront
        {
            get
            {
                return (ISuperLateModelSetupChassisLeftFront)LeftFront;
            }

            set
            {
                LeftFront = (ICompositeSetupChassisLeftFront)value;
            }
        }
        ISuperLateModelSetupChassisRightFront ISuperLateModelSetupChassis.RightFront
        {
            get
            {
                return (ISuperLateModelSetupChassisRightFront)RightFront;
            }

            set
            {
                RightFront = (ICompositeSetupChassisRightFront)value;
            }
        }
        ISuperLateModelSetupChassisLeftRear ISuperLateModelSetupChassis.LeftRear
        {
            get
            {
                return (ISuperLateModelSetupChassisLeftRear)LeftRear;
            }

            set
            {
                LeftRear = (ICompositeSetupChassisLeftRear)value;
            }
        }
        ISuperLateModelSetupChassisRightRear ISuperLateModelSetupChassis.RightRear
        {
            get
            {
                return (ISuperLateModelSetupChassisRightRear)RightRear;
            }

            set
            {
                RightRear = (ICompositeSetupChassisRightRear)value;
            }
        }
    }
    public interface ISuperLateModelSetupChassisFront
    {
        float CrossWeight { get; set; }
    }

    public interface ISuperLateModelSetupChassisRear
    {
        int RearGear { get; set; }
    }

    public interface ISuperLateModelSetupChassisLeftFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }

    public interface ISuperLateModelSetupChassisLeftRear
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }

    public interface ISuperLateModelSetupChassisRightFront
    {
        int SpringRate { get; set; }
        float ShockCollarHeight { get; set; }
    }

    public interface ISuperLateModelSetupChassisRightRear
    {
        int SpringRate { get; set; }
        //float ShockCollarHeight { get; set; }
        float TrackBarHeight { get; set; }
    }
    #endregion
}
