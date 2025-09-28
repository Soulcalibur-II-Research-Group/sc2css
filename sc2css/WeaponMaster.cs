using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace sc2css;

public class WeaponMaster : Form
{
	public bool slotSelected;

	private int selectedIdx;

	private List<Button> cssButtons = new List<Button>();

	private IContainer components;

	private ContextMenuStrip contextMenuStrip1;

	private ComboBox characterBox;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel statusLabel;

	public WeaponMaster()
	{
		InitializeComponent();
		CreateCSSBoxes();
	}

	private void b_MouseDown(object sender, MouseEventArgs e)
	{
		Button obj = (Button)sender;
		obj.PerformClick();
		obj.Select();
		_ = e.Button;
		_ = 1048576;
		_ = e.Button;
		_ = 2097152;
	}

	private void slotxx_Click(object sender, EventArgs e)
	{
		Button item = sender as Button;
		int num = cssButtons.IndexOf(item);
		statusLabel.Text = $"Index {num}";
		selectedIdx = num;
		slotSelected = false;
		int num2 = Css.wmEntries[num];
		int selectedIndex = characterBox.Items.Count - 1;
		int selectedIndex2 = characterBox.Items.Count - 2;
		switch (num2)
		{
		case -1:
			characterBox.SelectedIndex = selectedIndex;
			break;
		case -2:
			characterBox.SelectedIndex = selectedIndex2;
			break;
		default:
			characterBox.SelectedIndex = num2;
			break;
		}
		slotSelected = true;
	}

	private void CreateCSSBoxes()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 20; i++)
		{
			Button button = new Button();
			short num3 = Css.wmEntries[i];
			button.Text = $"{(Css.Human)num3}";
			button.Name = $"cssBox{i.ToString()}";
			button.Size = new Size(64, 64);
			button.Location = new Point(40 + num * 64, 40 + num2 * 64);
			button.Click += slotxx_Click;
			button.MouseDown += b_MouseDown;
			button.Enabled = true;
			base.Controls.Add(button);
			cssButtons.Add(button);
			num++;
			if (num % 5 == 0)
			{
				num = 0;
				num2++;
			}
		}
	}

	private void characterBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (slotSelected)
		{
			_ = characterBox.Items.Count;
			_ = characterBox.Items.Count;
			_ = characterBox.SelectedIndex;
			Css.Human selectedIndex = (Css.Human)characterBox.SelectedIndex;
			Css.wmEntries[selectedIdx] = (short)selectedIndex;
			cssButtons[selectedIdx].Text = $"{selectedIndex}";
		}
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
		this.components = new System.ComponentModel.Container();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.characterBox = new System.Windows.Forms.ComboBox();
		this.statusStrip1 = new System.Windows.Forms.StatusStrip();
		this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
		this.statusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
		this.characterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.characterBox.FormattingEnabled = true;
		this.characterBox.Items.AddRange(new object[33]
		{
			"Dummy", "Mitsurugi", "SeungMina", "Taki", "Maxi", "Voldo", "Sophitia", "Dummy2", "Dummy3", "Dummy4",
			"Dummy5", "Ivy", "Kilik", "Xianghua", "Dummy6", "Yoshimitsu", "Dummy7", "Nightmare", "Astaroth", "Inferno",
			"Cervantes", "Raphael", "Talim", "Cassandra", "Charade", "Necrid", "YunSeong", "Link", "Heihachi", "Spawn",
			"LizardMan", "Assassin", "Berserker"
		});
		this.characterBox.Location = new System.Drawing.Point(377, 43);
		this.characterBox.Name = "characterBox";
		this.characterBox.Size = new System.Drawing.Size(121, 21);
		this.characterBox.TabIndex = 2;
		this.characterBox.SelectedIndexChanged += new System.EventHandler(characterBox_SelectedIndexChanged);
		this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.statusLabel });
		this.statusStrip1.Location = new System.Drawing.Point(0, 319);
		this.statusStrip1.Name = "statusStrip1";
		this.statusStrip1.Size = new System.Drawing.Size(524, 22);
		this.statusStrip1.TabIndex = 3;
		this.statusStrip1.Text = "statusStrip1";
		this.statusLabel.Name = "statusLabel";
		this.statusLabel.Size = new System.Drawing.Size(42, 17);
		this.statusLabel.Text = "Index  ";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(524, 341);
		base.Controls.Add(this.statusStrip1);
		base.Controls.Add(this.characterBox);
		base.MaximizeBox = false;
		this.MaximumSize = new System.Drawing.Size(540, 380);
		base.MinimizeBox = false;
		this.MinimumSize = new System.Drawing.Size(540, 380);
		base.Name = "WeaponMaster";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Weapon Master CSS Editor";
		this.statusStrip1.ResumeLayout(false);
		this.statusStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
