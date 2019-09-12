using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace DynamicPets
{

   [Observable]
   public partial class Form1 : Mobilize.Web.Form
   {
       public Form1()
       {
           InitializeComponent();
       }

       private void bntDog_Click(object sender, EventArgs e)
       {
           this.panelControls.Controls.Add(new UserControl2());
       }

       private void btnAddCat_Click(object sender, EventArgs e)
       {
           this.panelControls.Controls.Add(new UserControl1());
       }

       private void btnAddParrot_Click(object sender, EventArgs e)
       {
           this.panelControls.Controls.Add(new UserControl3());
       }

       private void btnClear_Click(object sender, EventArgs e)
       {
           this.panelControls.Controls.Clear();


       }

   }
}