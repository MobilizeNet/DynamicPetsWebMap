using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace DynamicPets
{

   [Observable]
   public partial class UserControl2 : Mobilize.Web.UserControl
   {
       public UserControl2()
       {
           InitializeComponent();
       }


       private void button1_Click(object sender, EventArgs e)
       {
         Mobilize.Web.MessageBox.Show("They feed me, they care for me, they must be gods");
      }

   }
}