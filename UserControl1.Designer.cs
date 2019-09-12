using Mobilize.WebMap.Common.Attributes;

namespace DynamicPets
{

    partial class UserControl1
    {

        [Intercepted]
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private
        System.ComponentModel.IContainer components
        { get; set; } = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private
           void InitializeComponent()
        {
            this.pictureBox1 = new Mobilize.Web.PictureBox();
            this.label1 = new Mobilize.Web.Label();
            this.button1 = new Mobilize.Web.Button();
            this.lbl1 = new Mobilize.Web.Label();
            this.textBox1 = new Mobilize.Web.TextBox();
            ;
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = "assets/images/DynamicPets.Resources.erik_jan_leusink_561776_unsplash.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 110);
            this.pictureBox1.SizeMode = Mobilize.Web.PictureBoxSizeMode.StretchImage;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Are you a cat lover ?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guess what the cat is thinking?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(20, 175);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(185, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "The cat in the photo is thinking in ....?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 4;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(400, 300);
        }

        #endregion

        [Intercepted]

        private Mobilize.Web.PictureBox pictureBox1 { get; set; }

        [Intercepted]
        private Mobilize.Web.Label label1 { get; set; }

        [Intercepted]
        private Mobilize.Web.Button button1 { get; set; }

        [Intercepted]
        private Mobilize.Web.Label lbl1 { get; set; }

        [Intercepted]
        private Mobilize.Web.TextBox textBox1 { get; set; }

    }
}