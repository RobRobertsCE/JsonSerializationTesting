using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SetupModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonSerializationTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //// json
                //var json = SetupStrings.GetModJson();
                //// setup
                //var objIn = SetupFactory<IModSetupInfo>.GetSetupInfo(json);
                //// check the output
                //if (objIn is IModSetupInfo)
                //{
                //    Console.WriteLine("objIn.SetupInfo is IModSetupInfo");
                //}
                //if (objIn is ILmscSetupInfo)
                //{
                //    Console.WriteLine("objIn.SetupInfo is ILMSCSetup");
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bar();
        }
        void bar()
        {
            var json = SetupInfoFactory<ISkModifiedSetupInfo>.GetSerializedSetup();

            var sk = SetupInfoFactory<ISkModifiedSetupInfo>.GetSetupInfo(json);
            Console.WriteLine(sk.Chassis.RightFront.SpringRate);
            ////sk.Chassis.RightFront.ShockCollarHeight = 12.43F;
            ////var lmsc = SetupInfoFactory<ILateModelSetupInfo>.GetSetupInfo("");
            ////// lmsc.Chassis.RightRear.ShockCollarHeight = 12.43F; << error, lmsc does not have this property. Behavior Correct.
            ////lmsc.Tires.LeftFront.LastHotPSI = 25;
        }
    }
}
