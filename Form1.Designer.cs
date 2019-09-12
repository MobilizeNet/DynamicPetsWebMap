using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace DynamicPets
{

   partial class Form1
   {

      [Intercepted]
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private
      System.ComponentModel.IContainer components { get; set; } = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

      protected override void Dispose(bool disposing)
      {
          if (disposing && (components != null))
         {
             components.Dispose();
         }
         base.Dispose(disposing);
     }

      [Mobilize.WebMap.Common.Attributes.Designer]

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private
         void InitializeComponent()
      {
          this.bntDog = new Mobilize.Web.Button();
          this.btnAddCat = new Mobilize.Web.Button();
          this.btnAddParrot = new Mobilize.Web.Button();
          this.btnClear = new Mobilize.Web.Button();
          this.panelControls = new Mobilize.Web.Panel();
          this.SuspendLayout();
          // 
          // bntDog
          // 
          this.bntDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
          this.bntDog.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.bntDog.ForeColor = System.Drawing.Color.White;
         this.bntDog.Location = new System.Drawing.Point(24, 27);
         this.bntDog.Name = "bntDog";
         this.bntDog.Size = new System.Drawing.Size(161, 48);
         this.bntDog.TabIndex = 0;
         this.bntDog.Text = "Add Dog";
         this.bntDog.UseVisualStyleBackColor = false;
         this.bntDog.Click += new System.EventHandler(this.bntDog_Click);
         // 
         // btnAddCat
         // 
         this.btnAddCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
         this.btnAddCat.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.btnAddCat.ForeColor = System.Drawing.Color.White;
         this.btnAddCat.Location = new System.Drawing.Point(191, 27);
         this.btnAddCat.Name = "btnAddCat";
         this.btnAddCat.Size = new System.Drawing.Size(142, 48);
         this.btnAddCat.TabIndex = 1;
         this.btnAddCat.Text = "Add Cat";
         this.btnAddCat.UseVisualStyleBackColor = false;
         this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
         // 
         // btnAddParrot
         // 
         this.btnAddParrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
         this.btnAddParrot.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.btnAddParrot.ForeColor = System.Drawing.Color.White;
         this.btnAddParrot.Location = new System.Drawing.Point(349, 27);
         this.btnAddParrot.Name = "btnAddParrot";
         this.btnAddParrot.Size = new System.Drawing.Size(171, 48);
         this.btnAddParrot.TabIndex = 2;
         this.btnAddParrot.Text = "Add Parrot";
         this.btnAddParrot.UseVisualStyleBackColor = false;
         this.btnAddParrot.Click += new System.EventHandler(this.btnAddParrot_Click);
         // 
         // btnClear
         // 
         this.btnClear.Location = new System.Drawing.Point(656, 29);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(132, 46);
         this.btnClear.TabIndex = 3;
         this.btnClear.Text = "Clear";
         this.btnClear.UseVisualStyleBackColor = true;
         this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
         // 
         // panelControls
         // 
         this.panelControls.Location = new System.Drawing.Point(22, 110);
         this.panelControls.Name = "panelControls";
         this.panelControls.Size = new System.Drawing.Size(766, 314);
         this.panelControls.TabIndex = 4;
         this.AutoScroll = true;
         this.Controls.Add(this.panelControls);
         this.Controls.Add(this.btnClear);
         this.Controls.Add(this.btnAddParrot);
         this.Controls.Add(this.btnAddCat);
         this.Controls.Add(this.bntDog);
         this.Name = "Form1";
         this.Text = "Dynamic Pets";
     }

     #endregion

      [Intercepted]

      private Mobilize.Web.Button bntDog { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnAddCat { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnAddParrot { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnClear { get; set; }

      [Intercepted]
      private Mobilize.Web.Panel panelControls { get; set; }

   }
}