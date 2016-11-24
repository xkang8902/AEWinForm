﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeanShen.Framework
{
    /*
    Time: 18/11/2016 10:09 PM 周五
    Author: shenxin
    Description: 主窗体管理布局接口
    Modify:
    */
    public interface ISeanLayoutManager
    {
        /// <summary>
        /// 加载默认布局
        /// </summary>
        void LoadDefaultLayout();
        /// <summary>
        /// 加载指定布局
        /// </summary>
        void LoadLayout();
        /// <summary>
        /// 保存当前的布局
        /// </summary>
        void SaveCurrentLayout();
        /// <summary>
        /// 另存为布局
        /// </summary>
        void SaveAsLayout();
        /// <summary>
        /// 设置界面的样式
        /// </summary>
        void SetVisualStyle();
    }
}
