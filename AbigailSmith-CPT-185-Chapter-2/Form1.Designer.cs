
namespace AbigailSmith_CPT_185_Chapter_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.picEight = new System.Windows.Forms.PictureBox();
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.picKing = new System.Windows.Forms.PictureBox();
            this.picAce = new System.Windows.Forms.PictureBox();
            this.picJoker = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJoker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a Card to See it\'s Name";
            // 
            // picEight
            // 
            this.picEight.Image = ((System.Drawing.Image)(resources.GetObject("picEight.Image")));
            this.picEight.Location = new System.Drawing.Point(12, 96);
            this.picEight.Name = "picEight";
            this.picEight.Size = new System.Drawing.Size(124, 175);
            this.picEight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEight.TabIndex = 1;
            this.picEight.TabStop = false;
            this.toolTip1.SetToolTip(this.picEight, "Click to show name");
            this.picEight.Click += new System.EventHandler(this.picEight_Click);
            // 
            // picTwo
            // 
            this.picTwo.Image = ((System.Drawing.Image)(resources.GetObject("picTwo.Image")));
            this.picTwo.Location = new System.Drawing.Point(142, 96);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(124, 175);
            this.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTwo.TabIndex = 2;
            this.picTwo.TabStop = false;
            this.toolTip1.SetToolTip(this.picTwo, "Click to show name");
            this.picTwo.Click += new System.EventHandler(this.picTwo_Click);
            // 
            // picKing
            // 
            this.picKing.Image = ((System.Drawing.Image)(resources.GetObject("picKing.Image")));
            this.picKing.Location = new System.Drawing.Point(272, 96);
            this.picKing.Name = "picKing";
            this.picKing.Size = new System.Drawing.Size(124, 175);
            this.picKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKing.TabIndex = 3;
            this.picKing.TabStop = false;
            this.toolTip1.SetToolTip(this.picKing, "Click to show name");
            this.picKing.Click += new System.EventHandler(this.picKing_Click);
            // 
            // picAce
            // 
            this.picAce.Image = ((System.Drawing.Image)(resources.GetObject("picAce.Image")));
            this.picAce.Location = new System.Drawing.Point(402, 96);
            this.picAce.Name = "picAce";
            this.picAce.Size = new System.Drawing.Size(124, 175);
            this.picAce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAce.TabIndex = 4;
            this.picAce.TabStop = false;
            this.toolTip1.SetToolTip(this.picAce, "Click to show name");
            this.picAce.Click += new System.EventHandler(this.picAce_Click);
            // 
            // picJoker
            // 
            this.picJoker.Image = ((System.Drawing.Image)(resources.GetObject("picJoker.Image")));
            this.picJoker.Location = new System.Drawing.Point(532, 96);
            this.picJoker.Name = "picJoker";
            this.picJoker.Size = new System.Drawing.Size(124, 175);
            this.picJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJoker.TabIndex = 5;
            this.picJoker.TabStop = false;
            this.toolTip1.SetToolTip(this.picJoker, "Click to show name");
            this.picJoker.Click += new System.EventHandler(this.picJoker_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 311);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(644, 36);
            this.lblName.TabIndex = 6;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(371, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to close");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(213, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Click to close");
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(678, 424);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picJoker);
            this.Controls.Add(this.picAce);
            this.Controls.Add(this.picKing);
            this.Controls.Add(this.picTwo);
            this.Controls.Add(this.picEight);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.picEight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJoker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picEight;
        private System.Windows.Forms.PictureBox picTwo;
        private System.Windows.Forms.PictureBox picKing;
        private System.Windows.Forms.PictureBox picAce;
        private System.Windows.Forms.PictureBox picJoker;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClear;
    }
}

