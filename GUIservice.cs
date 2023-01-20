using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Xml;

namespace myKEP
{
    public class GUIservice
    {
        public Form1 KEP;
        private Form myKEP;

        public GUIservice(Form myKEP)
        {
            this.myKEP = myKEP;
        }

        public void hideHomeElements()
        {
            KEP.
            
            
            avatarPB.Visible = false;
            welcome.Visible = false;
            add.Visible = false;
            delete.Visible = false;
            edit.Visible = false;
            list.Visible = false;
            addText.Visible = false;
            editText.Visible = false;
            listText.Visible = false;
            delText.Visible = false;
            back.Visible = true;
        }

        public void showHomeElements()
        {
            avatarPB.Visible = true;
            welcome.Visible = true;
            add.Visible = true;
            delete.Visible = true;
            edit.Visible = true;
            list.Visible = true;
            addText.Visible = true;
            editText.Visible = true;
            listText.Visible = true;
            delText.Visible = true;
            back.Visible = false;
        }

    }
}
