namespace Assignment__2._3
{
    partial class CafeAntoinette
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CafeAntoinette));
            StartOrder = new Button();
            textCustomerName = new TextBox();
            CustomerName = new Label();
            CustomerOrder = new Label();
            textCustomerOrder = new TextBox();
            CustomerTotal = new Label();
            CoffeeMenu = new ListBox();
            TotalRevenue = new Label();
            CompleteOrder = new Button();
            OrderReady = new Button();
            labelTotalRev = new Label();
            labelCustomerTotal = new Label();
            SuspendLayout();
            // 
            // StartOrder
            // 
            StartOrder.AutoEllipsis = true;
            StartOrder.Location = new Point(24, 250);
            StartOrder.Name = "StartOrder";
            StartOrder.Size = new Size(181, 50);
            StartOrder.TabIndex = 1;
            StartOrder.Text = "Start Customer Order";
            StartOrder.UseVisualStyleBackColor = true;
            StartOrder.Click += StartOrder_Click;
            // 
            // textCustomerName
            // 
            textCustomerName.Location = new Point(513, 161);
            textCustomerName.Name = "textCustomerName";
            textCustomerName.Size = new Size(215, 23);
            textCustomerName.TabIndex = 2;
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerName.Location = new Point(336, 163);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(137, 21);
            CustomerName.TabIndex = 4;
            CustomerName.Text = "Customer Name ";
            CustomerName.Click += CustomerName_Click;
            // 
            // CustomerOrder
            // 
            CustomerOrder.AutoSize = true;
            CustomerOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerOrder.Location = new Point(336, 190);
            CustomerOrder.Name = "CustomerOrder";
            CustomerOrder.Size = new Size(130, 21);
            CustomerOrder.TabIndex = 5;
            CustomerOrder.Text = "Customer Order";
            CustomerOrder.Click += CustomerOrder_Click;
            // 
            // textCustomerOrder
            // 
            textCustomerOrder.Location = new Point(513, 192);
            textCustomerOrder.Name = "textCustomerOrder";
            textCustomerOrder.Size = new Size(215, 23);
            textCustomerOrder.TabIndex = 6;
            textCustomerOrder.TextChanged += textBox2_TextChanged;
            // 
            // CustomerTotal
            // 
            CustomerTotal.AutoSize = true;
            CustomerTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerTotal.Location = new Point(336, 230);
            CustomerTotal.Name = "CustomerTotal";
            CustomerTotal.Size = new Size(171, 21);
            CustomerTotal.TabIndex = 7;
            CustomerTotal.Text = "Customer's Total Due";
            CustomerTotal.Click += label3_Click;
            // 
            // CoffeeMenu
            // 
            CoffeeMenu.BackColor = SystemColors.Info;
            CoffeeMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CoffeeMenu.FormattingEnabled = true;
            CoffeeMenu.Items.AddRange(new object[] { "Cafe Antoinette Menu", "", "Coffee  $5.00", "Tea        $5.00", "Latte     $5.00", "Iced Latte  $5.00", "Iced Coffee  $5.00" });
            CoffeeMenu.Location = new Point(12, 12);
            CoffeeMenu.Name = "CoffeeMenu";
            CoffeeMenu.Size = new Size(193, 204);
            CoffeeMenu.TabIndex = 9;
            CoffeeMenu.Tag = "Coffee Menu";
            // 
            // TotalRevenue
            // 
            TotalRevenue.AutoSize = true;
            TotalRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalRevenue.Location = new Point(322, 410);
            TotalRevenue.Name = "TotalRevenue";
            TotalRevenue.Size = new Size(118, 21);
            TotalRevenue.TabIndex = 10;
            TotalRevenue.Text = "Total Revenue";
            // 
            // CompleteOrder
            // 
            CompleteOrder.Location = new Point(24, 353);
            CompleteOrder.Name = "CompleteOrder";
            CompleteOrder.Size = new Size(181, 50);
            CompleteOrder.TabIndex = 12;
            CompleteOrder.Text = "Complete Customer Order";
            CompleteOrder.UseVisualStyleBackColor = true;
            CompleteOrder.Click += CompleteOrder_Click;
            // 
            // OrderReady
            // 
            OrderReady.Location = new Point(24, 306);
            OrderReady.Name = "OrderReady";
            OrderReady.Size = new Size(181, 41);
            OrderReady.TabIndex = 13;
            OrderReady.Text = "Customer Order Ready";
            OrderReady.UseVisualStyleBackColor = true;
            OrderReady.Click += OrderReady_Click;
            // 
            // labelTotalRev
            // 
            labelTotalRev.AutoSize = true;
            labelTotalRev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalRev.Location = new Point(468, 410);
            labelTotalRev.Name = "labelTotalRev";
            labelTotalRev.Size = new Size(19, 21);
            labelTotalRev.TabIndex = 14;
            labelTotalRev.Text = "0";
            // 
            // labelCustomerTotal
            // 
            labelCustomerTotal.AutoSize = true;
            labelCustomerTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCustomerTotal.Location = new Point(529, 230);
            labelCustomerTotal.Name = "labelCustomerTotal";
            labelCustomerTotal.Size = new Size(19, 21);
            labelCustomerTotal.TabIndex = 15;
            labelCustomerTotal.Text = "0";
            // 
            // CafeAntoinette
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCustomerTotal);
            Controls.Add(labelTotalRev);
            Controls.Add(OrderReady);
            Controls.Add(CompleteOrder);
            Controls.Add(TotalRevenue);
            Controls.Add(CoffeeMenu);
            Controls.Add(CustomerTotal);
            Controls.Add(textCustomerOrder);
            Controls.Add(CustomerOrder);
            Controls.Add(CustomerName);
            Controls.Add(textCustomerName);
            Controls.Add(StartOrder);
            Name = "CafeAntoinette";
            Text = "Cafe  Antoinette ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button StartOrder;
        private TextBox textCustomerName;
        private Label CustomerName;
        private Label CustomerOrder;
        private TextBox textCustomerOrder;
        private Label CustomerTotal;
        private ListBox CoffeeMenu;
        private Label TotalRevenue;
        private Button CompleteOrder;
        private Button OrderReady;
        private Label labelTotalRev;
        private Label labelCustomerTotal;
    }
}
