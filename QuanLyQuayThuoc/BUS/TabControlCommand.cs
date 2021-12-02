using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BUS
{
    public class TabControlCommand : CommandBase
    {
        XtraTabControl tabParent;
        XtraUserControl userControl;
        string tabName;

        public TabControlCommand(XtraTabControl tabParent, XtraUserControl userControl, string tabName) 
        {
            this.tabParent = tabParent;
            this.userControl = userControl;
            this.tabName = tabName;
        }

        public override void Execute()
        {
            bool isExist = false;
            foreach (XtraTabPage page in tabParent.TabPages)
            {
                if (page.Text == tabName)
                {
                    isExist = true;
                    tabParent.SelectedTabPage = page;
                }
            }
            if (isExist == false)
            {
                XtraTabPage pageControl = new XtraTabPage();
                pageControl.PageVisible = true;
                pageControl.Text = tabName;
                pageControl.Controls.Add(userControl);
                tabParent.TabPages.Add(pageControl);
                tabParent.SelectedTabPage = pageControl;
            }
        }
    }
}
