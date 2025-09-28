using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace sc2css;

public class AboutForm : Form
{
	private IContainer components;

	private Button button1;

	private GroupBox groupBox1;

	private Label label3;

	private Label label2;

	private Label label1;

	public AboutForm()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.button1 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.button1.Location = new System.Drawing.Point(129, 154);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 0;
		this.button1.Text = "OK";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Location = new System.Drawing.Point(26, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(298, 124);
		this.groupBox1.TabIndex = 1;
		this.groupBox1.TabStop = false;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(56, 82);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(167, 13);
		this.label3.TabIndex = 2;
		this.label3.Text = "Right click an entry to copy/paste";
		this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(119, 49);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(37, 13);
		this.label2.TabIndex = 1;
		this.label2.Text = "v0.4.1";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(32, 20);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(221, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Soul Calibur 2 Character Select Screen Editor";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(349, 203);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.button1);
		base.Name = "AboutForm";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "About";
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
	}
}
