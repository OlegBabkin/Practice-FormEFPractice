namespace FormEFPractice
{
    partial class productsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productsForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductsTSMtem = new System.Windows.Forms.ToolStripMenuItem();
            this.delProductsTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mngCategoryTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.srch_lbl = new System.Windows.Forms.ToolStripLabel();
            this.srch_tb = new System.Windows.Forms.ToolStripTextBox();
            this.srch_cb = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.srch_btn = new System.Windows.Forms.ToolStripButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.exitTSMItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductTSMItem,
            this.updateProductsTSMtem,
            this.delProductsTSMItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // addProductTSMItem
            // 
            this.addProductTSMItem.Name = "addProductTSMItem";
            this.addProductTSMItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.addProductTSMItem.Size = new System.Drawing.Size(204, 22);
            this.addProductTSMItem.Text = "Add Product";
            this.addProductTSMItem.Click += new System.EventHandler(this.addProductTSMItem_Click);
            // 
            // updateProductsTSMtem
            // 
            this.updateProductsTSMtem.Name = "updateProductsTSMtem";
            this.updateProductsTSMtem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateProductsTSMtem.Size = new System.Drawing.Size(204, 22);
            this.updateProductsTSMtem.Text = "Update Products";
            this.updateProductsTSMtem.Click += new System.EventHandler(this.updateProductsTSMtem_Click);
            // 
            // delProductsTSMItem
            // 
            this.delProductsTSMItem.Name = "delProductsTSMItem";
            this.delProductsTSMItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.delProductsTSMItem.Size = new System.Drawing.Size(204, 22);
            this.delProductsTSMItem.Text = "Delete Products";
            this.delProductsTSMItem.Click += new System.EventHandler(this.delProductsTSMItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mngCategoryTSMItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // mngCategoryTSMItem
            // 
            this.mngCategoryTSMItem.Name = "mngCategoryTSMItem";
            this.mngCategoryTSMItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mngCategoryTSMItem.Size = new System.Drawing.Size(221, 22);
            this.mngCategoryTSMItem.Text = "Manage Categories";
            // 
            // exitTSMItem
            // 
            this.exitTSMItem.Name = "exitTSMItem";
            this.exitTSMItem.Size = new System.Drawing.Size(37, 20);
            this.exitTSMItem.Text = "Exit";
            this.exitTSMItem.Click += new System.EventHandler(this.exitTSMItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.srch_lbl,
            this.srch_tb,
            this.srch_cb,
            this.toolStripSeparator1,
            this.srch_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // srch_lbl
            // 
            this.srch_lbl.Name = "srch_lbl";
            this.srch_lbl.Size = new System.Drawing.Size(99, 22);
            this.srch_lbl.Text = "Search condition:";
            // 
            // srch_tb
            // 
            this.srch_tb.Name = "srch_tb";
            this.srch_tb.Size = new System.Drawing.Size(300, 25);
            this.srch_tb.ToolTipText = "Pleasae type part of product name";
            // 
            // srch_cb
            // 
            this.srch_cb.Name = "srch_cb";
            this.srch_cb.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // srch_btn
            // 
            this.srch_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.srch_btn.Image = ((System.Drawing.Image)(resources.GetObject("srch_btn.Image")));
            this.srch_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.srch_btn.Name = "srch_btn";
            this.srch_btn.Size = new System.Drawing.Size(46, 22);
            this.srch_btn.Text = "Search";
            this.srch_btn.Click += new System.EventHandler(this.srch_btn_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WPFAppPractice.domain.Product);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Category,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDataGridView.Location = new System.Drawing.Point(0, 49);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(810, 473);
            this.productDataGridView.TabIndex = 3;
            this.productDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.productDataGridView_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category.Name";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 522);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "productsForm";
            this.Text = "Products management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.productsForm_FormClosing);
            this.Load += new System.EventHandler(this.productsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductTSMItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductsTSMtem;
        private System.Windows.Forms.ToolStripMenuItem delProductsTSMItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mngCategoryTSMItem;
        private System.Windows.Forms.ToolStripMenuItem exitTSMItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel srch_lbl;
        private System.Windows.Forms.ToolStripTextBox srch_tb;
        private System.Windows.Forms.ToolStripButton srch_btn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox srch_cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

