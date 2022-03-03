
namespace AirCrewHelper_ManagerView
{
    partial class PilotUI
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
            this.gridPilot = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPilotName = new System.Windows.Forms.TextBox();
            this.lblPilotName = new System.Windows.Forms.Label();
            this.btnNewPilot = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPilotId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPilot)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPilot
            // 
            this.gridPilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPilot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Select,
            this.Delete});
            this.gridPilot.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridPilot.Location = new System.Drawing.Point(400, 0);
            this.gridPilot.Name = "gridPilot";
            this.gridPilot.RowTemplate.Height = 25;
            this.gridPilot.Size = new System.Drawing.Size(350, 633);
            this.gridPilot.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Name";
            this.Nome.Name = "Nome";
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // txtPilotName
            // 
            this.txtPilotName.Location = new System.Drawing.Point(64, 57);
            this.txtPilotName.Name = "txtPilotName";
            this.txtPilotName.Size = new System.Drawing.Size(233, 23);
            this.txtPilotName.TabIndex = 2;
            // 
            // lblPilotName
            // 
            this.lblPilotName.AutoSize = true;
            this.lblPilotName.Location = new System.Drawing.Point(19, 65);
            this.lblPilotName.Name = "lblPilotName";
            this.lblPilotName.Size = new System.Drawing.Size(39, 15);
            this.lblPilotName.TabIndex = 3;
            this.lblPilotName.Text = "Name";
            this.lblPilotName.Click += new System.EventHandler(this.lblPilotName_Click);
            // 
            // btnNewPilot
            // 
            this.btnNewPilot.Location = new System.Drawing.Point(303, 56);
            this.btnNewPilot.Name = "btnNewPilot";
            this.btnNewPilot.Size = new System.Drawing.Size(75, 23);
            this.btnNewPilot.TabIndex = 4;
            this.btnNewPilot.Text = "New";
            this.btnNewPilot.UseVisualStyleBackColor = true;
            this.btnNewPilot.Click += new System.EventHandler(this.txtNewPilot_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(64, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // lblPilotId
            // 
            this.lblPilotId.AutoSize = true;
            this.lblPilotId.Location = new System.Drawing.Point(19, 36);
            this.lblPilotId.Name = "lblPilotId";
            this.lblPilotId.Size = new System.Drawing.Size(17, 15);
            this.lblPilotId.TabIndex = 3;
            this.lblPilotId.Text = "Id";
            this.lblPilotId.Click += new System.EventHandler(this.lblPilotName_Click);
            // 
            // PilotUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 633);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNewPilot);
            this.Controls.Add(this.lblPilotId);
            this.Controls.Add(this.lblPilotName);
            this.Controls.Add(this.txtPilotName);
            this.Controls.Add(this.gridPilot);
            this.Name = "PilotUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PilotUI";
            this.Load += new System.EventHandler(this.PilotUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPilot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPilot;
        private System.Windows.Forms.TextBox txtPilotName;
        private System.Windows.Forms.Label lblPilotName;
        private System.Windows.Forms.Button btnNewPilot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPilotId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}