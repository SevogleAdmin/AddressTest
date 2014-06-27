using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace AddressTest
{
    public partial class EditForm : Form
    {
        private Outlook.MailItem _mailItem;

        public EditForm(Outlook.MailItem mailItem)
        {
            InitializeComponent();
            this._mailItem = mailItem;
            buttonRefresh_Click(null, null);
        }

        private void buttonResolveAll_Click(object sender, EventArgs e)
        {
            Outlook.Recipients recipients = _mailItem.Recipients;
            try
            {
                recipients.ResolveAll();
            }
            finally
            {
                if (null != recipients)
                {
                    Marshal.ReleaseComObject(recipients);
                }
            }
            buttonRefresh_Click(null, null);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listBoxTo.Items.Clear();
            listBoxCC.Items.Clear();

            Outlook.Recipients recipients = _mailItem.Recipients;
            try
            {
                for (int i = 1; i <= recipients.Count; i++)
                {
                    Outlook.Recipient rec = recipients[i];
                    try
                    {
                        Outlook.OlMailRecipientType recipientType = (Outlook.OlMailRecipientType)rec.Type;

                        switch (recipientType)
                        {
                            case Outlook.OlMailRecipientType.olTo:
                                listBoxTo.Items.Add("'" + rec.Name + "' <" + rec.Address + ">");
                                break;
                            case Outlook.OlMailRecipientType.olCC:
                                listBoxCC.Items.Add("'" + rec.Name + "' <" + rec.Address + ">");
                                break;
                            case Outlook.OlMailRecipientType.olBCC:
                                break;
                            case Outlook.OlMailRecipientType.olOriginator:
                                break;
                        }
                    }
                    finally
                    {
                        if (null != rec)
                        {
                            Marshal.ReleaseComObject(rec);
                        }
                    }

                }
            }
            finally
            {
                if (null != recipients)
                {
                    Marshal.ReleaseComObject(recipients);
                }
            }
        }

        private void buttonAddTo_Click(object sender, EventArgs e)
        {
            Add(textBoxTo.Text, Outlook.OlMailRecipientType.olTo);
            textBoxTo.Text = "";
        }

        private void buttonAddCC_Click(object sender, EventArgs e)
        {
            Add(textBoxCC.Text, Outlook.OlMailRecipientType.olCC);
            textBoxCC.Text = "";
        }

        private void Add(string address, Outlook.OlMailRecipientType type)
        {
            if (String.IsNullOrWhiteSpace(address))
            {
                return;
            }

            Outlook.Recipients recipients = _mailItem.Recipients;
            try
            {
                Outlook.Recipient recipient = null;
                try
                {
                    recipient = recipients.Add(address);
                    recipient.Type = (int)type;
                    recipient.Resolve();
                }
                catch { }
                finally
                {
                    if (null != recipient)
                    {
                        Marshal.ReleaseComObject(recipient);
                        recipient = null;
                    }
                }
            }
            finally
            {
                if (null != recipients)
                {
                    Marshal.ReleaseComObject(recipients);
                }
            }
            buttonRefresh_Click(null, null);
        }

        private void buttonDeleteFirstTo_Click(object sender, EventArgs e)
        {
            DeleteFirst(Outlook.OlMailRecipientType.olTo);
        }

        private void buttonDelete1stCC_Click(object sender, EventArgs e)
        {
            DeleteFirst(Outlook.OlMailRecipientType.olCC);
        }

        private void DeleteFirst(Outlook.OlMailRecipientType type)
        {
            Outlook.Recipients recipients = _mailItem.Recipients;
            try
            {
                for (int i = 1; i <= recipients.Count; i++)
                {
                    Outlook.Recipient rec = recipients[i];
                    try
                    {
                        Outlook.OlMailRecipientType recipientType = (Outlook.OlMailRecipientType)rec.Type;
                        if (recipientType == type)
                        {
                            recipients.Remove(i);
                            return;
                        }
                    }
                    finally
                    {
                        if (null != rec)
                        {
                            Marshal.ReleaseComObject(rec);
                        }
                    }

                }
            }
            finally
            {
                if (null != recipients)
                {
                    Marshal.ReleaseComObject(recipients);
                }
                buttonRefresh_Click(null, null);
            }
        }

    }
}
