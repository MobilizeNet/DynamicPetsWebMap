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
   public partial class UserControl3 : Mobilize.Web.UserControl
   {
       public UserControl3()
       {
           InitializeComponent();
       }


       private void button1_Click(object sender, EventArgs e)
       {
         Mobilize.Web.MessageBox.Show("I want a cookie");
      }

   }
}