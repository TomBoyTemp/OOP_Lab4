using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_4._1
{

    public partial class viewController : Form
    {
        public viewController()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.updateForm);
        }

        Model model;
        Boolean pause = true;

        private void updateForm(object sender, EventArgs e)
        {
            if (pause)
            { 
            txtBxA.Text = model.getValueA().ToString();
            nmrcUpDownA.Value = model.getValueA();
            trackBarA.Value = model.getValueA();

            txtBxB.Text = model.getValueB().ToString();
            nmrcUpDownB.Value = model.getValueB();
            trackBarB.Value = model.getValueB();

            txtBxC.Text = model.getValueC().ToString();
            nmrcUpDownC.Value = model.getValueC();
            trackBarC.Value = model.getValueC();
            }
        }

    
        private void txtBxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueA(Int32.Parse(txtBxA.Text));
            }
        }

        private void txtBxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueB(Int32.Parse(txtBxB.Text));
            }
        }

        private void txtBxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueC(Int32.Parse(txtBxC.Text));
            }
        }

        private void nmrcUpDownA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(nmrcUpDownA.Value));
        }

        private void nmrcUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(nmrcUpDownB.Value));
        }

        private void nmrcUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(nmrcUpDownC.Value));
        }

        private void trackBarA_MouseUp(object sender, MouseEventArgs e)
        {
            model.setValueA(Decimal.ToInt32(trackBarA.Value));
        }

        private void trackBarB_MouseUp(object sender, MouseEventArgs e)
        {
            model.setValueB(Decimal.ToInt32(trackBarB.Value));
        }

        private void trackBarC_MouseUp(object sender, MouseEventArgs e)
        {
            model.setValueC(Decimal.ToInt32(trackBarC.Value));
        }

        private void viewController_Load(object sender, EventArgs e)
        {
          
            model.setValueA(Sett.Default.A);
            model.setValueB(Sett.Default.B);
            model.setValueC(Sett.Default.C);

        }

        private void viewController_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sett.Default.A = model.getValueA();
            Sett.Default.B = model.getValueB();
            Sett.Default.C = model.getValueC();
            Sett.Default.Save();
        }
    }


    public class Model
    {
        private int A;
        private int B;
        private int C;
     
        public EventHandler observers;

        public void setValueA(int value)
        {
            A = value;
            if (value < 0 || value > 100)
            {
                observers.Invoke(this, null);
                return;
            }


            if (A > C)
                C = A;

            if (A > B)
                B = A;
            
            observers.Invoke(this, null);
        }

        public void setValueB(int value)
        {
            B = value;
            if (value < 0 || value > 100)
            {
                observers.Invoke(this, null);
                return;
            }
            
            if (B < A)
            {
                B = A;
            }
            if (B > C)
            {
                B = C;
            }
            
            observers.Invoke(this, null);
        }

        public void setValueC(int value)
        {
            C = value;
            if (value < 0 || value > 100)
            {
                observers.Invoke(this, null);
                return;
            }

            if (C < A)
            {
                A = value;
            }

            if (C < B)
            { 
                B = value;
            }
            observers.Invoke(this, null);
        }
        public int getValueA()
        {
            return A;
        }
        public int getValueB()
        {
            return B;
        }
        public int getValueC()
        {
            return C;
        }
    }
}
