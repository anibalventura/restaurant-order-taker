
namespace RestaurantOrderTaker
{
    partial class TakeOrderForm
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
            this.TblTakeOrder = new System.Windows.Forms.TableLayoutPanel();
            this.LblName = new System.Windows.Forms.Label();
            this.LblStarter = new System.Windows.Forms.Label();
            this.LblMainPlate = new System.Windows.Forms.Label();
            this.LblDrink = new System.Windows.Forms.Label();
            this.LblDessert = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.CmbxStarter = new System.Windows.Forms.ComboBox();
            this.CmbxMainPlate = new System.Windows.Forms.ComboBox();
            this.CmbxDrink = new System.Windows.Forms.ComboBox();
            this.CmbxDessert = new System.Windows.Forms.ComboBox();
            this.BtnCancelOrder = new System.Windows.Forms.Button();
            this.BtnSaveOrder = new System.Windows.Forms.Button();
            this.TblTakeOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblTakeOrder
            // 
            this.TblTakeOrder.ColumnCount = 4;
            this.TblTakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TblTakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TblTakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TblTakeOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TblTakeOrder.Controls.Add(this.LblName, 1, 1);
            this.TblTakeOrder.Controls.Add(this.LblStarter, 1, 2);
            this.TblTakeOrder.Controls.Add(this.LblMainPlate, 1, 3);
            this.TblTakeOrder.Controls.Add(this.LblDrink, 1, 4);
            this.TblTakeOrder.Controls.Add(this.LblDessert, 1, 5);
            this.TblTakeOrder.Controls.Add(this.TxbName, 2, 1);
            this.TblTakeOrder.Controls.Add(this.CmbxStarter, 2, 2);
            this.TblTakeOrder.Controls.Add(this.CmbxMainPlate, 2, 3);
            this.TblTakeOrder.Controls.Add(this.CmbxDrink, 2, 4);
            this.TblTakeOrder.Controls.Add(this.CmbxDessert, 2, 5);
            this.TblTakeOrder.Controls.Add(this.BtnCancelOrder, 2, 6);
            this.TblTakeOrder.Controls.Add(this.BtnSaveOrder, 1, 6);
            this.TblTakeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblTakeOrder.Location = new System.Drawing.Point(0, 0);
            this.TblTakeOrder.Name = "TblTakeOrder";
            this.TblTakeOrder.RowCount = 8;
            this.TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblTakeOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TblTakeOrder.Size = new System.Drawing.Size(566, 450);
            this.TblTakeOrder.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(226, 56);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(53, 21);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // LblStarter
            // 
            this.LblStarter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblStarter.AutoSize = true;
            this.LblStarter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblStarter.Location = new System.Drawing.Point(219, 112);
            this.LblStarter.Name = "LblStarter";
            this.LblStarter.Size = new System.Drawing.Size(60, 21);
            this.LblStarter.TabIndex = 1;
            this.LblStarter.Text = "Starter";
            // 
            // LblMainPlate
            // 
            this.LblMainPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMainPlate.AutoSize = true;
            this.LblMainPlate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMainPlate.Location = new System.Drawing.Point(192, 168);
            this.LblMainPlate.Name = "LblMainPlate";
            this.LblMainPlate.Size = new System.Drawing.Size(87, 21);
            this.LblMainPlate.TabIndex = 2;
            this.LblMainPlate.Text = "Main plate";
            // 
            // LblDrink
            // 
            this.LblDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDrink.AutoSize = true;
            this.LblDrink.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDrink.Location = new System.Drawing.Point(211, 224);
            this.LblDrink.Name = "LblDrink";
            this.LblDrink.Size = new System.Drawing.Size(68, 21);
            this.LblDrink.TabIndex = 3;
            this.LblDrink.Text = "To drink";
            // 
            // LblDessert
            // 
            this.LblDessert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDessert.AutoSize = true;
            this.LblDessert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDessert.Location = new System.Drawing.Point(214, 280);
            this.LblDessert.Name = "LblDessert";
            this.LblDessert.Size = new System.Drawing.Size(65, 21);
            this.LblDessert.TabIndex = 4;
            this.LblDessert.Text = "Dessert";
            // 
            // TxbName
            // 
            this.TxbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbName.Location = new System.Drawing.Point(285, 59);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(192, 29);
            this.TxbName.TabIndex = 6;
            // 
            // CmbxStarter
            // 
            this.CmbxStarter.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbxStarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxStarter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbxStarter.FormattingEnabled = true;
            this.CmbxStarter.Location = new System.Drawing.Point(285, 115);
            this.CmbxStarter.Name = "CmbxStarter";
            this.CmbxStarter.Size = new System.Drawing.Size(192, 29);
            this.CmbxStarter.TabIndex = 7;
            // 
            // CmbxMainPlate
            // 
            this.CmbxMainPlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbxMainPlate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxMainPlate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbxMainPlate.FormattingEnabled = true;
            this.CmbxMainPlate.Location = new System.Drawing.Point(285, 171);
            this.CmbxMainPlate.Name = "CmbxMainPlate";
            this.CmbxMainPlate.Size = new System.Drawing.Size(192, 29);
            this.CmbxMainPlate.TabIndex = 8;
            // 
            // CmbxDrink
            // 
            this.CmbxDrink.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbxDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxDrink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbxDrink.FormattingEnabled = true;
            this.CmbxDrink.Location = new System.Drawing.Point(285, 227);
            this.CmbxDrink.Name = "CmbxDrink";
            this.CmbxDrink.Size = new System.Drawing.Size(192, 29);
            this.CmbxDrink.TabIndex = 9;
            // 
            // CmbxDessert
            // 
            this.CmbxDessert.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbxDessert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxDessert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbxDessert.FormattingEnabled = true;
            this.CmbxDessert.Location = new System.Drawing.Point(285, 283);
            this.CmbxDessert.Name = "CmbxDessert";
            this.CmbxDessert.Size = new System.Drawing.Size(192, 29);
            this.CmbxDessert.TabIndex = 10;
            // 
            // BtnCancelOrder
            // 
            this.BtnCancelOrder.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancelOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCancelOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelOrder.Location = new System.Drawing.Point(285, 356);
            this.BtnCancelOrder.Name = "BtnCancelOrder";
            this.BtnCancelOrder.Size = new System.Drawing.Size(192, 33);
            this.BtnCancelOrder.TabIndex = 13;
            this.BtnCancelOrder.Text = "Cancel";
            this.BtnCancelOrder.UseVisualStyleBackColor = false;
            this.BtnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click);
            // 
            // BtnSaveOrder
            // 
            this.BtnSaveOrder.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSaveOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSaveOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveOrder.Location = new System.Drawing.Point(87, 356);
            this.BtnSaveOrder.Name = "BtnSaveOrder";
            this.BtnSaveOrder.Size = new System.Drawing.Size(192, 33);
            this.BtnSaveOrder.TabIndex = 12;
            this.BtnSaveOrder.Text = "Save";
            this.BtnSaveOrder.UseVisualStyleBackColor = false;
            this.BtnSaveOrder.Click += new System.EventHandler(this.BtnSaveOrder_Click);
            // 
            // TakeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.TblTakeOrder);
            this.Name = "TakeOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take an Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TakeOrderForm_FormClosed);
            this.Load += new System.EventHandler(this.TakeOrderForm_Load);
            this.TblTakeOrder.ResumeLayout(false);
            this.TblTakeOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblTakeOrder;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblStarter;
        private System.Windows.Forms.Label LblMainPlate;
        private System.Windows.Forms.Label LblDrink;
        private System.Windows.Forms.Label LblDessert;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.ComboBox CmbxStarter;
        private System.Windows.Forms.ComboBox CmbxMainPlate;
        private System.Windows.Forms.ComboBox CmbxDrink;
        private System.Windows.Forms.ComboBox CmbxDessert;
        private System.Windows.Forms.Button BtnCancelOrder;
        private System.Windows.Forms.Button BtnSaveOrder;
    }
}