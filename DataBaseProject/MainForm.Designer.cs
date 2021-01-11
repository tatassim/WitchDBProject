namespace DataBaseProject
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
            this.tcHabitat = new System.Windows.Forms.TabControl();
            this.witchTabPage = new System.Windows.Forms.TabPage();
            this.witchUserControl1 = new DataBaseProject.UserControls.WitchUserControl();
            this.covenTabPage = new System.Windows.Forms.TabPage();
            this.covenUserControl1 = new DataBaseProject.UserControls.CovenUserControl();
            this.Habitat = new System.Windows.Forms.TabPage();
            this.habitatUserControl1 = new DataBaseProject.UserControls.HabitatUserControl();
            this.tcHabitat.SuspendLayout();
            this.witchTabPage.SuspendLayout();
            this.covenTabPage.SuspendLayout();
            this.Habitat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcHabitat
            // 
            this.tcHabitat.Controls.Add(this.witchTabPage);
            this.tcHabitat.Controls.Add(this.covenTabPage);
            this.tcHabitat.Controls.Add(this.Habitat);
            this.tcHabitat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcHabitat.Location = new System.Drawing.Point(0, 0);
            this.tcHabitat.Name = "tcHabitat";
            this.tcHabitat.SelectedIndex = 0;
            this.tcHabitat.Size = new System.Drawing.Size(647, 319);
            this.tcHabitat.TabIndex = 0;
            // 
            // witchTabPage
            // 
            this.witchTabPage.Controls.Add(this.witchUserControl1);
            this.witchTabPage.Location = new System.Drawing.Point(4, 22);
            this.witchTabPage.Name = "witchTabPage";
            this.witchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.witchTabPage.Size = new System.Drawing.Size(639, 293);
            this.witchTabPage.TabIndex = 0;
            this.witchTabPage.Text = "Witch";
            this.witchTabPage.UseVisualStyleBackColor = true;
            // 
            // witchUserControl1
            // 
            this.witchUserControl1.AutoSize = true;
            this.witchUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.witchUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.witchUserControl1.Location = new System.Drawing.Point(3, 3);
            this.witchUserControl1.Name = "witchUserControl1";
            this.witchUserControl1.Size = new System.Drawing.Size(633, 287);
            this.witchUserControl1.TabIndex = 0;
            this.witchUserControl1.Load += new System.EventHandler(this.witchUserControl1_Load);
            // 
            // covenTabPage
            // 
            this.covenTabPage.Controls.Add(this.covenUserControl1);
            this.covenTabPage.Location = new System.Drawing.Point(4, 22);
            this.covenTabPage.Name = "covenTabPage";
            this.covenTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.covenTabPage.Size = new System.Drawing.Size(639, 293);
            this.covenTabPage.TabIndex = 1;
            this.covenTabPage.Text = "Coven";
            this.covenTabPage.UseVisualStyleBackColor = true;
            // 
            // covenUserControl1
            // 
            this.covenUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.covenUserControl1.Location = new System.Drawing.Point(3, 3);
            this.covenUserControl1.Name = "covenUserControl1";
            this.covenUserControl1.Size = new System.Drawing.Size(633, 287);
            this.covenUserControl1.TabIndex = 0;
            // 
            // Habitat
            // 
            this.Habitat.Controls.Add(this.habitatUserControl1);
            this.Habitat.Location = new System.Drawing.Point(4, 22);
            this.Habitat.Name = "Habitat";
            this.Habitat.Padding = new System.Windows.Forms.Padding(3);
            this.Habitat.Size = new System.Drawing.Size(639, 293);
            this.Habitat.TabIndex = 2;
            this.Habitat.Text = "Habitat";
            this.Habitat.UseVisualStyleBackColor = true;
            // 
            // habitatUserControl1
            // 
            this.habitatUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.habitatUserControl1.Location = new System.Drawing.Point(3, 3);
            this.habitatUserControl1.Name = "habitatUserControl1";
            this.habitatUserControl1.Size = new System.Drawing.Size(633, 287);
            this.habitatUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(647, 319);
            this.Controls.Add(this.tcHabitat);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tcHabitat.ResumeLayout(false);
            this.witchTabPage.ResumeLayout(false);
            this.witchTabPage.PerformLayout();
            this.covenTabPage.ResumeLayout(false);
            this.Habitat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcHabitat;
        private System.Windows.Forms.TabPage witchTabPage;
        private System.Windows.Forms.TabPage covenTabPage;
        private UserControls.WitchUserControl witchUserControl1;
        private UserControls.CovenUserControl covenUserControl1;
        private System.Windows.Forms.TabPage Habitat;
        private UserControls.HabitatUserControl habitatUserControl1;
    }
}

