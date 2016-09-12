using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TDUCFM.DataBase;
using TDUCFM.Models;

namespace TDUCFM
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {InitializeComponent();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            bool valid = false;
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain,"south.vcb.com"))
            {
                valid = context.ValidateCredentials(txeUserName.Text, txePassword.Text);
                MessageBox.Show(txePassword.Text);
            }
            MessageBox.Show(valid.ToString());
            if (valid)
            {
            
                User logginguser;
                using (TDUCFMDataContext context1 = new TDUCFMDataContext())
                {
                    logginguser = context1.Users.FirstOrDefault(u => u.UserName == txeUserName.Text);
                }
                if (logginguser != null)
                {
                    MessageBox.Show(logginguser.UserRole.ToString());
                }
            }
            }
    }
}