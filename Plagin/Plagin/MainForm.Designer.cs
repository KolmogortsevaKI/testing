namespace Plagin
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.heightBox = new System.Windows.Forms.TextBox();
			this.hallowBox = new System.Windows.Forms.TextBox();
			this.lengthPerchBox = new System.Windows.Forms.TextBox();
			this.diameterPerchBox = new System.Windows.Forms.TextBox();
			this.depthBox = new System.Windows.Forms.TextBox();
			this.widthBox = new System.Windows.Forms.TextBox();
			this.fastenersBox = new System.Windows.Forms.TextBox();
			this.Build = new System.Windows.Forms.Button();
			this.Clean = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Height";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Hallow height";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Length perch";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Diameter perch";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 137);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Depth";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 165);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Width";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 194);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Width fasteners";
			// 
			// heightBox
			// 
			this.heightBox.ForeColor = System.Drawing.Color.Black;
			this.heightBox.Location = new System.Drawing.Point(94, 18);
			this.heightBox.Name = "heightBox";
			this.heightBox.Size = new System.Drawing.Size(79, 20);
			this.heightBox.TabIndex = 1;
			this.heightBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.heightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// hallowBox
			// 
			this.hallowBox.ForeColor = System.Drawing.Color.Black;
			this.hallowBox.Location = new System.Drawing.Point(94, 49);
			this.hallowBox.Name = "hallowBox";
			this.hallowBox.Size = new System.Drawing.Size(79, 20);
			this.hallowBox.TabIndex = 2;
			this.hallowBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.hallowBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// lengthPerchBox
			// 
			this.lengthPerchBox.ForeColor = System.Drawing.Color.Black;
			this.lengthPerchBox.Location = new System.Drawing.Point(94, 77);
			this.lengthPerchBox.Name = "lengthPerchBox";
			this.lengthPerchBox.Size = new System.Drawing.Size(79, 20);
			this.lengthPerchBox.TabIndex = 3;
			this.lengthPerchBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.lengthPerchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// diameterPerchBox
			// 
			this.diameterPerchBox.ForeColor = System.Drawing.Color.Black;
			this.diameterPerchBox.Location = new System.Drawing.Point(94, 106);
			this.diameterPerchBox.Name = "diameterPerchBox";
			this.diameterPerchBox.Size = new System.Drawing.Size(79, 20);
			this.diameterPerchBox.TabIndex = 4;
			this.diameterPerchBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.diameterPerchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// depthBox
			// 
			this.depthBox.ForeColor = System.Drawing.Color.Black;
			this.depthBox.Location = new System.Drawing.Point(94, 134);
			this.depthBox.Name = "depthBox";
			this.depthBox.Size = new System.Drawing.Size(79, 20);
			this.depthBox.TabIndex = 5;
			this.depthBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.depthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// widthBox
			// 
			this.widthBox.ForeColor = System.Drawing.Color.Black;
			this.widthBox.Location = new System.Drawing.Point(94, 162);
			this.widthBox.Name = "widthBox";
			this.widthBox.Size = new System.Drawing.Size(79, 20);
			this.widthBox.TabIndex = 6;
			this.widthBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.widthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// fastenersBox
			// 
			this.fastenersBox.ForeColor = System.Drawing.Color.Black;
			this.fastenersBox.Location = new System.Drawing.Point(94, 191);
			this.fastenersBox.Name = "fastenersBox";
			this.fastenersBox.Size = new System.Drawing.Size(79, 20);
			this.fastenersBox.TabIndex = 7;
			this.fastenersBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.fastenersBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// Build
			// 
			this.Build.Location = new System.Drawing.Point(182, 234);
			this.Build.Name = "Build";
			this.Build.Size = new System.Drawing.Size(126, 23);
			this.Build.TabIndex = 9;
			this.Build.Text = "Build";
			this.Build.UseVisualStyleBackColor = true;
			// 
			// Clean
			// 
			this.Clean.Location = new System.Drawing.Point(12, 234);
			this.Clean.Name = "Clean";
			this.Clean.Size = new System.Drawing.Size(126, 23);
			this.Clean.TabIndex = 8;
			this.Clean.Text = "Clean";
			this.Clean.UseVisualStyleBackColor = true;
			this.Clean.Click += new System.EventHandler(this.Clean_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(179, 21);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(112, 13);
			this.label15.TabIndex = 23;
			this.label15.Text = "( from 250  to 500 mm)";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(179, 49);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(141, 13);
			this.label16.TabIndex = 24;
			this.label16.Text = "( from 26  to (height-26) mm )";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(179, 80);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(103, 13);
			this.label17.TabIndex = 25;
			this.label17.Text = "( from 25  to 35 mm )";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(179, 109);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(97, 13);
			this.label18.TabIndex = 26;
			this.label18.Text = "( from 5  to 10 mm )";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(179, 137);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(115, 13);
			this.label19.TabIndex = 27;
			this.label19.Text = "( from 120  to 190 mm )";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(179, 165);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(115, 13);
			this.label20.TabIndex = 28;
			this.label20.Text = "( from 120  to 190 mm )";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(179, 194);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(103, 13);
			this.label21.TabIndex = 29;
			this.label21.Text = "( from 30  to 50 mm )";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(327, 279);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.Clean);
			this.Controls.Add(this.Build);
			this.Controls.Add(this.fastenersBox);
			this.Controls.Add(this.widthBox);
			this.Controls.Add(this.depthBox);
			this.Controls.Add(this.diameterPerchBox);
			this.Controls.Add(this.lengthPerchBox);
			this.Controls.Add(this.hallowBox);
			this.Controls.Add(this.heightBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "BirdHouseBuilder";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox heightBox;
		private System.Windows.Forms.TextBox hallowBox;
		private System.Windows.Forms.TextBox lengthPerchBox;
		private System.Windows.Forms.TextBox diameterPerchBox;
		private System.Windows.Forms.TextBox depthBox;
		private System.Windows.Forms.TextBox widthBox;
		private System.Windows.Forms.TextBox fastenersBox;
		private System.Windows.Forms.Button Build;
		private System.Windows.Forms.Button Clean;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
	}
}


	