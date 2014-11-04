namespace MonteCarlo.CustomControl
{
    partial class TaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbTaskCost = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblTaskName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbTaskCost
            // 
            this.txbTaskCost.Location = new System.Drawing.Point(135, 12);
            this.txbTaskCost.Name = "txbTaskCost";
            this.txbTaskCost.Size = new System.Drawing.Size(188, 20);
            this.txbTaskCost.TabIndex = 0;
            this.txbTaskCost.Text = "Task Cost";
            this.txbTaskCost.Enter += new System.EventHandler(this.txbTaskCost_Enter);
            this.txbTaskCost.MouseHover += new System.EventHandler(this.txbTaskCost_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(14, 15);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(62, 13);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "Task Name";
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.txbTaskCost);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(600, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTaskCost;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTaskName;
    }
}
