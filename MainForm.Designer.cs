/*
 * Created by SharpDevelop.
 * User: computec
 * Date: 09/30/2026
 * Time: 11:23 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Requirement_tic_tac_toe_Game
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox button9;
		private System.Windows.Forms.PictureBox button3;
		private System.Windows.Forms.PictureBox button1;
		private System.Windows.Forms.PictureBox button4;
		private System.Windows.Forms.PictureBox button6;
		private System.Windows.Forms.PictureBox button8;
		private System.Windows.Forms.PictureBox button5;
		private System.Windows.Forms.PictureBox button2;
		private System.Windows.Forms.PictureBox button7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTurn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblWinner;
		private System.Windows.Forms.Button btn;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button9 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.PictureBox();
			this.button4 = new System.Windows.Forms.PictureBox();
			this.button6 = new System.Windows.Forms.PictureBox();
			this.button8 = new System.Windows.Forms.PictureBox();
			this.button5 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.PictureBox();
			this.button7 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTurn = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblWinner = new System.Windows.Forms.Label();
			this.btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.button9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.button3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.button4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.button6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.button8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.button5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.button2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.button7)).BeginInit();
			this.SuspendLayout();
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.SystemColors.Control;
			this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
			this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button9.Image = global::Requirement_tic_tac_toe_Game.Resource.Question;
			this.button9.Location = new System.Drawing.Point(604, 305);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(90, 90);
			this.button9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.button9.TabIndex = 0;
			this.button9.TabStop = false;
			this.button9.Tag = "?";
			this.button9.Click += new System.EventHandler(this.Pb9Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Control;
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Image = global::Requirement_tic_tac_toe_Game.Resource.Question;
			this.button3.Location = new System.Drawing.Point(604, 105);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 90);
			this.button3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.button3.TabIndex = 2;
			this.button3.TabStop = false;
			this.button3.Tag = "?";
			this.button3.Click += new System.EventHandler(this.Pb7Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Image = global::Requirement_tic_tac_toe_Game.Resource.Question;
			this.button1.Location = new System.Drawing.Point(404, 105);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 90);
			this.button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.button1.TabIndex = 3;
			this.button1.TabStop = false;
			this.button1.Tag = "?";
			this.button1.Click += new System.EventHandler(this.Pb1Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.Control;
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.Image = global::Requirement_tic_tac_toe_Game.Resource.Question;
			this.button4.Location = new System.Drawing.Point(404, 205);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 90);
			this.button4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.button4.TabIndex = 4;
			this.button4.TabStop = false;
			this.button4.Tag = "?";
			this.button4.Click += new System.EventHandler(this.Pb2Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.Control;
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.Image = global::Requirement_tic_tac_toe_Game.Resource.Question;
			this.button6.Location = new System.Drawing.Point(604, 205);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(90, 90);
			this.button6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.button6.TabIndex = 5;
			this.button6.TabStop = false;
			this.button6.Tag = "?";
			this.button6.Click += new System.EventHandler(this.Pb8Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.SystemColors.Control;
			this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
			this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button8.Image = global::Requirement_tic_tac_toe_Game.Resource.Question;
			this.button8.Location = new System.Drawing.Point(504, 305);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(90, 90);
			this.button8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.button8.TabIndex = 6;
			this.button8.TabStop = false;
			this.button8.Tag = "?";
			this.button8.Click += new System.EventHandler(this.Pb6Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.Control;
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.Image = global::Requirement_tic_tac_toe_Game.Resource.Question;
			this.button5.Location = new System.Drawing.Point(504, 205);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(90, 90);
			this.button5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.button5.TabIndex = 7;
			this.button5.TabStop = false;
			this.button5.Tag = "?";
			this.button5.Click += new System.EventHandler(this.Pb5Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Image = global::Requirement_tic_tac_toe_Game.Resource.Question;
			this.button2.Location = new System.Drawing.Point(504, 105);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 90);
			this.button2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.button2.TabIndex = 8;
			this.button2.TabStop = false;
			this.button2.Tag = "?";
			this.button2.Click += new System.EventHandler(this.Pb4Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.Control;
			this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
			this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button7.Image = global::Requirement_tic_tac_toe_Game.Resource.Question;
			this.button7.Location = new System.Drawing.Point(404, 305);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(90, 90);
			this.button7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.button7.TabIndex = 9;
			this.button7.TabStop = false;
			this.button7.Tag = "?";
			this.button7.Click += new System.EventHandler(this.Pb3Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(356, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(386, 48);
			this.label1.TabIndex = 10;
			this.label1.Text = "TicTac Toie Game";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(87, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 55);
			this.label2.TabIndex = 11;
			this.label2.Text = "Turn";
			// 
			// lblTurn
			// 
			this.lblTurn.BackColor = System.Drawing.Color.Black;
			this.lblTurn.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurn.ForeColor = System.Drawing.Color.White;
			this.lblTurn.Location = new System.Drawing.Point(78, 137);
			this.lblTurn.Name = "lblTurn";
			this.lblTurn.Size = new System.Drawing.Size(310, 58);
			this.lblTurn.TabIndex = 13;
			this.lblTurn.Text = "Player1";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Yellow;
			this.label5.Location = new System.Drawing.Point(68, 218);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 55);
			this.label5.TabIndex = 14;
			this.label5.Text = "Winner";
			// 
			// lblWinner
			// 
			this.lblWinner.BackColor = System.Drawing.Color.Black;
			this.lblWinner.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWinner.ForeColor = System.Drawing.Color.LawnGreen;
			this.lblWinner.Location = new System.Drawing.Point(59, 284);
			this.lblWinner.Name = "lblWinner";
			this.lblWinner.Size = new System.Drawing.Size(274, 55);
			this.lblWinner.TabIndex = 15;
			this.lblWinner.Text = "In Progress";
			// 
			// btn
			// 
			this.btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn.Location = new System.Drawing.Point(59, 383);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(150, 46);
			this.btn.TabIndex = 16;
			this.btn.Text = "Restart Game";
			this.btn.UseVisualStyleBackColor = false;
			this.btn.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(775, 465);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.lblWinner);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblTurn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button9);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.Name = "MainForm";
			this.Text = "Requirement tic tac toe Game";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Print);
			((System.ComponentModel.ISupportInitialize)(this.button9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.button3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.button4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.button6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.button8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.button5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.button2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.button7)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
