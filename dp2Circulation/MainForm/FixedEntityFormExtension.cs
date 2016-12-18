﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dp2Circulation
{
    /// <summary>
    /// MainForm 有关左侧固定种册窗的功能
    /// </summary>
    public partial class MainForm
    {
        public EntityForm FixedEntityForm
        {
            get
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form is EntityForm)
                    {
                        EntityForm detail = form as EntityForm;
                        if (detail.Fixed)
                            return detail;
                    }
                }
                return null;
            }
        }

        // 设置窗口到左侧固定位置
        // TODO: 要根据左侧窗口宽度，把剩余宽度给右侧窗口
        public void SetFixedPosition(Form form, string strStyle)
        {
            MdiClient client = this.MdiClient;  //  GetMdiClient();
            if (strStyle == "left")
            {
                form.Location = new Point(0, 0);
                form.Size = new Size((client.ClientSize.Width / 2) - 1, client.ClientSize.Height - 1);
            }
            else
            {
                int nLeftWidth = client.ClientSize.Width / 2;
                EntityForm exist = this.FixedEntityForm;
                if (exist != null)
                    nLeftWidth = exist.Width;
                form.Location = new Point(nLeftWidth, 0);
                form.Size = new Size(client.ClientSize.Width - nLeftWidth - 1, client.ClientSize.Height - 1);
#if NO
                form.Location = new Point(client.ClientSize.Width / 2, 0);
                form.Size = new Size((client.ClientSize.Width / 2) - 1, client.ClientSize.Height - 1);
#endif
            }
        }

        public void SetMdiToNormal()
        {
            if (this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.WindowState != FormWindowState.Normal)
                    this.ActiveMdiChild.WindowState = FormWindowState.Normal;
            }
        }

        internal BiblioSearchForm _dockedBiblioSearchForm = null;

        // 根据 ListView 找到它所从属的 BiblioSearchForm
        public BiblioSearchForm GetOwnerBiblioSearchForm(Control listView)
        {
            if (_dockedBiblioSearchForm != null && _dockedBiblioSearchForm.ListViewRecords == listView)
                return _dockedBiblioSearchForm;

            foreach (Form child in this.MdiChildren)
            {
                if (child is BiblioSearchForm)
                {
                    BiblioSearchForm searchForm = (BiblioSearchForm)child;
                    if (searchForm.ListViewRecords == listView)
                        return searchForm;
                }
            }

            return null;
        }
    }
}
