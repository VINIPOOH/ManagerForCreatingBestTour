namespace ManagerForCreatingBestTour
{
    partial class MapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.warszawaBtn = new System.Windows.Forms.Button();
            this.berlinBtn = new System.Windows.Forms.Button();
            this.prahaBtn = new System.Windows.Forms.Button();
            this.wienBtn = new System.Windows.Forms.Button();
            this.budapestBtn = new System.Windows.Forms.Button();
            this.kievBtn = new System.Windows.Forms.Button();
            this.minskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // warszawaBtn
            // 
            this.warszawaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.warszawaBtn.BackColor = System.Drawing.Color.Azure;
            this.warszawaBtn.Location = new System.Drawing.Point(410, 84);
            this.warszawaBtn.Name = "warszawaBtn";
            this.warszawaBtn.Size = new System.Drawing.Size(76, 24);
            this.warszawaBtn.TabIndex = 2;
            this.warszawaBtn.Text = "Warszawa";
            this.warszawaBtn.UseVisualStyleBackColor = false;
            // 
            // berlinBtn
            // 
            this.berlinBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.berlinBtn.BackColor = System.Drawing.Color.Azure;
            this.berlinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.berlinBtn.Location = new System.Drawing.Point(185, 58);
            this.berlinBtn.Name = "berlinBtn";
            this.berlinBtn.Size = new System.Drawing.Size(76, 24);
            this.berlinBtn.TabIndex = 3;
            this.berlinBtn.Text = "Berlin";
            this.berlinBtn.UseVisualStyleBackColor = false;
            // 
            // prahaBtn
            // 
            this.prahaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.prahaBtn.BackColor = System.Drawing.Color.Azure;
            this.prahaBtn.Location = new System.Drawing.Point(205, 191);
            this.prahaBtn.Name = "prahaBtn";
            this.prahaBtn.Size = new System.Drawing.Size(76, 24);
            this.prahaBtn.TabIndex = 4;
            this.prahaBtn.Text = "Praha";
            this.prahaBtn.UseVisualStyleBackColor = false;
            // 
            // wienBtn
            // 
            this.wienBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wienBtn.BackColor = System.Drawing.Color.Azure;
            this.wienBtn.Location = new System.Drawing.Point(259, 295);
            this.wienBtn.Name = "wienBtn";
            this.wienBtn.Size = new System.Drawing.Size(76, 24);
            this.wienBtn.TabIndex = 5;
            this.wienBtn.Text = "Wien";
            this.wienBtn.UseVisualStyleBackColor = false;
            // 
            // budapestBtn
            // 
            this.budapestBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.budapestBtn.BackColor = System.Drawing.Color.Azure;
            this.budapestBtn.Location = new System.Drawing.Point(346, 337);
            this.budapestBtn.Name = "budapestBtn";
            this.budapestBtn.Size = new System.Drawing.Size(76, 24);
            this.budapestBtn.TabIndex = 6;
            this.budapestBtn.Text = "Budapest";
            this.budapestBtn.UseVisualStyleBackColor = false;
            // 
            // kievBtn
            // 
            this.kievBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kievBtn.BackColor = System.Drawing.Color.Azure;
            this.kievBtn.Location = new System.Drawing.Point(704, 157);
            this.kievBtn.Name = "kievBtn";
            this.kievBtn.Size = new System.Drawing.Size(76, 24);
            this.kievBtn.TabIndex = 7;
            this.kievBtn.Text = "Kiev";
            this.kievBtn.UseVisualStyleBackColor = false;
            // 
            // minskBtn
            // 
            this.minskBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minskBtn.BackColor = System.Drawing.Color.Azure;
            this.minskBtn.Location = new System.Drawing.Point(599, 16);
            this.minskBtn.Name = "minskBtn";
            this.minskBtn.Size = new System.Drawing.Size(76, 24);
            this.minskBtn.TabIndex = 8;
            this.minskBtn.Text = "Minsk";
            this.minskBtn.UseVisualStyleBackColor = false;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 462);
            this.Controls.Add(this.minskBtn);
            this.Controls.Add(this.kievBtn);
            this.Controls.Add(this.budapestBtn);
            this.Controls.Add(this.wienBtn);
            this.Controls.Add(this.prahaBtn);
            this.Controls.Add(this.berlinBtn);
            this.Controls.Add(this.warszawaBtn);
            this.DoubleBuffered = true;
            this.Name = "MapForm";
            this.Text = "Map";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button warszawaBtn;
        private System.Windows.Forms.Button berlinBtn;
        private System.Windows.Forms.Button prahaBtn;
        private System.Windows.Forms.Button wienBtn;
        private System.Windows.Forms.Button budapestBtn;
        private System.Windows.Forms.Button kievBtn;
        private System.Windows.Forms.Button minskBtn;
    }
}