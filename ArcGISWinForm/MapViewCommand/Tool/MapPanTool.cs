﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeanShen.MapViewCommand
{
    using Framework;
    /// <summary>
    /// pan
    /// </summary>
    public class MapPanTool : SeanBaseTool
    {
        private System.Drawing.Bitmap m_Bitmap;
        private DevExpress.XtraBars.BarItem m_BindBarItem;
        /// <summary>
        /// 构造函数设置ui图片
        /// </summary>
        public MapPanTool()
        {
            try
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Share.Consts.SMALLIMAGE_16, "PanTool.png");
                this.m_Bitmap = new System.Drawing.Bitmap(path);
            }
            catch
            {
                this.m_Bitmap = null;
            }
        }
        #region ISeanCommand成员
        public override System.Drawing.Bitmap Bitmap { get { return this.m_Bitmap; }}
        /// <summary>
        /// 分类
        /// </summary>
        public override string Category { get { return "地图视图工具"; } }//必须设置分类信息
        
        public override string Tooltip { get { return "地图漫游"; } }

        public override DevExpress.XtraBars.BarItem BindBarItem { get { return this.m_BindBarItem; } set { this.m_BindBarItem = value; } }

        public override void Run()
        {
            base.Run();
            ESRI.ArcGIS.SystemUI.ICommand tool = new ESRI.ArcGIS.Controls.ControlsMapPanToolClass();
            tool.OnCreate(this.m_MapControl);
            this.m_MapControl.CurrentTool = (ESRI.ArcGIS.SystemUI.ITool)tool;
        }
        # endregion


        #region ISeanResource成员
        public override Guid UID { get { return Guid.Parse("D55F27D6-B49C-41B6-9DE3-6E060BFC8B76"); } }//抽象成员一定要重实现

        public override string Name { get { return "MapPanTool"; } }

        public override string Caption
        {
            get { return "地图漫游"; }
        }
        #endregion
    }
}
