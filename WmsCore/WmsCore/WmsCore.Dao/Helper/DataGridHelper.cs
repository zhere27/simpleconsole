﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WmsCore.Dao.Helper
{
    public class DataGridHelper
    {
        public DataGridHelper()
        {
        }

        public static void datagridFormatter(Page currPage, DataGrid currDatagrid, DataGridItemEventArgs e, bool IsClicked)
        {
            DataView dv = ((System.Data.DataView)(currDatagrid.DataSource));
            DataColumn dcCol = null;
            DataColumnCollection dc = dv.Table.Columns;
            string strKeyField = null;
            ListItemType itemType = e.Item.ItemType;

            foreach (System.Data.DataColumn transTemp0 in dv.Table.Columns)
            {
                dcCol = transTemp0; /* TRANSWARNING: check temp variable in foreach */
                if (e.Item.ItemType == ListItemType.AlternatingItem | e.Item.ItemType == ListItemType.Item)
                {
                    if (IsClicked == true)
                    {
                        strKeyField = currDatagrid.DataKeys[e.Item.ItemIndex].ToString();
                        e.Item.Attributes.Add("onmouseover", "this.style.cursor='hand'");
                    }
                }
            }
        }
    }
}