namespace RE4TestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            comboBox2 = new ComboBox();
            button3 = new Button();
            label1 = new Label();
            comboBox3 = new ComboBox();
            button4 = new Button();
            groupBox1 = new GroupBox();
            button9 = new Button();
            button8 = new Button();
            button10 = new Button();
            button7 = new Button();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            groupBox2 = new GroupBox();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button6 = new Button();
            button5 = new Button();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Shotgun Shells", "Infinite Launcher", "P.R.L 412", "Chicago Typewriter", "Handcannon", "Combat Knife", "Shotgun", "Rocket Launcher Special", "Mine Thrower", "Rifle (semi auto) with Infrared Scope", "Handgun", "Handgun with Silencer", "Rifle with Infrared Scope", "Punisher", "Blacktail", "Blacktail with Silencer", "Red9", "Red9 with Stock", "Bow Gun", "Bowgun Bolts", "Flash Grenade", "Mixed Herbs (G+R+Y)", "Mixed Herbs (G+R)", "Mixed Herbs (R+Y)", "First Aid", "Gold Chicken Egg", "Black Bass", "Black Bass (L)", "Castle Gate Key", "Prison Key", "Gallery Key", "Camp Key", "JetSki Key", "Freezer Key Card", "Storage Room Key Card", "Iron Key", "Emergency Lock Key Card", "Activation Key (blue)", "Activation Key (red)", "Waste Disposal Key", "Emerald", "Spinel", "Ruby", "Hexagonal Emblem", "Plaga Sample", "Elegant Headdress", "Gold Sword", "Platinum Sword", "Pearl Pendant", "Brass Pocket Watch", "Piece of the Holy Beast, Panther", "Piece of the Holy Beast, Serpent", "Piece of the Holy Beast, Eagle", "Serpent Ornament", "Red Catseye", "Green Catseye", "Yellow Catseye" });
            comboBox1.Location = new Point(92, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 23);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(11, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Replace";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(269, 80);
            numericUpDown1.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(11, 80);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Set";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Second Item Slot", "Third Item Slot", "Fourth Item Slot", "First Aid Slot" });
            comboBox2.Location = new Point(269, 23);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(162, 23);
            comboBox2.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(126, 78);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 5;
            button3.Text = "Launch RE4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(25, 60);
            label1.Name = "label1";
            label1.Size = new Size(85, 13);
            label1.TabIndex = 6;
            label1.Text = "Not Connected";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Second Item Slot Amount", "Third Item Slot Amount", "Fourth Item Slot Amount", "First Aid Slot Amount" });
            comboBox3.Location = new Point(92, 79);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(171, 23);
            comboBox3.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(14, 78);
            button4.Name = "button4";
            button4.Size = new Size(106, 23);
            button4.TabIndex = 8;
            button4.Text = "Connect";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(14, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 159);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventory Changer";
            // 
            // button9
            // 
            button9.ForeColor = Color.Black;
            button9.Location = new Point(6, 130);
            button9.Name = "button9";
            button9.Size = new Size(26, 23);
            button9.TabIndex = 13;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // button8
            // 
            button8.ForeColor = Color.Black;
            button8.Location = new Point(295, 109);
            button8.Name = "button8";
            button8.Size = new Size(136, 34);
            button8.TabIndex = 12;
            button8.Text = "Randomize Weapons";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // button10
            // 
            button10.ForeColor = Color.Black;
            button10.Location = new Point(11, 51);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 9;
            button10.Text = "Give";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button7
            // 
            button7.ForeColor = Color.Black;
            button7.Location = new Point(153, 109);
            button7.Name = "button7";
            button7.Size = new Size(136, 34);
            button7.TabIndex = 11;
            button7.Text = "Weapon Check";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Shotgun Shells", "Infinite Launcher", "P.R.L 412", "Chicago Typewriter", "Handcannon", "Combat Knife", "Shotgun", "Rocket Launcher Special", "Mine Thrower", "Rifle (semi auto) with Infrared Scope", "Handgun", "Handgun with Silencer", "Rifle with Infrared Scope", "Punisher", "Blacktail", "Blacktail with Silencer", "Red9", "Red9 with Stock", "Bow Gun", "Bowgun Bolts", "Flash Grenade", "Mixed Herbs (G+R+Y)", "Mixed Herbs (G+R)", "Mixed Herbs (R+Y)", "First Aid", "Gold Chicken Egg", "Black Bass", "Black Bass (L)", "Castle Gate Key", "Prison Key", "Gallery Key", "Camp Key", "JetSki Key", "Freezer Key Card", "Storage Room Key Card", "Iron Key", "Emergency Lock Key Card", "Activation Key (blue)", "Activation Key (red)", "Waste Disposal Key", "Emerald", "Spinel", "Ruby", "Hexagonal Emblem", "Plaga Sample", "Elegant Headdress", "Gold Sword", "Platinum Sword", "Pearl Pendant", "Brass Pocket Watch", "Piece of the Holy Beast, Panther", "Piece of the Holy Beast, Serpent", "Piece of the Holy Beast, Eagle", "Serpent Ornament", "Red Catseye", "Green Catseye", "Yellow Catseye" });
            comboBox4.Location = new Point(92, 52);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(171, 23);
            comboBox4.TabIndex = 8;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Second Item Slot", "Third Item Slot", "Fourth Item Slot", "First Aid Slot" });
            comboBox5.Location = new Point(269, 52);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(162, 23);
            comboBox5.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button14);
            groupBox2.Controls.Add(button13);
            groupBox2.Controls.Add(button12);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(14, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(442, 175);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Main Mods";
            // 
            // button14
            // 
            button14.ForeColor = Color.Black;
            button14.Location = new Point(295, 62);
            button14.Name = "button14";
            button14.Size = new Size(136, 34);
            button14.TabIndex = 14;
            button14.Text = "Camera Follow";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.ForeColor = Color.Black;
            button13.Location = new Point(11, 62);
            button13.Name = "button13";
            button13.Size = new Size(136, 34);
            button13.TabIndex = 13;
            button13.Text = "Godmode Ashley";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.ForeColor = Color.Black;
            button12.Location = new Point(11, 22);
            button12.Name = "button12";
            button12.Size = new Size(136, 34);
            button12.TabIndex = 12;
            button12.Text = "Godmode Leon";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.ForeColor = Color.Black;
            button11.Location = new Point(295, 22);
            button11.Name = "button11";
            button11.Size = new Size(136, 34);
            button11.TabIndex = 11;
            button11.Text = "Change PTAS";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button6
            // 
            button6.ForeColor = Color.Black;
            button6.Location = new Point(153, 62);
            button6.Name = "button6";
            button6.Size = new Size(136, 34);
            button6.TabIndex = 10;
            button6.Text = "Huge Enemies";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(153, 22);
            button5.Name = "button5";
            button5.Size = new Size(136, 34);
            button5.TabIndex = 9;
            button5.Text = "Shrink Enemies";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(363, 89);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 11;
            label2.Text = "made by DMON ";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(89, 450);
            label3.Name = "label3";
            label3.Size = new Size(50, 13);
            label3.TabIndex = 12;
            label3.Text = "Litecoin:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(142, 450);
            label4.Name = "label4";
            label4.Size = new Size(239, 13);
            label4.TabIndex = 13;
            label4.Text = "ltc1qrrfwy7e3xcvhlyutu84nt6zaf5xxlpvtw59l57";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            ClientSize = new Size(470, 472);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "Form1";
            Resizable = false;
            Text = "RE4 Modding Tool";
            TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private ComboBox comboBox2;
        private Button button3;
        private Label label1;
        private ComboBox comboBox3;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button10;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Button button9;
        private Label label3;
        private Label label4;
        private Button button11;
        private Button button13;
        private Button button12;
        private Button button14;
    }
}