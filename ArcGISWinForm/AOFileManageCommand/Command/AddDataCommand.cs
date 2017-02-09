﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeanShen.AOFileManageCommand
{
    /*******************************
    ** 作者： shenxin
    ** 时间： 2016/12/06,周二 14:44:23
    ** 版本:  V1.0.0
    ** CLR:	  4.0.30319.18408	
    ** GUID:  4d293893-1dd1-4875-997f-dbb628f798a9
    ** 描述： 添加数据ControlsAddDataCommand（使用内置command）
    *******************************/
    public class AddDataCommand:SeanShen.Framework.SeanBaseCommand
    {
        private System.Drawing.Bitmap m_Bitmap;
        private DevExpress.XtraBars.BarItem m_BindBarItem;
        /// <summary>
        /// 构造函数设置ui图片
        /// </summary>
        public AddDataCommand()
        {
            try
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,Share.Consts.SMALLIMAGE_16 ,"AddData.png");
                this.m_Bitmap = new System.Drawing.Bitmap(path);
            }
            catch
            {
                this.m_Bitmap = null;
            }
        }
        #region ISeanCommand成员

        public override System.Drawing.Bitmap Bitmap
        {
            get { return this.m_Bitmap; }
        }

        public override DevExpress.XtraBars.BarItem BindBarItem { get { return this.m_BindBarItem; } set { this.m_BindBarItem = value; } }

        /// <summary>
        /// 分类
        /// </summary>
        public override string Category { get { return "AO文件工具"; } }//必须设置分类信息

        public override string Tooltip { get { return "添加数据"; } }
        public override void Run()
        {
            base.Run();
            ESRI.ArcGIS.SystemUI.ICommand command = new ESRI.ArcGIS.Controls.ControlsAddDataCommand();
            command.OnCreate(this.m_MapControl);
            command.OnClick();
        }
        # endregion


        #region ISeanResource成员
        public override Guid UID { get { return Guid.Parse("4d293893-1dd1-4875-997f-dbb628f798a9"); } }//抽象成员一定要重实现

        public override string Name { get { return "AddDataCommand"; } }

        public override string Caption
        {
            get { return "添加数据"; }
        }
        #endregion
    }
}
