using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIFrameWork
{
    public class BaseUIInfo
    {

        public Dictionary<UIType, BaseUIInfo> BaseUIInfos = new Dictionary<UIType, BaseUIInfo>(); 
        public UIType Type { get; protected set; }
        /// <summary>
        /// 界面包含的元素
        /// </summary>
        public List<string> ItemNames = new List<string>();

        public BaseUIInfo(UIType type,List<string>Itemlist) 
        {
            Type = type;
            ItemNames = Itemlist;
        }
       
    }
}