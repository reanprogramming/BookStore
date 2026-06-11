using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Class;
using ComponentFactory.Krypton.Toolkit;
namespace BookStore
{
    public partial class frmlogin : KryptonForm
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        private void OnFocus(object sender, EventArgs e)
        {
            if (txtusername.Text.Trim() == variables.p_username_focus)
            {
                txtusername.Text = string.Empty;
            }
        }
        private void OnDefocus(object sender, EventArgs e)
        {
            if (txtusername.Text.Trim() == string.Empty)
            {
                txtusername.Text = variables.p_username_focus;
            }
        }

        private void OnDefocusPwd(object sender, EventArgs e)
        {
            if (txtpassword.Text.Trim() == string.Empty)
            {
                txtpassword.Text = variables.p_userpassword_focus;
            }
        }
        private void OnFocusPwd(object sender, EventArgs e)
        {
            if (txtpassword.Text.Trim() == variables.p_userpassword_focus)
            {
                txtpassword.Text = string.Empty;
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            try
            {
                //txtusername.Select();
                //this.ActiveControl = txtusername;
                //txtusername.Focus();

                DataTable dt = new DataTable();
                dt=sql.getData("select * from tblcurrencies ;");

                DataTable dt1 = new DataTable();
                string [] p = {"01"};
                dt1 = sql.proc_getData("book_get_currency", p);

                this.txtusername.GotFocus += OnFocus;
                this.txtusername.LostFocus += OnDefocus;
                this.txtpassword.GotFocus += OnFocusPwd;
                this.txtpassword.LostFocus += OnDefocusPwd;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {

        }
    }
}
