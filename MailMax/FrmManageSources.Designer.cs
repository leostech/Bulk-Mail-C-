﻿
namespace MailMax
{
    partial class FrmManageSources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageSources));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstSources = new System.Windows.Forms.ListView();
            this.MailName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteThisMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrShow = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 55);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Image = global::MailMax.Properties.Resources.Minimize;
            this.label4.Location = new System.Drawing.Point(680, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 30);
            this.label4.TabIndex = 3;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.lblHoverEffect_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.lblHoverEffect_MouseHover);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHoverEffect_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Enabled = false;
            this.label3.Image = global::MailMax.Properties.Resources.Maximze;
            this.label3.Location = new System.Drawing.Point(718, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(755, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.lblHoverEffect_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.lblHoverEffect_MouseHover);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHoverEffect_MouseMove);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(800, 55);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sources Settings";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSources
            // 
            this.lstSources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.lstSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MailName,
            this.Emails});
            this.lstSources.ContextMenuStrip = this.contextMenuStrip1;
            this.lstSources.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSources.ForeColor = System.Drawing.Color.White;
            this.lstSources.FullRowSelect = true;
            this.lstSources.HideSelection = false;
            this.lstSources.Location = new System.Drawing.Point(20, 71);
            this.lstSources.MultiSelect = false;
            this.lstSources.Name = "lstSources";
            this.lstSources.Size = new System.Drawing.Size(765, 381);
            this.lstSources.TabIndex = 40;
            this.lstSources.UseCompatibleStateImageBehavior = false;
            this.lstSources.View = System.Windows.Forms.View.Details;
            // 
            // MailName
            // 
            this.MailName.Text = "Name";
            this.MailName.Width = 286;
            // 
            // Emails
            // 
            this.Emails.Text = "Number Of Emails";
            this.Emails.Width = 195;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMessageToolStripMenuItem,
            this.deleteThisMessageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 48);
            // 
            // addNewMessageToolStripMenuItem
            // 
            this.addNewMessageToolStripMenuItem.Name = "addNewMessageToolStripMenuItem";
            this.addNewMessageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addNewMessageToolStripMenuItem.Text = "Add new source";
            this.addNewMessageToolStripMenuItem.Click += new System.EventHandler(this.addNewMessageToolStripMenuItem_Click);
            // 
            // deleteThisMessageToolStripMenuItem
            // 
            this.deleteThisMessageToolStripMenuItem.Name = "deleteThisMessageToolStripMenuItem";
            this.deleteThisMessageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteThisMessageToolStripMenuItem.Text = "Delete this source";
            this.deleteThisMessageToolStripMenuItem.Click += new System.EventHandler(this.deleteThisMessageToolStripMenuItem_Click);
            // 
            // tmrShow
            // 
            this.tmrShow.Enabled = true;
            this.tmrShow.Interval = 20;
            this.tmrShow.Tick += new System.EventHandler(this.tmrShow_Tick);
            // 
            // FrmManageSources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.ControlBox = false;
            this.Controls.Add(this.lstSources);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManageSources";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmManageSources_Load);
            this.Resize += new System.EventHandler(this.FrmManageSources_Resize);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstSources;
        private System.Windows.Forms.ColumnHeader MailName;
        private System.Windows.Forms.ColumnHeader Emails;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisMessageToolStripMenuItem;
        private System.Windows.Forms.Timer tmrShow;
    }
}