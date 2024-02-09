
namespace applicationDevelopmentCW1
{
    partial class CustomerDetails
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
            this.dataGridViewCustomerDetails = new System.Windows.Forms.DataGridView();
            this.customer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomerDetails
            // 
            this.dataGridViewCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerDetails.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewCustomerDetails.Name = "dataGridViewCustomerDetails";
            this.dataGridViewCustomerDetails.RowHeadersWidth = 51;
            this.dataGridViewCustomerDetails.RowTemplate.Height = 24;
            this.dataGridViewCustomerDetails.Size = new System.Drawing.Size(776, 416);
            this.dataGridViewCustomerDetails.TabIndex = 0;
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(284, 13);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(115, 17);
            this.customer.TabIndex = 1;
            this.customer.Text = "Customer Details";
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.dataGridViewCustomerDetails);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomerDetails;
        private System.Windows.Forms.Label customer;
    }
}