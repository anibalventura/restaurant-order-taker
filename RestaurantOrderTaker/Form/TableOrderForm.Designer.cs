
namespace RestaurantOrderTaker
{
    partial class TableOrderForm
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
            this.TblTableOrder = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSaveOrders = new System.Windows.Forms.Button();
            this.BtnCancelOrders = new System.Windows.Forms.Button();
            this.BtnTakeOrder = new System.Windows.Forms.Button();
            this.LbxOrders = new System.Windows.Forms.ListBox();
            this.LblTableToOrder = new System.Windows.Forms.Label();
            this.CmbxPeopleOntable = new System.Windows.Forms.ComboBox();
            this.LblNumberOfPeople = new System.Windows.Forms.Label();
            this.TblTableOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblTableOrder
            // 
            this.TblTableOrder.ColumnCount = 4;
            this.TblTableOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TblTableOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TblTableOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TblTableOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TblTableOrder.Controls.Add(this.BtnSaveOrders, 1, 5);
            this.TblTableOrder.Controls.Add(this.BtnCancelOrders, 2, 5);
            this.TblTableOrder.Controls.Add(this.BtnTakeOrder, 1, 4);
            this.TblTableOrder.Controls.Add(this.LbxOrders, 1, 2);
            this.TblTableOrder.Controls.Add(this.LblTableToOrder, 1, 0);
            this.TblTableOrder.Controls.Add(this.CmbxPeopleOntable, 2, 1);
            this.TblTableOrder.Controls.Add(this.LblNumberOfPeople, 1, 1);
            this.TblTableOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblTableOrder.Location = new System.Drawing.Point(0, 0);
            this.TblTableOrder.Name = "TblTableOrder";
            this.TblTableOrder.RowCount = 6;
            this.TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TblTableOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TblTableOrder.Size = new System.Drawing.Size(564, 450);
            this.TblTableOrder.TabIndex = 0;
            // 
            // BtnSaveOrders
            // 
            this.BtnSaveOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveOrders.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSaveOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveOrders.Location = new System.Drawing.Point(87, 378);
            this.BtnSaveOrders.Name = "BtnSaveOrders";
            this.BtnSaveOrders.Size = new System.Drawing.Size(191, 30);
            this.BtnSaveOrders.TabIndex = 2;
            this.BtnSaveOrders.Text = "Save";
            this.BtnSaveOrders.UseVisualStyleBackColor = false;
            this.BtnSaveOrders.Click += new System.EventHandler(this.BtnSaveOrders_Click);
            // 
            // BtnCancelOrders
            // 
            this.BtnCancelOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelOrders.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancelOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelOrders.Location = new System.Drawing.Point(284, 378);
            this.BtnCancelOrders.Name = "BtnCancelOrders";
            this.BtnCancelOrders.Size = new System.Drawing.Size(191, 30);
            this.BtnCancelOrders.TabIndex = 3;
            this.BtnCancelOrders.Text = "Cancel";
            this.BtnCancelOrders.UseVisualStyleBackColor = false;
            this.BtnCancelOrders.Click += new System.EventHandler(this.BtnCancelOrders_Click);
            // 
            // BtnTakeOrder
            // 
            this.BtnTakeOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTakeOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TblTableOrder.SetColumnSpan(this.BtnTakeOrder, 2);
            this.BtnTakeOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTakeOrder.Location = new System.Drawing.Point(87, 303);
            this.BtnTakeOrder.Name = "BtnTakeOrder";
            this.BtnTakeOrder.Size = new System.Drawing.Size(388, 32);
            this.BtnTakeOrder.TabIndex = 4;
            this.BtnTakeOrder.Text = "Take an order";
            this.BtnTakeOrder.UseVisualStyleBackColor = false;
            this.BtnTakeOrder.Click += new System.EventHandler(this.BtnTakeOrder_Click);
            // 
            // LbxOrders
            // 
            this.LbxOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TblTableOrder.SetColumnSpan(this.LbxOrders, 2);
            this.LbxOrders.FormattingEnabled = true;
            this.LbxOrders.ItemHeight = 15;
            this.LbxOrders.Location = new System.Drawing.Point(87, 153);
            this.LbxOrders.Name = "LbxOrders";
            this.TblTableOrder.SetRowSpan(this.LbxOrders, 2);
            this.LbxOrders.Size = new System.Drawing.Size(388, 139);
            this.LbxOrders.TabIndex = 0;
            // 
            // LblTableToOrder
            // 
            this.LblTableToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTableToOrder.AutoSize = true;
            this.TblTableOrder.SetColumnSpan(this.LblTableToOrder, 2);
            this.LblTableToOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTableToOrder.Location = new System.Drawing.Point(87, 22);
            this.LblTableToOrder.Name = "LblTableToOrder";
            this.LblTableToOrder.Size = new System.Drawing.Size(388, 30);
            this.LblTableToOrder.TabIndex = 5;
            this.LblTableToOrder.Text = "Table # 0";
            this.LblTableToOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbxPeopleOntable
            // 
            this.CmbxPeopleOntable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbxPeopleOntable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxPeopleOntable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CmbxPeopleOntable.FormattingEnabled = true;
            this.CmbxPeopleOntable.Location = new System.Drawing.Point(284, 98);
            this.CmbxPeopleOntable.Name = "CmbxPeopleOntable";
            this.CmbxPeopleOntable.Size = new System.Drawing.Size(191, 29);
            this.CmbxPeopleOntable.TabIndex = 1;
            // 
            // LblNumberOfPeople
            // 
            this.LblNumberOfPeople.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblNumberOfPeople.AutoSize = true;
            this.LblNumberOfPeople.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNumberOfPeople.Location = new System.Drawing.Point(132, 102);
            this.LblNumberOfPeople.Name = "LblNumberOfPeople";
            this.LblNumberOfPeople.Size = new System.Drawing.Size(146, 21);
            this.LblNumberOfPeople.TabIndex = 6;
            this.LblNumberOfPeople.Text = "Number of people";
            // 
            // TableOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.TblTableOrder);
            this.Name = "TableOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TableOrderForm_FormClosed);
            this.Load += new System.EventHandler(this.TableOrderForm_Load);
            this.VisibleChanged += new System.EventHandler(this.TableOrderForm_VisibleChanged);
            this.TblTableOrder.ResumeLayout(false);
            this.TblTableOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblTableOrder;
        private System.Windows.Forms.Button BtnSaveOrders;
        private System.Windows.Forms.Button BtnCancelOrders;
        private System.Windows.Forms.Button BtnTakeOrder;
        private System.Windows.Forms.ListBox LbxOrders;
        private System.Windows.Forms.ComboBox CmbxPeopleOntable;
        private System.Windows.Forms.Label LblTableToOrder;
        private System.Windows.Forms.Label LblNumberOfPeople;
    }
}