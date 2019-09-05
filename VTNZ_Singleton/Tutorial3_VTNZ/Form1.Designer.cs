namespace Tutorial3_VTNZ
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
            this.LabelHeader = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelDetailsOfinspection = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelTotalPriceHeader = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelInspecCountHeader = new System.Windows.Forms.Label();
            this.labelInspectionCount = new System.Windows.Forms.Label();
            this.buttonRequestInspection = new System.Windows.Forms.Button();
            this.listBoxInspections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(327, 72);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(61, 13);
            this.LabelHeader.TabIndex = 0;
            this.LabelHeader.Text = "lblHeader";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(65, 147);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(60, 13);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "lblMessage";
            // 
            // labelDetailsOfinspection
            // 
            this.labelDetailsOfinspection.AutoSize = true;
            this.labelDetailsOfinspection.Location = new System.Drawing.Point(83, 299);
            this.labelDetailsOfinspection.Name = "labelDetailsOfinspection";
            this.labelDetailsOfinspection.Size = new System.Drawing.Size(160, 13);
            this.labelDetailsOfinspection.TabIndex = 2;
            this.labelDetailsOfinspection.Text = "Details Of Inspection Requested";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelDetails.Location = new System.Drawing.Point(83, 326);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(61, 13);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Text = "labelDetails";
            // 
            // labelTotalPriceHeader
            // 
            this.labelTotalPriceHeader.AutoSize = true;
            this.labelTotalPriceHeader.Location = new System.Drawing.Point(330, 354);
            this.labelTotalPriceHeader.Name = "labelTotalPriceHeader";
            this.labelTotalPriceHeader.Size = new System.Drawing.Size(202, 13);
            this.labelTotalPriceHeader.TabIndex = 4;
            this.labelTotalPriceHeader.Text = "Total Price For All Inspections Requested";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTotalPrice.Location = new System.Drawing.Point(333, 386);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(77, 13);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "labelTotalPrice";
            // 
            // labelInspecCountHeader
            // 
            this.labelInspecCountHeader.AutoSize = true;
            this.labelInspecCountHeader.Location = new System.Drawing.Point(587, 299);
            this.labelInspecCountHeader.Name = "labelInspecCountHeader";
            this.labelInspecCountHeader.Size = new System.Drawing.Size(195, 13);
            this.labelInspecCountHeader.TabIndex = 6;
            this.labelInspecCountHeader.Text = "Total Number of Inspections Requested";
            // 
            // labelInspectionCount
            // 
            this.labelInspectionCount.AutoSize = true;
            this.labelInspectionCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelInspectionCount.Location = new System.Drawing.Point(590, 325);
            this.labelInspectionCount.Name = "labelInspectionCount";
            this.labelInspectionCount.Size = new System.Drawing.Size(57, 13);
            this.labelInspectionCount.TabIndex = 7;
            this.labelInspectionCount.Text = "labelCount";
            // 
            // buttonRequestInspection
            // 
            this.buttonRequestInspection.Location = new System.Drawing.Point(68, 210);
            this.buttonRequestInspection.Name = "buttonRequestInspection";
            this.buttonRequestInspection.Size = new System.Drawing.Size(141, 23);
            this.buttonRequestInspection.TabIndex = 8;
            this.buttonRequestInspection.Text = "Request Inspection";
            this.buttonRequestInspection.UseVisualStyleBackColor = true;
            this.buttonRequestInspection.Click += new System.EventHandler(this.buttonRequestInspection_Click);
            // 
            // listBoxInspections
            // 
            this.listBoxInspections.FormattingEnabled = true;
            this.listBoxInspections.Location = new System.Drawing.Point(330, 138);
            this.listBoxInspections.Name = "listBoxInspections";
            this.listBoxInspections.Size = new System.Drawing.Size(250, 95);
            this.listBoxInspections.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 552);
            this.Controls.Add(this.listBoxInspections);
            this.Controls.Add(this.buttonRequestInspection);
            this.Controls.Add(this.labelInspectionCount);
            this.Controls.Add(this.labelInspecCountHeader);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelTotalPriceHeader);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelDetailsOfinspection);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.LabelHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelDetailsOfinspection;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelTotalPriceHeader;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelInspecCountHeader;
        private System.Windows.Forms.Label labelInspectionCount;
        private System.Windows.Forms.Button buttonRequestInspection;
        private System.Windows.Forms.ListBox listBoxInspections;
    }
}

