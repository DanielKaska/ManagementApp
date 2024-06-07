using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ManagementApp
{
    public partial class MgmtForm : Form
    {
        public MgmtForm()
        {
            InitializeComponent();
            FormClosed += OnFormClosed;
            SearchButton.ButtonClicked += OnSearchClicked;
            closeButton.MouseEnter += OnCloseHover;
            closeButton.Click += OnCloseClick;
            closeButton.MouseLeave += OnCloseLeave;
            topBar.MouseMove += OnBarMove;
            topBar.MouseDown += OnMouseBarEnter;
            topBar.MouseUp += OnMouseBarLeave;

            AddButton.ButtonClicked += OnAddButtonClicked;

        }

        private bool isMouseHovering = false;
        private Point lastPoint;

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            string[] data = {"add", LoginBox.Text, SurnameBox.Text};
            await Logic.ConnectToServer(data);
        }

        private async void OnSearchClicked(object? sender, EventArgs args)
        {
            string[] data = { "get", richTextBox1.Text };
            await Logic.ConnectToServer(data);
        }

        private void OnFormClosed(object? sender, EventArgs args)
        {
            Application.Exit();
        }

        private void OnCloseHover(object? sender, EventArgs args)
        {
            closeButton.BackColor = Color.Red;
        }

        private void OnCloseClick(object? sender, EventArgs args)
        {
            Application.Exit();
        }

        private void OnMouseBarEnter(object? sender, MouseEventArgs e)
        {
            isMouseHovering = true;
            lastPoint = new Point(e.X, e.Y);
        }

        private void OnMouseBarLeave(object? sender, EventArgs args)
        {
            isMouseHovering = false;
        }

        private void OnBarMove(object? sender, MouseEventArgs e)
        {
            if (isMouseHovering)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.lastPoint.X, p.Y - this.lastPoint.Y);
            }
        }

        private void OnCloseLeave(object? sender, EventArgs args)
        {
            closeButton.BackColor = Color.FromArgb(84, 86, 214);
        }
    }
}
