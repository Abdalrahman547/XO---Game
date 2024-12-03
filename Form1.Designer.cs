namespace XO___Game
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblResetGame = new System.Windows.Forms.Label();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lable1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.Gold;
            this.lable1.Location = new System.Drawing.Point(83, 127);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(163, 55);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Turn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(77, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Winner:";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTurn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTurn.Location = new System.Drawing.Point(83, 192);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(224, 55);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Player 1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWinner.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(77, 373);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(300, 55);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In progress";
            // 
            // lblResetGame
            // 
            this.lblResetGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResetGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResetGame.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetGame.ForeColor = System.Drawing.SystemColors.Window;
            this.lblResetGame.Location = new System.Drawing.Point(87, 510);
            this.lblResetGame.Name = "lblResetGame";
            this.lblResetGame.Size = new System.Drawing.Size(263, 48);
            this.lblResetGame.TabIndex = 5;
            this.lblResetGame.Text = "Restart Game";
            this.lblResetGame.Click += new System.EventHandler(this.lblResetGame_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn11.Image = global::XO___Game.Properties.Resources.question_mark_96;
            this.btn11.Location = new System.Drawing.Point(460, 154);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(101, 93);
            this.btn11.TabIndex = 6;
            this.btn11.Tag = "?";
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn13.Image = global::XO___Game.Properties.Resources.question_mark_96;
            this.btn13.Location = new System.Drawing.Point(805, 154);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(101, 93);
            this.btn13.TabIndex = 7;
            this.btn13.Tag = "?";
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn21.Image = global::XO___Game.Properties.Resources.question_mark_96;
            this.btn21.Location = new System.Drawing.Point(460, 303);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(101, 93);
            this.btn21.TabIndex = 8;
            this.btn21.Tag = "?";
            this.btn21.UseVisualStyleBackColor = false;
            this.btn21.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn12.Image = global::XO___Game.Properties.Resources.question_mark_96;
            this.btn12.Location = new System.Drawing.Point(633, 154);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(101, 93);
            this.btn12.TabIndex = 9;
            this.btn12.Tag = "?";
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn22.Image = global::XO___Game.Properties.Resources.question_mark_96;
            this.btn22.Location = new System.Drawing.Point(633, 303);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(101, 93);
            this.btn22.TabIndex = 10;
            this.btn22.Tag = "?";
            this.btn22.UseVisualStyleBackColor = false;
            this.btn22.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn23
            // 
            this.btn23.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn23.Image = global::XO___Game.Properties.Resources.question_mark_96;
            this.btn23.Location = new System.Drawing.Point(805, 303);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(101, 93);
            this.btn23.TabIndex = 11;
            this.btn23.Tag = "?";
            this.btn23.UseVisualStyleBackColor = false;
            this.btn23.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn31
            // 
            this.btn31.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn31.Image = global::XO___Game.Properties.Resources.question_mark_96;
            this.btn31.Location = new System.Drawing.Point(460, 465);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(101, 93);
            this.btn31.TabIndex = 12;
            this.btn31.Tag = "?";
            this.btn31.UseVisualStyleBackColor = false;
            this.btn31.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn32
            // 
            this.btn32.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn32.Image = global::XO___Game.Properties.Resources.question_mark_96;
            this.btn32.Location = new System.Drawing.Point(633, 465);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(101, 93);
            this.btn32.TabIndex = 13;
            this.btn32.Tag = "?";
            this.btn32.UseVisualStyleBackColor = false;
            this.btn32.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn33
            // 
            this.btn33.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn33.Image = global::XO___Game.Properties.Resources.question_mark_96;
            this.btn33.Location = new System.Drawing.Point(805, 465);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(101, 93);
            this.btn33.TabIndex = 14;
            this.btn33.Tag = "?";
            this.btn33.UseVisualStyleBackColor = false;
            this.btn33.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(523, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 98);
            this.label1.TabIndex = 15;
            this.label1.Text = "XO Game";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1072, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.lblResetGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Name = "GameScreen";
            this.Text = "XO - Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblResetGame;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Label label1;
    }
}

