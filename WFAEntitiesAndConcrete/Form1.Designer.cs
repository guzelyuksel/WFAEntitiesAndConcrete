namespace WFAEntitiesAndConcrete
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
            this.gbCreateCar = new System.Windows.Forms.GroupBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.gbFindCar = new System.Windows.Forms.GroupBox();
            this.txtUpdateBrand = new System.Windows.Forms.TextBox();
            this.lblUpdateBrand = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.txtUpdateModel = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.lblUpdateModel = new System.Windows.Forms.Label();
            this.lblUpdatePrice = new System.Windows.Forms.Label();
            this.lblSearchId = new System.Windows.Forms.Label();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbCreateCar.SuspendLayout();
            this.gbFindCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCreateCar
            // 
            this.gbCreateCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCreateCar.Controls.Add(this.txtBrand);
            this.gbCreateCar.Controls.Add(this.lblBrand);
            this.gbCreateCar.Controls.Add(this.btnSave);
            this.gbCreateCar.Controls.Add(this.txtPrice);
            this.gbCreateCar.Controls.Add(this.txtModel);
            this.gbCreateCar.Controls.Add(this.lblPrice);
            this.gbCreateCar.Controls.Add(this.lblModel);
            this.gbCreateCar.Location = new System.Drawing.Point(13, 13);
            this.gbCreateCar.Margin = new System.Windows.Forms.Padding(4);
            this.gbCreateCar.Name = "gbCreateCar";
            this.gbCreateCar.Padding = new System.Windows.Forms.Padding(4);
            this.gbCreateCar.Size = new System.Drawing.Size(482, 256);
            this.gbCreateCar.TabIndex = 0;
            this.gbCreateCar.TabStop = false;
            this.gbCreateCar.Text = "Create Car";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(85, 28);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(208, 24);
            this.txtBrand.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(13, 31);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(57, 18);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Brand:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(84, 87);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(208, 24);
            this.txtPrice.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(85, 57);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(208, 24);
            this.txtModel.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 90);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 18);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price: ";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(13, 63);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(64, 18);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model: ";
            // 
            // gbFindCar
            // 
            this.gbFindCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbFindCar.Controls.Add(this.btnDelete);
            this.gbFindCar.Controls.Add(this.txtUpdateBrand);
            this.gbFindCar.Controls.Add(this.lblUpdateBrand);
            this.gbFindCar.Controls.Add(this.btnUpdate);
            this.gbFindCar.Controls.Add(this.txtUpdatePrice);
            this.gbFindCar.Controls.Add(this.txtUpdateModel);
            this.gbFindCar.Controls.Add(this.btnFind);
            this.gbFindCar.Controls.Add(this.txtSearchId);
            this.gbFindCar.Controls.Add(this.lblUpdateModel);
            this.gbFindCar.Controls.Add(this.lblUpdatePrice);
            this.gbFindCar.Controls.Add(this.lblSearchId);
            this.gbFindCar.Location = new System.Drawing.Point(503, 13);
            this.gbFindCar.Margin = new System.Windows.Forms.Padding(4);
            this.gbFindCar.Name = "gbFindCar";
            this.gbFindCar.Padding = new System.Windows.Forms.Padding(4);
            this.gbFindCar.Size = new System.Drawing.Size(505, 256);
            this.gbFindCar.TabIndex = 1;
            this.gbFindCar.TabStop = false;
            this.gbFindCar.Text = "Find Car";
            // 
            // txtUpdateBrand
            // 
            this.txtUpdateBrand.Location = new System.Drawing.Point(130, 113);
            this.txtUpdateBrand.Name = "txtUpdateBrand";
            this.txtUpdateBrand.Size = new System.Drawing.Size(208, 24);
            this.txtUpdateBrand.TabIndex = 6;
            // 
            // lblUpdateBrand
            // 
            this.lblUpdateBrand.AutoSize = true;
            this.lblUpdateBrand.Location = new System.Drawing.Point(8, 116);
            this.lblUpdateBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateBrand.Name = "lblUpdateBrand";
            this.lblUpdateBrand.Size = new System.Drawing.Size(115, 18);
            this.lblUpdateBrand.TabIndex = 9;
            this.lblUpdateBrand.Text = "Update Brand:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(11, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 45);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(130, 176);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(208, 24);
            this.txtUpdatePrice.TabIndex = 8;
            // 
            // txtUpdateModel
            // 
            this.txtUpdateModel.Location = new System.Drawing.Point(130, 145);
            this.txtUpdateModel.Name = "txtUpdateModel";
            this.txtUpdateModel.Size = new System.Drawing.Size(208, 24);
            this.txtUpdateModel.TabIndex = 7;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(130, 50);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(208, 48);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(130, 25);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(208, 24);
            this.txtSearchId.TabIndex = 4;
            // 
            // lblUpdateModel
            // 
            this.lblUpdateModel.AutoSize = true;
            this.lblUpdateModel.Location = new System.Drawing.Point(8, 148);
            this.lblUpdateModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateModel.Name = "lblUpdateModel";
            this.lblUpdateModel.Size = new System.Drawing.Size(122, 18);
            this.lblUpdateModel.TabIndex = 2;
            this.lblUpdateModel.Text = "Update Model: ";
            // 
            // lblUpdatePrice
            // 
            this.lblUpdatePrice.AutoSize = true;
            this.lblUpdatePrice.Location = new System.Drawing.Point(8, 179);
            this.lblUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdatePrice.Name = "lblUpdatePrice";
            this.lblUpdatePrice.Size = new System.Drawing.Size(115, 18);
            this.lblUpdatePrice.TabIndex = 2;
            this.lblUpdatePrice.Text = "Update Price: ";
            // 
            // lblSearchId
            // 
            this.lblSearchId.AutoSize = true;
            this.lblSearchId.Location = new System.Drawing.Point(8, 28);
            this.lblSearchId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchId.Name = "lblSearchId";
            this.lblSearchId.Size = new System.Drawing.Size(89, 18);
            this.lblSearchId.TabIndex = 1;
            this.lblSearchId.Text = "Search Id: ";
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCars.Location = new System.Drawing.Point(13, 277);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCars.Size = new System.Drawing.Size(995, 356);
            this.dgvCars.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(225, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 45);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1023, 643);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.gbFindCar);
            this.Controls.Add(this.gbCreateCar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCreateCar.ResumeLayout(false);
            this.gbCreateCar.PerformLayout();
            this.gbFindCar.ResumeLayout(false);
            this.gbFindCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreateCar;
        private System.Windows.Forms.GroupBox gbFindCar;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUpdateModel;
        private System.Windows.Forms.Label lblUpdatePrice;
        private System.Windows.Forms.Label lblSearchId;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.TextBox txtUpdateModel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtUpdateBrand;
        private System.Windows.Forms.Label lblUpdateBrand;
        private System.Windows.Forms.Button btnDelete;
    }
}

