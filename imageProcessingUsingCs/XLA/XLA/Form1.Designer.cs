namespace XLA
{
    partial class mainForm
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
            this.pictureboxin = new System.Windows.Forms.PictureBox();
            this.pictureboxout = new System.Windows.Forms.PictureBox();
            this.btanhxam = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnnhiphan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnamban = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnlocnhieu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btluuanh = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gbinput = new System.Windows.Forms.GroupBox();
            this.gboutput = new System.Windows.Forms.GroupBox();
            this.btndobien = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbldim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxout)).BeginInit();
            this.gbinput.SuspendLayout();
            this.gboutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureboxin
            // 
            this.pictureboxin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureboxin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureboxin.Location = new System.Drawing.Point(3, 19);
            this.pictureboxin.Name = "pictureboxin";
            this.pictureboxin.Size = new System.Drawing.Size(342, 234);
            this.pictureboxin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxin.TabIndex = 0;
            this.pictureboxin.TabStop = false;
            this.pictureboxin.Click += new System.EventHandler(this.pictureboxin_Click);
            // 
            // pictureboxout
            // 
            this.pictureboxout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureboxout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureboxout.Location = new System.Drawing.Point(3, 19);
            this.pictureboxout.Name = "pictureboxout";
            this.pictureboxout.Size = new System.Drawing.Size(342, 234);
            this.pictureboxout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxout.TabIndex = 1;
            this.pictureboxout.TabStop = false;
            // 
            // btanhxam
            // 
            this.btanhxam.Depth = 0;
            this.btanhxam.Location = new System.Drawing.Point(63, 67);
            this.btanhxam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btanhxam.Name = "btanhxam";
            this.btanhxam.Primary = true;
            this.btanhxam.Size = new System.Drawing.Size(112, 36);
            this.btanhxam.TabIndex = 2;
            this.btanhxam.Text = "Ảnh xám";
            this.btanhxam.UseVisualStyleBackColor = true;
            this.btanhxam.Click += new System.EventHandler(this.btnanhxam_Click);
            // 
            // btnnhiphan
            // 
            this.btnnhiphan.Depth = 0;
            this.btnnhiphan.Location = new System.Drawing.Point(181, 67);
            this.btnnhiphan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnhiphan.Name = "btnnhiphan";
            this.btnnhiphan.Primary = true;
            this.btnnhiphan.Size = new System.Drawing.Size(112, 36);
            this.btnnhiphan.TabIndex = 3;
            this.btnnhiphan.Text = "Nhị Phân";
            this.btnnhiphan.UseVisualStyleBackColor = true;
            this.btnnhiphan.Click += new System.EventHandler(this.btnnhiphan_Click);
            // 
            // btnamban
            // 
            this.btnamban.Depth = 0;
            this.btnamban.Location = new System.Drawing.Point(299, 67);
            this.btnamban.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnamban.Name = "btnamban";
            this.btnamban.Primary = true;
            this.btnamban.Size = new System.Drawing.Size(112, 36);
            this.btnamban.TabIndex = 4;
            this.btnamban.Text = "Âm bản";
            this.btnamban.UseVisualStyleBackColor = true;
            this.btnamban.Click += new System.EventHandler(this.btnamban_Click);
            // 
            // btnlocnhieu
            // 
            this.btnlocnhieu.Depth = 0;
            this.btnlocnhieu.Location = new System.Drawing.Point(417, 67);
            this.btnlocnhieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnlocnhieu.Name = "btnlocnhieu";
            this.btnlocnhieu.Primary = true;
            this.btnlocnhieu.Size = new System.Drawing.Size(112, 36);
            this.btnlocnhieu.TabIndex = 5;
            this.btnlocnhieu.Text = "Lọc Nhiễu";
            this.btnlocnhieu.UseVisualStyleBackColor = true;
            this.btnlocnhieu.Click += new System.EventHandler(this.btnlocnhieu_Click);
            // 
            // btluuanh
            // 
            this.btluuanh.Depth = 0;
            this.btluuanh.Location = new System.Drawing.Point(661, 67);
            this.btluuanh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btluuanh.Name = "btluuanh";
            this.btluuanh.Primary = true;
            this.btluuanh.Size = new System.Drawing.Size(112, 36);
            this.btluuanh.TabIndex = 6;
            this.btluuanh.Text = "Lưu ảnh";
            this.btluuanh.UseVisualStyleBackColor = true;
            this.btluuanh.Click += new System.EventHandler(this.btluuanh_Click);
            // 
            // gbinput
            // 
            this.gbinput.Controls.Add(this.pictureboxin);
            this.gbinput.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbinput.Location = new System.Drawing.Point(57, 131);
            this.gbinput.Name = "gbinput";
            this.gbinput.Size = new System.Drawing.Size(348, 256);
            this.gbinput.TabIndex = 8;
            this.gbinput.TabStop = false;
            this.gbinput.Text = "Input";
            // 
            // gboutput
            // 
            this.gboutput.Controls.Add(this.pictureboxout);
            this.gboutput.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gboutput.Location = new System.Drawing.Point(431, 131);
            this.gboutput.Name = "gboutput";
            this.gboutput.Size = new System.Drawing.Size(348, 256);
            this.gboutput.TabIndex = 9;
            this.gboutput.TabStop = false;
            this.gboutput.Text = "Output";
            // 
            // btndobien
            // 
            this.btndobien.Depth = 0;
            this.btndobien.Location = new System.Drawing.Point(535, 67);
            this.btndobien.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndobien.Name = "btndobien";
            this.btndobien.Primary = true;
            this.btndobien.Size = new System.Drawing.Size(112, 36);
            this.btndobien.TabIndex = 10;
            this.btndobien.Text = "Dò Biên";
            this.btndobien.UseVisualStyleBackColor = true;
            this.btndobien.Click += new System.EventHandler(this.btndobien_Click_1);
            // 
            // lbldim
            // 
            this.lbldim.AutoSize = true;
            this.lbldim.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbldim.ForeColor = System.Drawing.Color.DimGray;
            this.lbldim.Location = new System.Drawing.Point(53, 9);
            this.lbldim.Name = "lbldim";
            this.lbldim.Size = new System.Drawing.Size(330, 39);
            this.lbldim.TabIndex = 11;
            this.lbldim.Text = "Digital Image Processing";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(824, 411);
            this.Controls.Add(this.lbldim);
            this.Controls.Add(this.btndobien);
            this.Controls.Add(this.gboutput);
            this.Controls.Add(this.gbinput);
            this.Controls.Add(this.btluuanh);
            this.Controls.Add(this.btnlocnhieu);
            this.Controls.Add(this.btnamban);
            this.Controls.Add(this.btnnhiphan);
            this.Controls.Add(this.btanhxam);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(840, 450);
            this.MinimumSize = new System.Drawing.Size(840, 450);
            this.Name = "mainForm";
            this.Text = "Xử lý ảnh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxout)).EndInit();
            this.gbinput.ResumeLayout(false);
            this.gboutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboxin;
        private System.Windows.Forms.PictureBox pictureboxout;
        private MaterialSkin.Controls.MaterialRaisedButton btanhxam;
        private MaterialSkin.Controls.MaterialRaisedButton btnnhiphan;
        private MaterialSkin.Controls.MaterialRaisedButton btnamban;
        private MaterialSkin.Controls.MaterialRaisedButton btnlocnhieu;
        private MaterialSkin.Controls.MaterialRaisedButton btluuanh;
        private System.Windows.Forms.GroupBox gbinput;
        private System.Windows.Forms.GroupBox gboutput;
        private MaterialSkin.Controls.MaterialRaisedButton btndobien;
        private System.Windows.Forms.Label lbldim;
    }
}

