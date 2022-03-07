
namespace AirCrewHelper_ManagerView
{
    partial class AirPlaneUI
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
            this.txtAirPlaneId = new System.Windows.Forms.TextBox();
            this.btnNewAirPlane = new System.Windows.Forms.Button();
            this.lblPilotId = new System.Windows.Forms.Label();
            this.lblPilotName = new System.Windows.Forms.Label();
            this.txtAirPlaneName = new System.Windows.Forms.TextBox();
            this.grdAirPlane = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdAirPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAirPlaneId
            // 
            this.txtAirPlaneId.Enabled = false;
            this.txtAirPlaneId.Location = new System.Drawing.Point(55, 28);
            this.txtAirPlaneId.Name = "txtAirPlaneId";
            this.txtAirPlaneId.Size = new System.Drawing.Size(100, 23);
            this.txtAirPlaneId.TabIndex = 11;
            // 
            // btnNewAirPlane
            // 
            this.btnNewAirPlane.Location = new System.Drawing.Point(294, 56);
            this.btnNewAirPlane.Name = "btnNewAirPlane";
            this.btnNewAirPlane.Size = new System.Drawing.Size(75, 23);
            this.btnNewAirPlane.TabIndex = 10;
            this.btnNewAirPlane.Text = "New";
            this.btnNewAirPlane.UseVisualStyleBackColor = true;
            this.btnNewAirPlane.Click += new System.EventHandler(this.btnNewAirPlane_Click);
            // 
            // lblPilotId
            // 
            this.lblPilotId.AutoSize = true;
            this.lblPilotId.Location = new System.Drawing.Point(10, 36);
            this.lblPilotId.Name = "lblPilotId";
            this.lblPilotId.Size = new System.Drawing.Size(17, 15);
            this.lblPilotId.TabIndex = 8;
            this.lblPilotId.Text = "Id";
            // 
            // lblPilotName
            // 
            this.lblPilotName.AutoSize = true;
            this.lblPilotName.Location = new System.Drawing.Point(10, 65);
            this.lblPilotName.Name = "lblPilotName";
            this.lblPilotName.Size = new System.Drawing.Size(39, 15);
            this.lblPilotName.TabIndex = 9;
            this.lblPilotName.Text = "Name";
            // 
            // txtAirPlaneName
            // 
            this.txtAirPlaneName.Location = new System.Drawing.Point(55, 57);
            this.txtAirPlaneName.Name = "txtAirPlaneName";
            this.txtAirPlaneName.Size = new System.Drawing.Size(233, 23);
            this.txtAirPlaneName.TabIndex = 7;
            // 
            // grdAirPlane
            // 
            this.grdAirPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAirPlane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Select,
            this.Delete});
            this.grdAirPlane.Dock = System.Windows.Forms.DockStyle.Right;
            this.grdAirPlane.Location = new System.Drawing.Point(400, 0);
            this.grdAirPlane.Name = "grdAirPlane";
            this.grdAirPlane.RowTemplate.Height = 25;
            this.grdAirPlane.Size = new System.Drawing.Size(350, 633);
            this.grdAirPlane.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Name";
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
            // AirPlaneUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 633);
            this.Controls.Add(this.txtAirPlaneId);
            this.Controls.Add(this.btnNewAirPlane);
            this.Controls.Add(this.lblPilotId);
            this.Controls.Add(this.lblPilotName);
            this.Controls.Add(this.txtAirPlaneName);
            this.Controls.Add(this.grdAirPlane);
            this.Name = "AirPlaneUI";
            this.Text = "AirPlane";
            this.Load += new System.EventHandler(this.AirPlaneUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAirPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAirPlaneId;
        private System.Windows.Forms.Button btnNewAirPlane;
        private System.Windows.Forms.Label lblPilotId;
        private System.Windows.Forms.Label lblPilotName;
        private System.Windows.Forms.TextBox txtAirPlaneName;
        private System.Windows.Forms.DataGridView grdAirPlane;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}