using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class BetterButton : UserControl
    {
        public BetterButton()
        {
            InitializeComponent();

            this.label1.MouseEnter += OnMouseEnter;
            this.label1.MouseLeave += OnMouseLeave;

            this.label1.Click += OnClick;

        }

        void OnMouseEnter(object? sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(84, 86, 214);
        }

        void OnMouseLeave(object? sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(47, 48, 120);
            
        }

        public EventHandler ButtonClicked;

        void OnClick(object? sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private Size buttonSize = new(100, 30);
        private string text = "Zaloguj";

        [Category("Customize")]
        public string ButtonText
        {
            get { return text; }
            set 
            {
                text = value;
                label1.Text = text;
            }
        }


        [Category("Customize")]
        public Size ButtonSize
        {
            get { return buttonSize; }
            set
            {
                buttonSize = value;
                this.Size = buttonSize;
                label1.Size = buttonSize;
            }
        }

    }
}
