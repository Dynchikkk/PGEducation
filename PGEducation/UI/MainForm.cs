using PGEducation.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGEducation.UI
{
    public partial class MainForm : Form
    {
        private SqlTableManager _sqlTableManager;

        public MainForm()
        {
            InitializeComponent();

            _sqlTableManager = new SqlTableManager();
        }
    }
}
