using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics;

namespace ManagementApp
{
    public partial class LogInForm : Form
    {

        

        public LogInForm()
        {
            InitializeComponent();

            panel1.MouseDown += OnBarEnter;
            panel1.MouseUp += OnBarLeave;
            panel1.MouseMove += OnBarMove;

            betterButton1.ButtonClicked += OnButtonClick;

            
        }

        private bool isMouseHovering = false;
        private Point lastPoint;

        private void OnBarEnter(object? sender, MouseEventArgs e) 
        { 
            isMouseHovering = true; 
            lastPoint = new Point(e.X, e.Y); 
            
        }

        private void OnBarLeave(object? sender, EventArgs e) 
        { 
            isMouseHovering = false; 
        }

        private void OnBarMove(object? sender, MouseEventArgs e)
        {
            if(isMouseHovering)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.lastPoint.X, p.Y - this.lastPoint.Y);
            }
        }
        
        async void OnButtonClick(object? sender, EventArgs e)
        {
            var logged = await Login.Try(LoginBox.Text, PasswordBox.Text);
            if (logged == true)
            {
                MgmtForm mgmtForm = new MgmtForm();
                mgmtForm.Show();
                this.Hide();
            }
        }

    }
}